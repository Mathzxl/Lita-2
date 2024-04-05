using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que peça ao usuário para digitar 10 valores e some - os.
            double n,c=0,total = 0;
            while(c != 10)
            {
                Console.WriteLine("Digite um número");
                n = double.Parse(Console.ReadLine());
                c++;
                total = n + total;
            }
            Console.WriteLine("A soma os números é: " + total);
            Console.ReadLine();
        }
    }
}
