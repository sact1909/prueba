using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_app
{
    class Calculadora
    {
        

        private static void Main(string[] args)
        {
            Calculos calculo = new Calculos();
            var resultado = calculo.calcular(5,10);
            string cadena = "";
            cadena = resultado == 15 ? "Verdadero" : "Falso"; 
            Console.WriteLine("Que tipo es: " + cadena);
            
            int f = 0;
            do
            {
                int result = f * 5;
                Console.WriteLine("{0} x {1} = {2}", 5, f, result);
                f++;
            } while (f <= 12);

            Console.ReadLine();
        }
    }

    class Calculos {

        public int calcular(int numerouno, int numerodos)
        {
            var resultado = numerouno + numerodos;
            return resultado;
        }
    }
}
