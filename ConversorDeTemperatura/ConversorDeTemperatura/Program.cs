using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region captura de informação
            // captura de informação do usuario

            double c,f,k;
            Console.WriteLine("###CONVERSOR DE TEMPERATURAS###");
            Console.Write("insira a temperatura em CELSIUS : ");
            c = double.Parse ( Console.ReadLine());
            Console.WriteLine("--------------------------------");
            #endregion

            #region METODO DE CALCULOS PARA CONVERTER

            //calculo para conversão de celsius para Farenheit
            f = ((c * 9) + 160) / 5;
            //para Kelvin
            k = c + 273.15;


            #endregion
            
            
            Console.WriteLine(c + " de temperatura SELCIUS convertida em escala KELVIN = " + k +" graus Kelvin");
        
            Console.WriteLine(c + " de temperatura SELCIUS convertira em escala FARENHEIT = " + f + " graus Farenheit");

            Console.WriteLine("*********************************");
            Console.ReadKey();
        }
    }
}
