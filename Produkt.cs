using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP08
{
    class Produkt:Zbozi
    {
        private bool lzeZlevnit;
        public Produkt(string nazev,double cena, DateTime datumVyroby, int minTrvanlivost,bool lzeZlevnit):base(nazev,cena,datumVyroby,minTrvanlivost)
        {
            this.lzeZlevnit = lzeZlevnit;
        }
        public override double cenaSDPH()
        {
            if (!SplnujeMinTrvanlivost())
            {
                return (base.cenaSDPH() / 100) * 60;
            }
            else
            {
                return base.cenaSDPH();
            }
        }
        public override string ToString()
        {
            string s = "\nNelze zlevnit";
            if(lzeZlevnit)
            {
                s = "\nLze zlevnit";
            }
            return base.ToString()+s;
        }

    }
}
