using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Kor : Sikidom
    {
        public Kor(double r) : base(r)
        {
        }

        public double R
        {
            get => A; set => this.A = value;
        }

        protected override double Terulet
        {
            get
            {
                return Math.Pow(R, 2) * Math.PI;
            }
        }

        protected override double Kerulet
        {
            get
            {
                return 2 * R * Math.PI;
            }
        }

        public override string ToString()
        {
            return String.Format($"a = {A} cm, {base.ToString()}");
        }
    }
}
