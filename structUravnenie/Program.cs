using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie uravnenie = new Uravnenie();
            uravnenie.X();
        }
        struct Uravnenie
        {
            public double k;
            public double b;


            public void X()
            {
                Console.WriteLine($"Ответ: x");
            }
        }
    }
}
