using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Teglalap : Sikidom
    {
        private double b;

        public Teglalap(double a, double b) : base(a)
        {
            this.b = b;
        }

        public double B { get => b; set => b = value; }

        protected override double Terulet
        {
            get
            {
                return this.A * this.B;
            }
        }

        protected override double Kerulet
        {
            get
            {
                return (this.A + this.B) * 2;
            }
        }

        public override string ToString()
        {
            return String.Format($"a = {this.A} cm, b = {this.B} cm, {base.ToString()}");
        }
    }
}
