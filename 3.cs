using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {/*Faça um algoritmo utilizando o comando while que mostra uma contagem regressiva na tela,
iniciando em 10 e terminando em 0. Mostrar uma mensagem “FIM!” após a contagem.*/
            Console.WriteLine("Contagem regresiva começano");
            int c = 10;
            while(c != -1)
            {
                Console.WriteLine(c);
                c--;
            }
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
