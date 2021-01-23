using System;

namespace Capitulo_5
{
    class Cap_5
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine(".....: Menu :.....");
            Console.WriteLine("1. Ejercicio 4");
            Console.WriteLine("2. Ejercicio 5");
            Console.WriteLine("Cual es su opcion: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
           
            switch (i)
            {
                case 1:
                    int num = 0;


                    Console.WriteLine("Digite el Numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Resultado es:  {0}", Factorial(num));

                    break;

                case 2:

                    
                    break;

                
                default:
                    Console.WriteLine("Error: La opcion que tomo no existe!!");
                    break;

            }


        }          

            public static int Factorial(int num)
            {
                int num2 = 1;

                if (num == 0)
                {
                    Console.WriteLine("No hay Factorial");
                    return 0;
                }
                else
                {

                    for (int i = 1; i <= num; i++)
                    {
                        num2 = num2 * i;
                    }

                    return num2;

                }
                
                
            }
    }
}
