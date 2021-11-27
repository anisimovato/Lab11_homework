using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11uravn
{
    public class Uravnenie
    {
        public double k;
        public double B { get; set; }
        public double x;

        public double K
        {
            set
            {
                if (value != 0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("K не может быть равным 0");
                }
            }
            get
            {
                return k;
            }
        }


        public Uravnenie(double k, double b)
        {
            K = k;
            B = b;

        }


        public void X()
        {
            x = -B / K;
            Console.WriteLine($"Ответ: {x}");
        }
    }
}
