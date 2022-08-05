using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Sequêncial - TopDown
             * 
             * Passo 1
             * Passo 2
             * Passo 3
             * Passo 4
             * 
             */
            string repetir;
            string sair;
            do
            {

                //Passo 1 - Entrada de Dados
                Console.WriteLine("Qual o aluno?");
                string nome = Console.ReadLine();
                string resposta;
                //Passo 2 - Processamento
                if (nome.Equals("Regys"))
                {
                    resposta = "Nosso representante";

                }
                else
                {
                    resposta = "Chame representante";
                }
                //Passo 3 - Saída
                Console.WriteLine(resposta);

                //Passo 4 - Montar uma interação (repetição)-looping
                Console.WriteLine("Deseja sair? Y-N");
                repetir = Console.ReadLine().ToUpper();
               
                if(repetir != "N" && repetir!= "Y")
                {
                    Console.WriteLine("Comando inválido! Digite um comando existente!");
                }
               

                
            }while (!repetir.Equals("Y"));

            int[]notas = new int[4];
            notas[0] = 9;
            notas[1] = 21;
            notas[2] = 7;
            notas[3] = 15;
            Console.WriteLine("Mostre as notas do representante");
            double soma = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
                soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            Console.WriteLine($"soma:{soma}");
            Console.WriteLine($"média:{media}");
            Console.ReadKey();
        }
    }
}
