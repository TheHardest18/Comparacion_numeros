using System;

namespace Comparacion_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Pedir dos números al usuario por teclado y decir que número es el mayor.
            Mayor();
        }
        public static void Mayor() 
        {
            string repetir = "";
            do
            {
                
                int n1, n2;
                Console.WriteLine("Ingrese Primer numero");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese segundo numero");
                n2 = int.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.WriteLine("El primer numero es mayor");
                    Console.WriteLine("Desea Continuar s/n");
                    repetir = Console.ReadLine();
                    Console.Clear();
                }
                else if (n2 > n1)
                {
                    Console.WriteLine("Ël segundo numero es mayor");
                    Console.WriteLine("Desea Continuar s/n");
                    repetir = Console.ReadLine();
                    Console.Clear();
                }
                else 
                { 
                    Console.WriteLine("Son iguales");
                    Console.WriteLine("Desea Continuar s/n");
                    repetir = Console.ReadLine();
                    Console.Clear();
                }

            } while (repetir == "s" || repetir == "S");
        }
    }
}
