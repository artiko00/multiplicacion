using System;

namespace MultiPlicacion
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
           {
               Console.WriteLine("\nBienvenido");
               Console.WriteLine("==================");
               Console.WriteLine("a continuacion comenzaran los ejercicios");
               Console.WriteLine("cada 20 segundos cambiaran");
               Console.WriteLine("sera multiplicaciones de 2 digitos");
               Console.WriteLine("Exito!");
               Console.ReadKey();
               int buenas = 0;
               int malas = 0;
               int exito = 0;
               int respuesta = 0;
               Random rnd1 = new Random();
               Random rnd2 = new Random();
               for (int i = 0; i < 10;)
               {
                    Console.Clear();
                    int a = rnd1.Next(10, 99);
                    int b = rnd2.Next(10, 99);
                    exito = a * b;
                    Console.WriteLine($"Cuanto es {a} X {b}");
                    respuesta = int.Parse(Console.ReadLine());
                    if (respuesta == exito)
                    {
                        Console.Clear();
                        Console.WriteLine("Felicidades");
                        buenas++;
                        i++;
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }else
                    {
                        Console.Clear();
                        malas++;
                        Console.WriteLine("Cuek");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
               }
               Console.Clear();
                Console.WriteLine("Tu respuestas fueron");
                Console.WriteLine("===================");
                Console.WriteLine($"las buenas fueron {buenas}");
                Console.WriteLine($"las malas fueron {malas}");
                Console.ReadKey();
                break;
           }
        }
    }
}
