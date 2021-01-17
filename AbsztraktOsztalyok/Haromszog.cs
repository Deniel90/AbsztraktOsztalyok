using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Haromszog : Sikidom
    {
        private double b;
        private double c;

        public Haromszog(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }

        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        protected override double Terulet
        {
            get
            {
                return Math.Sqrt(S*(S-A)*(S-B)*(S-C));
            }
        }

        private double S
        {
            get
            {
                return Kerulet / 2;
            }
        }

        protected override double Kerulet {
            get
            {
                return this.A + this.B + this.C;
            } 
        }

        public override string ToString()
        {
            return String.Format($"a = {A} cm, b = {B} cm, c = {C} cm {base.ToString()}");
        }
    }
}
