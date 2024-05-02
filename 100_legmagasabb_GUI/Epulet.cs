using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_legmagasabb_GUI
{
    class Epulet
    {
        private int rang_;
        private string nev_;
        private string hely_;
        private double magassag_;
        private double magassag_ft_;
        private int emelet_;
        private int epitesi_ev_;
        

        public Epulet(int rang_, string nev_, string hely_, double magassag_, double magassag_ft_, int emelet_, int epitesi_ev_)
        {
            this.rang_ = rang_;
            this.nev_ = nev_;
            this.hely_ = hely_;
            this.magassag_ = magassag_;
            this.magassag_ft_ = magassag_ft_;
            this.emelet_ = emelet_;
            this.epitesi_ev_ = epitesi_ev_;
            
        }

        public int Rang_ { get => rang_; set => rang_ = value; }
        public string Nev_ { get => nev_; set => nev_ = value; }
        public string Hely_ { get => hely_; set => hely_ = value; }
        public double Magassag_ { get => magassag_; set => magassag_ = value; }
        public double Magassag_ft_ { get => magassag_ft_; set => magassag_ft_ = value; }
        public int Emelet_ { get => emelet_; set => emelet_ = value; }
        public int Epitesi_ev_ { get => epitesi_ev_; set => epitesi_ev_ = value; }
       
        public bool TutiEpulet()
        {
            if (this.Magassag_ > 500 && this.Emelet_ > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Nev_;
        }
    }
}
