using System;
using System.Collections.Generic;
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
        int ar; //-- EUR-ban

        public ulong LaptopId { get => laptopId; set => laptopId = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Szin { get => szin; set => szin = value; }
        public string Processzor { get => processzor; set => processzor = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public int Kepernyomeret { get => kepernyomeret; set => kepernyomeret = value; }
        public string Felbontas { get => felbontas; set => felbontas = value; }
        public int Merevlemezkapacitas { get => merevlemezkapacitas; set => merevlemezkapacitas = value; }
        public int Ar { get => ar; set => ar = value; }
        public string Modell { get => modell; set => modell = value; }

        public Laptop(ulong laptopId, string marka, string szin, string processzor, int memoria, int kepernyomeret, string felbontas, int merevlemezkapacitas, int ar, string modell)
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
        override public string ToString()
        {
            return $"{Marka} {Modell}";
        }
    }
}
