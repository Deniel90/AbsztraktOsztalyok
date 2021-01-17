using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszog h1 = new Haromszog(2, 3, 4);
            Console.WriteLine(h1);

            Kor k = new Kor(2.6);
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
