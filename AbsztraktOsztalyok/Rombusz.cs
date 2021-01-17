using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Rombusz : Sikidom
    {
        private double alfa;
        public Rombusz(double a, double alfa) : base(a)
        {
            this.alfa = alfa;
        }

        public double Alfa { get => alfa; set => alfa = value; }

        protected override double Terulet
        {
            get
            {
                return this.A * this.A * Math.Sin(Alfa);
            }
        }

        protected override double Kerulet
        {
            get
            {
                return 4 * this.A;
            }
        }

        public override string ToString()
        {
            return String.Format($"a = {this.A} cm, alfaszög = {this.Alfa}, {base.ToString()}");
        }
    }
}
