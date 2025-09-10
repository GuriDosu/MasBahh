using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasBahh
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DateTime agora = DateTime.Now;
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());


            if (idade >= 6 && idade <= 12)
            {
                Console.WriteLine("seu nome é " + nome + " e você é uma criança");
            }
            if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("seu nome é " + nome + " e você é um adolescente");
            }
            if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("seu nome é " + nome + " e você é um adulto");
            }
            if (idade >= 60)
            {
                Console.WriteLine("seu nome é" + nome + "E voce é idoso");
            }

            Console.WriteLine("Agora digite sua cidade");

            string cidade = Console.ReadLine();

            Console.WriteLine("A cidade digitada foi " + cidade);

            Console.WriteLine("voce deseja reclamar:");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int resposta = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("voce não pode reclamar, pois é menor de idade");
                resposta = 2;
            }

            if (resposta == 1)
            {

                Console.WriteLine("qual seria sua reclamaçao");
                String reclamacao = Console.ReadLine();
                Console.WriteLine("sua reclamaçao foi: " + reclamacao);
                Console.WriteLine("sua reclamaçao foi registrada com sucesso " + nome + " em breve entraremos em contato com você para resolver sua reclamaçao");
                Console.WriteLine("Data e hora da reclamação: " + agora);

            }
            else if (resposta == 2)
            {
                Console.WriteLine("Obrigado por usar nosso sistema de reclamações");
                Console.WriteLine("Data e hora do uso do sistema: " + agora);
            }
            else
            {
                Console.WriteLine("opção inválida");


            }
        
        }
    }
}
