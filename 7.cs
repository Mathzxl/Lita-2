using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 10 inteiros positivos, ignorando não positivos, e imprima sua
média.*/
            int n, c = 0,m,s=0;
            while(c <= 9)
            {
                Console.WriteLine("Dê o valor de um número inteiro qualquer");
                n = int.Parse(Console.ReadLine());
                c++;
                if(n > 0)
                {
                    s = n + s;
                }
            }
            m = s / 10;
            Console.WriteLine("A media dos números é igual á: " + m);
            Console.ReadLine();
        }
    }
}
