using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL.Modeli
{
    public class Racun
    {
        List<Racun> racuni = new List<Racun>();
        public static int id = 1;
        public int Id { get; private set; }
        public string ArtikalNaziv { get; set; }
        public double KolicinaRacun { get; set; }
        public static DateTime Datum { get; }
        public List<Artikal> artikli { get; set; }
        public Racun()
        {
            Id = id++;
            artikli = new List<Artikal>();
        }
        public Racun RacunZaId(int id)
        {
            var svi_racuni = from racun in racuni
                             where Id == id
                             select racun;
            return svi_racuni.FirstOrDefault();
        }

        public string RacunDan()
        {
            var dan = Datum.Day;
            return dan.ToString();
        }

        public string RacunMesec()
        {
            var mesec = Datum.Month;
            return mesec.ToString();
        }

        public string RacunGodina()
        {
            var godina = Datum.Year;
            return godina.ToString();
        }
        public List<Racun> SviRacuni()
        {
            var svi_racuni = from racun in racuni
                             select racun;
            return svi_racuni.ToList();
        }
        public override string ToString()
        {
            return $"{ArtikalNaziv} {KolicinaRacun}";
        }
    }
}
