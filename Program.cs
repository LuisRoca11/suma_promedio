using System;

namespace suma_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea cuatro valores num�ricos e informar su suma y promedio.
            Console.WriteLine("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero 4: ");
            int num4 = int.Parse(Console.ReadLine());

            double suma = num1 + num2 + num3 + num4;
            double promedio = suma / 4;

            Console.WriteLine("============================");
            Console.WriteLine($"La suma de los 4 numeros es: {suma}");
            Console.WriteLine("============================");
            Console.WriteLine($"El promedio de los 4 numero es: {promedio}");
            Console.ReadKey();
        }
    }
}