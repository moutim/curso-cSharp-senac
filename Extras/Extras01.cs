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
    }
}