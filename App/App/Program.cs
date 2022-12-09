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
            void Questao1()
            {
                Console.WriteLine("Digite o valor do tanque: ");
                float volume = float.Parse(Console.ReadLine());
                string condicao = (volume > 10) ? "TANQUE OK" : "TANQUE QUASE VAZIO";
                Console.WriteLine(condicao);
            }
            void Questao2()
            {
                Console.WriteLine("Digite o valor de A: ");
                int golsA = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");
                int golsB = int.Parse(Console.ReadLine());
            
                string resultado = (golsA > golsB) ? "TIME A GANHANDO" : (golsB>golsA)? "TIME B GANHANDO" : ((golsA == 0) && (golsB== 0))? "SEM GOLS ATE O MOMENTO" : "EMPATE COM GOLS";
                Console.WriteLine(resultado);
                
            }
            void Questao3()
            {
                Console.WriteLine("Digite o valor do ano: ");
                int ano = int.Parse(Console.ReadLine());

                int valor = 1986 - ano;
                string resultado = (valor % 76 == 0) ? "VAI PASSAR" : "NÃO VAI PASSAR";
                Console.WriteLine(resultado);
            }
            void Questao4()
            {

            }
            void Questao5()
            {
                Console.WriteLine("Digite a velocidade: ");
                float velocidade = float.Parse(Console.ReadLine());

                Console.WriteLine("Ele está atacando(true/false): ");
                bool atacando = bool.Parse(Console.ReadLine());

                Console.WriteLine("Ele está pulando(true/false): ");
                bool pulando = bool.Parse(Console.ReadLine());

                string resultado = (atacando == true) ? "atacando" : ((pulando == false) && (velocidade == 0)) ? "PARADO" :
                    ((pulando == false) && (velocidade <= 30)) ? "ANDANDO" : ((pulando == false)
                    && (velocidade > 30)) ? "Correndo" : (pulando == true) ? "PULANDO": "input Format";
                
                Console.WriteLine(resultado); //avisar o professor que tem erro no enunciado
            }
            //double media = 5;

            //string resultado = (media >= 7) ? "Aprovado" : "Reprovado";
            //Console.WriteLine(resultado);

            //if (media >= 7)
            //    Console.WriteLine("Aprovado");
            //else if (media >= 5.1 && media < 7)
            //    Console.WriteLine("Recuperação");
            //else
            //    Console.WriteLine("Reprovado");

            //switch (media) {
            //    case 8:
            //        Console.WriteLine("Aprovado");
            //        break;
            //    case 5:
            //        Console.WriteLine("Reprovado");
            //        break;
            //    default: 
            //        Console.WriteLine("Não indentificado");
            //        break;
            //}

            Questao1();
            Questao2();
            Questao3();
            Questao4();
            Questao5();

            Console.ReadKey();
        }
    }
}
