using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args) {
            double media = 5;

            //string resultado = (media >= 7) ? "Aprovado" 
            //                                : (media >= 5.1 && media < 7) ? "Recuperação"
            //                                                              :"Reprovado";
            //Console.WriteLine(resultado);

            //if (media >= 7)
            //    Console.WriteLine("Aprovado");
            //else if (media >= 5.1 && media < 7)
            //    Console.WriteLine("Recuperação");
            //else
            //    Console.WriteLine("Reprovado");

            //switch (media) {
            //    case double c1 when (c1 >= 7):
            //        Console.WriteLine("Aprovado");
            //        break;
            //    case double c2 when (c2 >= 5.1 && c2 <= 7):
            //        Console.WriteLine("Recuperação");
            //    break;
            //    case 5:
            //        Console.WriteLine("Reprovado");
            //        break;
            //    default:
            //        Console.WriteLine("Não indentificado");
            //        break;
            //}           
            Console.ReadKey();
        }
    }
}
