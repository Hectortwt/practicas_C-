# practicas_C-
en este repositorio voy a colocar pruebas en C#



# programa001


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BucleFor_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyVariable;
            for (MyVariable = 0; MyVariable < 10; MyVariable++)
            {
                System.Console.WriteLine(MyVariable);
                Console.ReadKey();
            }

            /*int LaVariable = 0;
            for (; LaVariable < 10; LaVariable++)
            {
                System.Console.WriteLine(LaVariable);
                Console.ReadKey();
            }

            int LaInvariable = 0;
            for (LaInvariable = 0; ; LaInvariable++)
            {
                System.Console.WriteLine(LaInvariable);
                Console.ReadKey();
            }*/



            int LAvariable1;
            int LAvariable2;

            for (LAvariable1 = 0, LAvariable2 = 0; LAvariable1 < 10; LAvariable1++, LAvariable2++)
            {
                System.Console.WriteLine(LAvariable1);
                System.Console.WriteLine(LAvariable2);

                Console.ReadKey();
            }
        }
    }
}
