using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// programa donde se ingresan datos desde consola y después se pregunta si se quiere sumar o restar

namespace ConsoleApp_metodos_ejemplo001
{
    class Program
    {
        static void Main(string[] args)
        {
           // definicion de las variables
            Double A, B;
            Byte opcion;
            Double resultado;

            //proceso del programa
            Console.WriteLine("Hola!");
            Console.WriteLine("Ingresa dos numeros no mayores a 100");
            
            Console.WriteLine("Ingresa el valor de A");
                A = Convert.ToDouble(Console.ReadLine());// lee desde la consola el valor que se tecleo
                
            Console.WriteLine("ingresa el valor de B");
                B = Convert.ToDouble(Console.ReadLine());// lee desde la consola el valor que se tecleo

            Console.WriteLine("¿que te gustaria utilizar?");
            Console.WriteLine("ingresa 1 .... para sumar");
            Console.WriteLine("ingresa 2 .... para restar");

            opcion = Convert.ToByte(Console.ReadLine());
            
            // analisis de la decision

            if (opcion == 1) { // si se selecciona la opción 1 en tonces se sumaran los valores
                resultado = A + B;
                Console.WriteLine("oK, seleccionaste 1, la suma es:" + resultado);
            }
            else
            {
                resultado = A - B; // si se seleccion la opción 2 entonces calcula la resta
                Console.WriteLine("oK, seleccionaste 2, la suma es:" + resultado);
            }

            Console.WriteLine("... presiona cualquier tecla para salir");
            Console.ReadKey();
       

       
        }  
    }
}
