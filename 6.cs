using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {//Faça um programa que leia 10 inteiros e imprima sua média.
            int i = 0,s=0, m,n;
            while(i <= 9)
            {
                Console.WriteLine("Dê um numero qualquer");
                n = int.Parse(Console.ReadLine());
                i++;
                s = n + s;
            }
            m = s / 10;
            Console.WriteLine("A media dos números é igual á: " + m);
            Console.ReadLine();
        }
    }
}
