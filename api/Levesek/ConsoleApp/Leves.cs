using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Leves
    {
        //`levesekkod`,`megnevezes`,`kaloria`,`feherje`,`zsir`,`szenhidrat`,`hamu`,`rost`
        public int levesekkod;
        public string megnevezes;
        public int kaloria;
        public double feherje;
        public double zsir;
        public double szenhidrat;
        public double hamu;
        public double rost;

        public Leves(int levesekkod, string megnevezes, int kaloria, double feherje, double zsir, double szenhidrat, double hamu, double rost)
        {
            this.levesekkod = levesekkod;
            this.megnevezes = megnevezes;
            this.kaloria = kaloria;
            this.feherje = feherje;
            this.zsir = zsir;
            this.szenhidrat = szenhidrat;
            this.hamu = hamu;
            this.rost = rost;
        }
    }
}
