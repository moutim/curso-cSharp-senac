using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios_csharp.Extras
{
    public class Extras01
    {
        public static void EstadoAguaTemperatura() {
            Console.WriteLine("Digite uma temperatura em celsius para saber estado de físico da água: ");
            float temperatura = float.Parse(Console.ReadLine());

            string estado = "";

            if (temperatura < 0) {
                estado = "sólido";
            } else if (temperatura == 0) {
                estado = "ponto de fusão";
            } else if (temperatura > 0 && temperatura < 100) {
                estado = "liquído";
            } else if (temperatura == 100) {
                estado = "ponto de ebulição";
            } else {
                estado = "gasoso";
            }

            Console.WriteLine($"O estado da água é: {estado}");
        }

        public static void CategoriaIdade() {
            Console.WriteLine("Digite uma idade para saber qual categoria ela se enquadra: ");

            int idade = int.Parse(Console.ReadLine());

            string categoria = "";

            if (idade == 0 || idade < 5) {
                categoria = "bebê";
            } else if (idade >= 5 && idade <= 7) {
                categoria = "infantil A";
            } else if (idade >= 8 && idade <= 10) {
                categoria = "infantil B";
            } else if (idade >= 11 && idade <= 13) {
                categoria = "juvenil A";
            } else if (idade >= 14 && idade <= 17) {
                categoria = "juvenil B";
            } else {
                categoria = "adulto";
            }

            Console.WriteLine($"A idade que você digitou se enquadra na categoria: {categoria}");
        }

        public static void MaiorDeTres() {
            Console.WriteLine("Digite três números para saber qual o maior deles");

            List<int> numeros = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            Console.WriteLine($"O maior número é: {numeros.Max()}");
        }
    }
}