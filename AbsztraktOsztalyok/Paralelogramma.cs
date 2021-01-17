using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Paralelogramma : Sikidom
    {
        private double b;
        private double alfa;
        public Paralelogramma(double a, double b, double alfa) : base(a)
        {
            this.b = b;
            this.alfa = alfa;
        }

        public double B { get => b; set => b = value; }
        public double Alfa { get => alfa; set => alfa = value; }
        protected override double Terulet
        {
            get
            {
                return this.A * this.B * Math.Sin(Alfa);
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
            return String.Format($"a = {this.A} cm, b = {this.B} cm, alfaszög = {this.Alfa}, {base.ToString()}");
        }
    }
}
