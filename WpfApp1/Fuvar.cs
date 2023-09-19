using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Fuvar
    {
        private int taxiAzonosito;
        private string indulasiIdopont;
        private int utazasIdotartama;
        private float megtettTavolsag;
        private float viteldij;
        private float borravaló;
        private string fizetesModja;

        

        public Fuvar(int taxiAzonosito, string indulasiIdopont, int utazasIdotartama, float megtettTavolsag, float viteldij, float borravaló, string fizetesModja)
        {   
            this.taxiAzonosito = taxiAzonosito;
            this.indulasiIdopont = indulasiIdopont;
            this.utazasIdotartama = utazasIdotartama;
            this.megtettTavolsag = megtettTavolsag;
            this.viteldij = viteldij;
            this.borravaló = borravaló;
            this.fizetesModja = fizetesModja;
        }
        public int TaxiAzonosito { get => taxiAzonosito;}
        public string IndulasiIdopont { get => indulasiIdopont;}
        public int UtazasIdotartama { get => utazasIdotartama; }
        public float MegtettTavolsag { get => megtettTavolsag; }
        public float Viteldij { get => viteldij; }
        public float Borravaló { get => borravaló; }
        public string FizetesModja { get => fizetesModja; }

    }
}
