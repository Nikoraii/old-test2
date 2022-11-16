using ProdavnicaPCL.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL.Servis
{
    public class ProdavnicaServis
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        List<Racun> racuni = new List<Racun>();
    }
}
