using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLaptopok
{
    internal class Laptop
    {
        ulong laptopId; //-- egyedi azonosító, auto increment
        string marka;   //-- gyártó
        string modell;  //-- típus
        string szin;
        string processzor;
        int memoria;    //-- GB-ban
        int kepernyomeret; //-- inch-ben
        string felbontas; //-- width x height
        int merevlemezkapacitas; //-- GB-ban
        decimal ar; //-- EUR-ban

        public ulong LaptopId { get => laptopId; set => laptopId = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Szin { get => szin; set => szin = value; }
        public string Processzor { get => processzor; set => processzor = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public int Kepernyomeret { get => kepernyomeret; set => kepernyomeret = value; }
        public string Felbontas { get => felbontas; set => felbontas = value; }
        public int Merevlemezkapacitas { get => merevlemezkapacitas; set => merevlemezkapacitas = value; }
        public decimal Ar { get => ar; set => ar = value; }
        public string Modell { get => modell; set => modell = value; }

        public Laptop(ulong laptopId, string marka, string szin, string processzor, int memoria, int kepernyomeret, string felbontas, int merevlemezkapacitas, decimal ar, string modell)
        {
            LaptopId = laptopId;
            Marka = marka;
            Szin = szin;
            Processzor = processzor;
            Memoria = memoria;
            Kepernyomeret = kepernyomeret;
            Felbontas = felbontas;
            Merevlemezkapacitas = merevlemezkapacitas;
            Ar = ar;
            Modell = modell;
        }

        public Laptop()
        {
        }

        override public string ToString()
        {
            return $"{Marka} {Modell} ({this.ar})";
        }
        public decimal getArOther(string valutaNem = "HUF")
        {
            return (decimal)this.ar * Program.rates[valutaNem];
        }

        internal Image getKep()
        {
            return Image.FromFile($"images{Path.DirectorySeparatorChar}HP Pavilion Intel Core i5.png");
        }
    }
}
