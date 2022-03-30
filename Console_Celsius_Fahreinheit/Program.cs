using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Celsius_Fahreinheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo");
            Console.WriteLine("1 -> Converter Celsius(C°) para Fahreinheit(F°)");
            Console.WriteLine("2 -> Converter Fahreinheit(F°) para Celsius(C°)");

            Console.Write("Escolha a operação: ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


            if (opcao == 1)
            {
                Console.Write("Informe o grau em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine("O valor " + celsius + "C° em fahrenheit é: " + fahrenheit.ToString("f2") + "F°");

                Console.ReadKey();
            }

            if (opcao == 2)
            {
                Console.Write("Informe o grau em Fahreinhet: ");
                double fahreinhet = double.Parse(Console.ReadLine());

                double celsius = (fahreinhet - 32) / 1.8;

                Console.WriteLine("O valor " + fahreinhet + "F° em celsius é: " + celsius.ToString("f2") + "C°");

                Console.ReadKey();
            }



            
        }
    }
}
