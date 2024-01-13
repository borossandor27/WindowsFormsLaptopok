using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLaptopok;

namespace WindowsFormsLaptopok
{
    public partial class FormMain : Form
    {
        public Dictionary<string, double> rates = new Dictionary<string, double>();
        public string baseCurrency { get; set; } = "EUR";
        public FormMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await getAllRates(); // a getAllRates() metódus segítségével feltöltjük a rates Dictionary-t
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
                    rates = result.ConversionRates;
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

    }
}
