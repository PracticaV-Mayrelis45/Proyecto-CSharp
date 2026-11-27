using System;

namespace ProyectoDecimales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ DECIMALES ---");
                Console.WriteLine("1. Redondear número al alza");
                Console.WriteLine("2. Eliminar los decimales del número");
                Console.WriteLine("3. Resolver ecuación de segundo grado (ax^2 + bx + c = 0)");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce un número decimal: ");
                        double numAlza = double.Parse(Console.ReadLine());
                        Console.WriteLine("Redondeado al alza: " + Math.Ceiling(numAlza));
                        break;
                    case 2:
                        Console.Write("Introduce un número decimal: ");
                        double numTrunc = double.Parse(Console.ReadLine());
                        Console.WriteLine("Sin decimales: " + Math.Truncate(numTrunc));
                        break;
                    case 3:
                        Console.Write("Coeficiente a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Coeficiente b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Coeficiente c: ");
                        double c = double.Parse(Console.ReadLine());
                        ResolverEcuacionSegundoGrado(a, b, c);
                        break;
                }
            } while (opcion != 0);
        }

        static void ResolverEcuacionSegundoGrado(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("El coeficiente 'a' no puede ser 0 en una ecuación de segundo grado.");
                return;
            }

            double discriminante = (b * b) - (4 * a * c);
            if (discriminante < 0)
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Solución única: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Dos soluciones: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
