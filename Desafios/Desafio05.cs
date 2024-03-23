using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafios_csharp.Desafios
{
    class Desafio05 {
        public static string Desafio05() {
            int[,] matriz = new int[11, 11];
            int valor = 0;
        
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                matriz[i, j] = valor;
                valor++;
                }
            }
        
            Console.WriteLine("Digite a linha que você deseja somar ou fazer a média: ");
            int linha = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Digite 's' para somar ou 'm' para fazer a média: ");
            char opcao = char.Parse(Console.ReadLine());
        
            int soma = 0;
        
            for (int i = 0; i < matriz.GetLength(1); i++) {
                soma += matriz[linha, i];
            }
        
            if (opcao == 's') {
                string message = $"A soma da linha {linha} é: {soma}";
                return message;
            } else {
                string message = $"A média da linha {linha} é: {soma / matriz.GetLength(1)}";
                return message;
            }
        }
    }
}

