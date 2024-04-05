using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {/*Escreva um programa que declare um inteiro, inicialize-o com 0, e incremente-o de 1000 em
1000, imprimindo seu valor na tela, até que seu valor seja 100000 (cem mil).*/
            int i = 0;
            while(i != 101000)
            {
                Console.WriteLine(i);
                i = i + 1000;
            }
            Console.ReadLine();
        }
    }
}
