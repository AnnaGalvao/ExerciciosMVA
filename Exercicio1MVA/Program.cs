using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1MVA
{
    class Program
    {
        static void Main(string[] args)
        {
            //soma de numeros naturais de 1 a 10

            //int soma = 0;
            //int numero = 0;
            //const int n = 10;
            //while (numero < n)
            // {
            //    numero = numero + 1;
            //    soma = soma + numero;
            // }
            //  Console.WriteLine("A soma é: " + numero);
            // Console.ReadKey();


            /* CALCULO DE MEDIA
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int media = 0;

            Console.WriteLine("Calculo de média");

            Console.WriteLine("Insira o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o terceiro numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média dos 3 numeros é: " + media);
            Console.ReadKey();
            */

            // VERIFICANDO NUMERO PRIMO
            //Números primos são os números naturais que têm apenas dois divisores diferentes: o 1 e ele mesmo.

            int n1 = 0;
            int cont = 0;

            Console.WriteLine("VERIFICAÇÃO DE NUMEROS PRIMOS");

            Console.Write("Insira um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i > 0; i--) //diminuindo o valor de i
            {
                if (n1 % i == 0) //n1 dividido por i é igual a zero? % pega o resto da divisão
                {
                    cont++;
                }
            }
            if (cont == 2) //se cont for igual a 2 a divisao so foi feita duas vezes
            {
                Console.WriteLine("O numero " + n1 + " é um numero primo");
            }
            else
            {
                Console.WriteLine("O numero " + n1 + " é não um numero primo");
            }
            Console.ReadKey();
        }


    }
}

