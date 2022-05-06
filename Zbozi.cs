using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP08
{
    class Zbozi
    {
        private string nazev;
        private double cena = 0;
        private DateTime datumVyroby;
        private int minTrvanlivost;
        public Zbozi(string nazev, double cena, DateTime datumVyroby, int minTrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.minTrvanlivost = minTrvanlivost;
        }
        public bool SplnujeMinTrvanlivost()
        {
            bool zboziJeVZaruce = false;
            DateTime posledniDenZaruky = datumVyroby.AddDays(minTrvanlivost);
            if (posledniDenZaruky >= DateTime.Today) zboziJeVZaruce = true;
            return zboziJeVZaruce;
        }
        public virtual double cenaSDPH()
        {
            return (cena / 100) * 121;
        }
        public override string ToString()
        {
            string s = "\nNázev je: " + nazev +
                    "\nCena je: " + cena +
                    "\nDatum Výroby je: " + datumVyroby +
                    "\nMinimální trvanlivost od datumu výroby je: " + minTrvanlivost +
                    " Dní\nCena s DPH: " + cenaSDPH()+
                    "\nZboží je prošlé";
            if (SplnujeMinTrvanlivost())
            {
                 s = "\nNázev je: " + nazev +
                    "\nCena je: " + cena +
                    "\nDatum Výroby je: " + datumVyroby.ToShortDateString() +
                    "\nMinimální trvanlivost od datumu výroby je: " + minTrvanlivost +
                    " Dní\nCena s DPH: " + cenaSDPH()+
                    "\nZboží není prošlé";
            }
            return base.ToString() +s;
        }
    }
}
