using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios_csharp.Desafios
{
    public class Desafio01
    {
        public static void CalcularCombustivel()
        {
            Console.WriteLine("Digite o tempo gasto na viagem:");
            int tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média durante a viagem:");
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;

            double litros = distancia / 12.0;
            litros = Math.Round(litros, 3);

            Console.WriteLine($"Para uma viagem de {tempo} horas a uma velocidade média de {velocidade}km/h, a distância percorrida foi de {distancia}km e foram gastos {litros} litros de combustível.");
        }
    }
}