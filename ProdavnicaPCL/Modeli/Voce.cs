using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL.Modeli
{
    public class Voce : Artikal
    {
        public string JedinicaMere { get; set; }
        public int CenaPoJedinici { get; set; }
        public string NazivVoca { get { return Naziv; } }
        public string Tip { get; set; }
        public Voce(string jedinicamere, int cenapojedinici, string nazivpovrca, string tip)
        {
            JedinicaMere = jedinicamere;
            CenaPoJedinici = cenapojedinici;
            Naziv = nazivpovrca;
            Tip = tip;
        }
        public override double Cena()
        {
            return CenaPoJedinici * Kolicina;
        }
        public override string ToString()
        {
            return $"{NazivVoca} - {Tip} [{Cena()}/{JedinicaMere}";
        }
    }
}
