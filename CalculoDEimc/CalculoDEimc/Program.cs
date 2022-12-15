using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDEimc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculo de imc 
            //dividir peso pela altura ao quadrado em metros 
          

            Console.WriteLine("CALCULADORA DE IMC");
            Console.WriteLine("");

            Console.WriteLine("Digite quantos Kg voce possui atualmente : ");
            double peso = double.Parse(Console.ReadLine());
           
            Console.WriteLine("-----------------------------------");
           
            Console.WriteLine("Digite sua altura em metros : ");
            double altura = double.Parse(Console.ReadLine());

            // calculo do imc 
            double resultado = peso / (altura * altura);
            
            if (resultado < 18.5)
            {
                Console.WriteLine("\n IMC = Magreza" + " o seu imc é " +resultado );
            }

            else if (resultado >= 18.6 && resultado <= 24.9)
            {
                Console.WriteLine("\nIMC = Normal " + " o seu imc é " + resultado);
            }
            else if (resultado >25 && resultado <= 29.9) 
            {
                Console.WriteLine("\nIMC = Sobrepeso " + "o seu imc é " + resultado);
            }
            else if (resultado >=30 && resultado <= 39.9) 
            {
                Console.WriteLine("\nIMC = Obesidade " + " o seu imc é " + resultado);
            }
            else
            {
                Console.WriteLine("\n IMC = OBESIDADE GRAVE " + " o seu imc é " + resultado);   
            }
            // imc = menor que 18.5 - magreza , imc entre 18.5 e 24.9 normal 
            // imc = entre 25 a 29.9 sobrepeso , entre 30 e 39.9 obesidade
            // imc = maior que 40 obesidade grave 


            Console.ReadKey();
        }
    }
}
