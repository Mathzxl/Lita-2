using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que determine o mostre os cinco primeiros múltiplos de 3, considerando
números maiores que 0.*/
            //3,6,9,12,15
            Console.WriteLine("Os cincos primeiro mútiplos de 3 são: ");
            int c = 3;
            while(c != 18)
            {
                Console.WriteLine(c);
                c = c + 3;
            }
            Console.ReadLine();
        }
    }
}
