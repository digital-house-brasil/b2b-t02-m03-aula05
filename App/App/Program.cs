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
            void NivelDoTanque() {
                Console.WriteLine("Digite o nível do tanque");
                int nivel = int.Parse(Console.ReadLine());

                string resultaddo = nivel < 10 ? "TANQUE QUASE VAZIO" : "TANQUE CHEIO";

                Console.WriteLine(resultaddo);

                Console.ReadKey();
            }

            void ResultadoDoJogo() {
                Console.WriteLine("Digite os gols do time A");
                int golsTimeA = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite os gols do time B");
                int golsTimeB = int.Parse(Console.ReadLine());

                if (golsTimeA == 0 && golsTimeB == 0) {
                    Console.WriteLine("SEM GOLS ATE O MOMENTO");
                } else if (golsTimeA == golsTimeB) {
                    Console.WriteLine("EMPATE COM GOLS");
                } else if (golsTimeA > golsTimeB) {
                    Console.WriteLine("TIME A GANHANDO");
                } else if (golsTimeA < golsTimeB) {
                    Console.WriteLine("TIME B GANHANDO");
                } 

                Console.ReadKey();
            }

            void ComentaHarley() {
                Console.WriteLine("Digite o ano para análise");
                int ano = int.Parse(Console.ReadLine());

                bool analisar(int a) {
                    if (a == 2062) {
                        return true;
                    } else if (a < 2062) {
                        return false;
                    } else {
                        return analisar(a - 76);
                    }
                }

                if (ano < 1986 || (ano >= 1986 && ano <= 2062)) {
                    Console.WriteLine("NAO VAI PASSAR");
                } else {
                    bool resultado = analisar(ano);
                    if (resultado)
                        Console.WriteLine("VAI PASSAR");
                    else
                        Console.WriteLine("NÃO VAI PASSAR");
                }
                Console.ReadKey();
            }

            void DhSChools() {
                Console.WriteLine("Digite a 1ª nota");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 2ª nota");
                double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 3ª nota");
                double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 4ª nota");
                double nota4 = double.Parse(Console.ReadLine());

                double media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (media < 5)
                    Console.WriteLine("Reprovado");
                else if (media > 5 && media < 7) {
                    Console.WriteLine("Recuperação");
                } else {
                    Console.WriteLine("Aprovado");
                }

                Console.ReadKey();
            }

            void ProgramandoAnimacoes() {
                Console.WriteLine("Digite a velocidade");
                int velocidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Está atacando? (true ou false)");
                bool atacando = bool.Parse(Console.ReadLine());

                Console.WriteLine("Está pulando? (true ou false)");
                bool pulando = bool.Parse(Console.ReadLine());

                if (atacando)
                    Console.WriteLine("ATACANDO");
                else if (pulando) 
                    Console.WriteLine("PULANDO");
                else if (!pulando && velocidade == 0)
                    Console.WriteLine("PARADO");
                else if (!pulando && velocidade == 30)
                    Console.WriteLine("ANDANDO");
                else if (!pulando && velocidade > 30)
                    Console.WriteLine("CORRENDO");             
                Console.ReadKey();
            }
        }
    }
}
