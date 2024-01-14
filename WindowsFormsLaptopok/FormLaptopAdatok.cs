using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLaptopok
{
    public partial class FormLaptopAdatok : Form
    {
        string operation;
        public FormLaptopAdatok(string operation = null)
        {
            InitializeComponent();
            this.operation = operation;
        }

        private void FormLaptopAdatok_Load(object sender, EventArgs e)
        {
            comboBox_Valuta.DataSource = Program.rates.Keys.ToList(); // a rates Dictionary kulcsait listába tesszük és ezt adjuk a comboBox_Valuta DataSource-jának
            comboBox_Valuta.SelectedItem = "HUF"; // a comboBox_Valuta alapértelmezett értéke a HUF lesz
            switch (operation)
            {
                case "add":
                    this.Text = "Új laptop felvétele";
                    button_operation.Text = "Felvétel";
                    button_operation.BackColor = Color.Green;
                    button_operation.Click += new EventHandler(button_add_Click);
                    break;
                case "edit":
                    this.Text = "Laptop adatainak módosítása";
                    button_operation.Text = "Módosítás";
                    button_operation.BackColor = Color.Yellow;
                    button_operation.Click += new EventHandler(button_edit_Click);
                    adatokatBetolt();
                    break;
                case "delete":
                    this.Text = "Laptop törlése";
                    button_operation.Text = "Törlés";
                    button_operation.BackColor = Color.Red;
                    button_operation.Click += new EventHandler(button_delete_Click);
                    adatokatBetolt();
                    break;
                default:
                    button_operation.Visible = false;
                    break;
            }
        }
        private void adatokatBetolt()
        {
            Laptop laptop =(Laptop) Program.formMain.listBox_Laptopok.SelectedItem;
            textBox_Marka.Text = laptop.Marka;
            textBox_Model.Text = laptop.Modell;
            textBox_Szin.Text = laptop.Szin;
            textBox_Processzor.Text = laptop.Processzor;
            numericUpDown_Memoria.Value = laptop.Memoria;
            numericUpDown_Kepernyomeret.Value = laptop.Kepernyomeret;
            textBox_Felbontas.Text = laptop.Felbontas;
            numericUpDown_Merevlemez.Value = laptop.Merevlemezkapacitas;
            numericUpDown_Ar.Value = laptop.Ar;
            pictureBox_Laptopkep.Image = laptop.getKep();
            pictureBox_Laptopkep.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void numericUpDown_Ar_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_ArOther.Value = numericUpDown_Ar.Value * (decimal)Program.rates[comboBox_Valuta.SelectedItem.ToString()];
        }

        private void comboBox_Valuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown_ArOther.Value = numericUpDown_Ar.Value * (decimal)Program.rates[comboBox_Valuta.SelectedItem.ToString()];
        }
    }
}
