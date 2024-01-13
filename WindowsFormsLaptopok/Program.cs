using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
namespace WindowsFormsLaptopok
{
    internal static class Program
    {
        public static List<Laptop> laptopok = new List<Laptop>();
        public static FormMain formMain;
        public static Adatbazis adatbazis;
        static void Main()
        {
            adatbazis = new Adatbazis();
            laptopok = adatbazis.getAllLaptops();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
