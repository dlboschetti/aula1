using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o PRIMEIRO número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o SEGUNDO número:");

            double numero2 = Convert.ToDouble(Console.ReadLine());

            string operacao = "";
            double resultado = 0;

            while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {
                Console.WriteLine("Digite o OPERADOR (+, , * OU /:");
                operacao = Console.ReadLine();



                switch (operacao)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                    default:
                        Console.WriteLine("Vc não digitou a operação correta!");
                        break;
                }

            }


            Console.WriteLine($"O resultado da operação é: {resultado}");

            //Console.WriteLine("Digite o seu nome:");
            //string nome = Console.ReadLine();

            //Console.WriteLine($"Bem vindo, {nome}.");

            //if (nome == "Diego")
            //    Console.WriteLine("Este é o meu nome!");
            //else
            //    Console.WriteLine("Este NÃO é meu nome!");

            //Console.WriteLine("Digite as sua idade:");
            //int idade = Convert.ToInt32(Console.ReadLine());

            //while (idade > 0)
            //{
            //    Console.WriteLine(idade);
            //    idade--;
            //}

            //for (int i = idade; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] nomes = new string[5];
            //nomes[0] = "Paulo";
            //nomes[1] = "Pedro";
            //nomes[2] = "Diego";
            //nomes[3] = "Camila";
            //nomes[4] = "Danilo";

            //Console.WriteLine("Alunos do primeiro sabado de aula:");

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    Console.WriteLine($"- {nomes[i]}");
            //}

        }
    }
}
