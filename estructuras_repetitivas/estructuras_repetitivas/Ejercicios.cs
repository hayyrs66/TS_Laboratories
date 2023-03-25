using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_repetitivas
{
    public class Ejercicios
    {
        public static void Ejercicio1()
        {
            int numero;

            do
            {
                Console.Write("Ingrese un número positivo (99 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0 && numero != 0)
                {
                    Console.WriteLine("El número ingresado es par: " + numero);
                }              

            } while (numero != 99);

            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }

        public static void Ejercicio2()
        {
            Console.Write("Ingrese el número de filas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static void Ejercicio3()
        {
            int suma = 0;

            Console.WriteLine("Números divisibles entre 9 entre 100 y 200:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                    suma += i;
                }
            }

            Console.WriteLine("\n\nLa suma de los números divisibles entre 9 es: " + suma);
            Console.ReadKey();
        }
        public static void Ejercicio4()
        {
            Console.Write("Ingrese un número entero positivo del 1 al 10: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 10)
            {
                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine("\nTabla de multiplicar del número " + i + ":");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + (i * j));
                    }
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido.");
            }

            Console.ReadKey();
        }
    }
 }        

