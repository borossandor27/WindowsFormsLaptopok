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
                    break;
                case "delete":
                    this.Text = "Laptop törlése";
                    button_operation.Text = "Törlés";
                    button_operation.BackColor = Color.Red;
                    button_operation.Click += new EventHandler(button_delete_Click);
                    break;
                default:
                    button_operation.Visible = false;
                    break;
            }
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
    }
}
