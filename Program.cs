using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NP;
            double TOT;

            Console.WriteLine("Numero de personas: ");
            NP = Convert.ToInt32(Console.ReadLine());

            if (NP > 300)
            {
                TOT = NP * 75;
            }
            else if (NP >200)
            {
                TOT = NP * 85;
            }
            else
            {
                TOT = NP * 95;     
            }
            Console.WriteLine("El presupuesto total es: " + TOT);
        }
    }
}