using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLaptopok;
using System.Linq;

namespace WindowsFormsLaptopok
{
    public partial class FormMain : Form
    {
        string[] gyartok = Program.laptopok.Select(x => x.Marka).Distinct().ToArray();
        public string baseCurrency { get; set; } = "EUR";
        public FormMain()
        {
            InitializeComponent();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await getAllRates(); // a getAllRates() metódus segítségével feltöltjük a rates Dictionary-t
            //-- a gyártók listájának feltöltése a panel_gyartok conatiner-be
            foreach (string gyarto in gyartok)
            {
                CheckBox cb = new CheckBox();
                cb.Text = gyarto;
                cb.AutoSize = true;
                cb.Location = new System.Drawing.Point(10, 10 + panel_Gyartok.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(cb_CheckedChanged);
                panel_Gyartok.Controls.Add(cb);
            }
            updateLaptopListBox();
        }

        private void updateLaptopListBox()
        {
            listBox_Laptopok.Items.Clear();
            List<string> kivalasztottGyartok = new List<string>();
            foreach (CheckBox cb in panel_Gyartok.Controls)
            {
                if (cb.Checked)
                {
                    kivalasztottGyartok.Add(cb.Text);
                }
            }
            foreach (Laptop laptop in Program.laptopok)
            {
                if (kivalasztottGyartok.Contains(laptop.Marka))
                {
                    listBox_Laptopok.Items.Add(laptop);
                }
                
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            updateLaptopListBox();
        }

        async Task getAllRates()
        {
            Task getCurrencyRates = getCurrencyRatesAsync(); //-- létrehozunk egy új Task-ot, hogy a szinkron műveletet tovább tudjuk futtatni 
            await getCurrencyRates;
        }
        async Task getCurrencyRatesAsync()
        {
            //-- regisztrálj az https://www.exchangerate-api.com/ web helyen, hogy megkapd az egyéni API kulcsodat    
            string apiKey = ConfigurationManager.AppSettings.Get("apiKey"); // Helyettesítsd az API kulcsoddal
            string apiUrl = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{baseCurrency}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(apiUrl);
                    if (response == null)
                    {
                        throw new Exception("Nincs válasz a szerverről!");
                    }

                    var result = JsonConvert.DeserializeObject<CurrencyConverter>(response);
                    Program.rates = result.ConversionRates;
                }
                catch (HttpRequestException ex)
                {
                    // Hálózati hiba esetén kezeljük a kivételt
                    throw new Exception($"Hálózati hiba: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Egyéb kivétel esetén
                    throw new Exception($"Hiba történt: {ex.Message}");
                }
            }
            Task.Delay(1000).Wait();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaptopAdatok formLaptopAdatok = new FormLaptopAdatok("add");
            formLaptopAdatok.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Laptopok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva laptop!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormLaptopAdatok formLaptopAdatok = new FormLaptopAdatok("edit");
            formLaptopAdatok.ShowDialog();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Laptopok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva laptop!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormLaptopAdatok formLaptopAdatok = new FormLaptopAdatok("delete");
            formLaptopAdatok.ShowDialog();
        }

        private void listBox_Laptopok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            módosítToolStripMenuItem_Click(sender, e);
        }
    }
}
