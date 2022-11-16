using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL.Modeli
{
    public class Povrce : Artikal
    {
        public string JedinicaMere { get; set; }
        public int CenaPoJedinici { get; set; }
        public string NazivPovrca { get { return Naziv; } }
        public Povrce(string jedinicamere, int cenapojedinici, string nazivpovrca)
        {
            JedinicaMere = jedinicamere;
            CenaPoJedinici = cenapojedinici;
            Naziv = nazivpovrca;
        }
        public override double Cena()
        {
            return CenaPoJedinici * Kolicina;
        }
        public override string ToString()
        {
            return $"{NazivPovrca} [{Cena()}/{JedinicaMere}";
        }
    }
}
