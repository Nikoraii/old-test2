using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL.Modeli
{
    public abstract class Artikal
    {
        public static List<Artikal> artikli { get; set; } = new List<Artikal>();
        protected string Naziv { get; set; }
        public double Kolicina { get; set; }
        public abstract double Cena();
    }
}
