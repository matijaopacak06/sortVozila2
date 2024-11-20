


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sortiranje_Vozizila2


{
    public class Vozilo
    {
        private string marka;
        private string model;
        private int godinaProizvodnje;
        private int kilometraza;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public int Kilometraza { get => kilometraza; set => kilometraza = value; }

        public Vozilo(string marka, string model, int godinaProizvodnje, int kilometraza)
        {
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kilometraza = kilometraza;
        }

        public override string ToString()
        { 
            return $"{Marka} {Model},Godina: {GodinaProizvodnje}, Kilometraza:{Kilometraza}km:";
        }
    }
}