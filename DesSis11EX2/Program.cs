using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis11EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[5];
            Double[] altura = new double[5];
            Double[] peso = new double[5];
            Double[] imc = new double[5];
            int obesos = 0;
            int sauda = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o seu nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu altura: ");
                altura[i] = double.Parse(Console.ReadLine());



                imc[i] = peso[i] / Math.Pow(altura[i], 2);

                if (imc[i] < 18.5)
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ".Está abaixo do peso.");
                    sauda++;
                }
                else if (imc[i] < 24.9)
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ".é o peso ideal. PARABÉNS!");
                    sauda++;
                }
                else if (imc[i] < 29.9)
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ".Você está levemente acima do peso.");
                    obesos++;
                }

                else if (imc[i] < 34.9)
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ". Obesidade Grau I");
                    obesos++;
                }
                else if (imc[i] < 39.9)
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ".Obesidade Grau II  (Severa)");
                    obesos++;
                }
                else  
                {
                    Console.WriteLine("O seu IMC é de: " + imc[i] + ".Obesidade Grau III  (Mórbida)");
                    obesos++;
                }

            }
            double PorObesos = 0;
            double PorSauda = 0;
            PorObesos = 100*(obesos / 5);
            PorSauda = 100 * (sauda / 5);
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("O nome " + nome[j] +"Está com um IMC de: " + imc[j] );

            }
            Console.WriteLine("Há " + obesos + " pessoas obesas e " + sauda + " pessoas saudáveis.");
            Console.WriteLine("Portanto a quantidade de pessoas acima do peso é: " + PorObesos + "%");
            Console.WriteLine("Portanto a quantidade de pessoas acima do peso é: " + PorSauda + "%");

            Console.ReadKey();
        }
    }
}
