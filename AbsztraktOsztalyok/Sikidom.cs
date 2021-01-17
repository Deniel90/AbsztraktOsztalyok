using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    abstract class Sikidom
    {
        private double a;

        protected Sikidom(double a)
        {
            this.a = a;
        }

        public double A { get => a; set => a = value; }
        protected abstract double Terulet { get; }
        protected abstract double Kerulet { get; }

        public override string ToString()
        {
            return String.Format($"K = {this.Kerulet} cm, T = {this.Terulet} cm2");
        }
    }
}
