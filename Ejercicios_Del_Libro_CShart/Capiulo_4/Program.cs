using System;

namespace Capiulo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine(".....: Menu :.....");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("Cual es su opcion: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (i)
            {
                case 1:

                    int num1 = 0, num2 = 1;

                    Console.WriteLine("¿Cual tabla es la que desea?");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Tabla del {0}", num1);
                    Console.WriteLine();

                    for (int j = 1; j <= 10; j++)
                    {
                        num2 = j * num1;
                        Console.WriteLine("{0} * {1} = {2}", j, num1, num2);
                    }

                    break;

                case 2:

                    int num = 0, pot = 0;
                    int num3 = 1;
                    Console.WriteLine("Digite el Numero: ");

                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite la Potencia: ");

                    pot = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    for (int j1 = 0; j1 != pot; j1++)
                    {
                        num3 = num3 * num;
                    }

                    Console.WriteLine("El resultado de {0} ^ {1} = {2}", num, pot, num3);

                    break;

                case 3:
                    int pesonas = 0, max = 0, min = 0, edad = 0;
                    int promedio = 0;
                    Console.WriteLine("¿ Cual es la cantidad de personas ? ");
                    pesonas = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Dijite  la edad de la persona {0}", 1);
                    edad = Convert.ToInt32(Console.ReadLine());
                    promedio += edad;

                    min = max = edad;
                    int j2;
                    for (j2 = 1; j2 < pesonas; j2++)
                    {
                        Console.WriteLine("¿Cual es la edad de la persona {0}?", j2 + 1);
                        edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= max)
                            max = edad;


                        else if (edad <= min)
                            min = edad;

                        promedio += edad;
                    }

                    promedio /= j2;
                    Console.WriteLine("El promedio es: {0}", promedio);
                    Console.WriteLine("La edad mayor es: {0}", max);
                    Console.WriteLine("La edad menor es: {0}", min);
                    break;

                default:
                    Console.WriteLine("Error: La opcion que tomo no existe!!");
                    break;

            }
        }
    }
}
