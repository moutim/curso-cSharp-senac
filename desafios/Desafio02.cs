using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios_csharp.Desafios
{
    public class Desafio02
    {
        public static void RealizarVenda() {
            Console.WriteLine("1 - Cachorro Quente - R$ 4,00");
            Console.WriteLine("2 - X-Salada - R$ 4,50");
            Console.WriteLine("3 - X-Bacon - R$ 5,00");
            Console.WriteLine("4 - Torrada Simples - R$ 2,00");
            Console.WriteLine("5 - Refrigerante - R$ 1,50");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite o número de um produto: ");
            int opcao = int.Parse(Console.ReadLine());
            int qtd = 0;
            double total = 0;

            if (opcao == 1) {
                Console.WriteLine("Quantas unidades de Cachorro Quente você quer comprar?");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 4.00;
                Console.WriteLine($"Você comprou {qtd} Cachorro Quente e o total foi de: R$ {total}");
            } else if (opcao == 2) {
                Console.WriteLine("Quantas unidades de X-Salada você quer comprar?");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 4.50;
                Console.WriteLine($"Você comprou {qtd} X-Salada e o total foi de: R$ {total}");
            } else if (opcao == 3) {
                Console.WriteLine("Quantas unidades de X-Bacon você quer comprar?");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 5.00;
                Console.WriteLine($"Você comprou {qtd} X-Bacon e o total foi de: R$ {total}");
            } else if (opcao == 4) {
                Console.WriteLine("Quantas unidades de Torrada Simples você quer comprar?");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 2.00;
                Console.WriteLine($"Você comprou {qtd} Torrada Simples e o total foi de: R$ {total}");
            } else if (opcao == 5) {
                Console.WriteLine("Quantas unidades de Refrigerante você quer comprar?");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 1.50;
                Console.WriteLine($"Você comprou {qtd} Refrigerante e o total foi de: R$ {total}");
            } else {
                Console.WriteLine("Digite um código de produto válido!");
            }
        }
    }
}