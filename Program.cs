using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(2, 8);
            Fraction fr2 = new Fraction(1, 4);
            //Console.WriteLine(fr.ToString());
            Console.WriteLine(fr2.ToString());


            Console.WriteLine(fr.Equals(fr)); 


        }
    }
}
