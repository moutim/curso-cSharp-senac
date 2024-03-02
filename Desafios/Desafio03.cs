using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios_csharp.Desafios
{
    public class Desafio03
    {
        public static void Fibonacci()
        {
            int primeiroNumero = 0;
            int segundoNumero = 1;

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(primeiroNumero);
                segundoNumero = primeiroNumero + segundoNumero;
                primeiroNumero = segundoNumero - primeiroNumero;
            }
        }
    }
}