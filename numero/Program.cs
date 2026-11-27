using System;

namespace ProyectoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ NÚMERO ---");
                Console.WriteLine("1. Calcular si un número es primo");
                Console.WriteLine("2. Calcular el factorial");
                Console.WriteLine("3. Convertir segundos a horas, minutos y segundos");
                Console.WriteLine("4. Mostrar los primeros 15 números de la serie de Pell");
                Console.WriteLine("5. Comprobar si es un número de Armstrong");
                Console.WriteLine("6. Comprobar si tiene todos sus dígitos diferentes");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce un número entero: ");
                        int nPrimo = int.Parse(Console.ReadLine());
                        Console.WriteLine(EsPrimo(nPrimo) ? "Es primo" : "No es primo");
                        break;
                    case 2:
                        Console.Write("Introduce un número entero: ");
                        int nFact = int.Parse(Console.ReadLine());
                        Console.WriteLine("Factorial: " + CalcularFactorial(nFact));
                        break;
                    case 3:
                        Console.Write("Introduce el total de segundos: ");
                        int seg = int.Parse(Console.ReadLine());
                        ConvertirSegundos(seg);
                        break;
                    case 4:
                        SeriePell15();
                        break;
                    case 5:
                        Console.Write("Introduce un número entero: ");
                        int nArm = int.Parse(Console.ReadLine());
                        Console.WriteLine(EsArmstrong(nArm) ? "Es número de Armstrong" : "No es número de Armstrong");
                        break;
                    case 6:
                        Console.Write("Introduce un número entero: ");
                        int nDig = int.Parse(Console.ReadLine());
                        Console.WriteLine(DigitosDiferentes(nDig) ? "Todos sus dígitos son diferentes" : "Tiene dígitos repetidos");
                        break;
                }
            } while (opcion != 0);
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        static long CalcularFactorial(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++) res *= i;
            return res;
        }

        static void ConvertirSegundos(int totalSegundos)
        {
            int horas = totalSegundos / 3600;
            int minutos = (totalSegundos % 3600) / 60;
            int segundos = totalSegundos % 60;
            Console.WriteLine($"{totalSegundos} segundos son {horas} hora(s), {minutos} min, y {segundos} segundos.");
        }

        static void SeriePell15()
        {
            long[] pell = new long[15];
            pell[0] = 0;
            pell[1] = 1;
            for (int i = 2; i < 15; i++)
                pell[i] = 2 * pell[i - 1] + pell[i - 2];
            Console.WriteLine("Primeros 15 números de Pell: " + string.Join(", ", pell));
        }

        static bool EsArmstrong(int n)
        {
            string texto = n.ToString();
            int potencia = texto.Length;
            int suma = 0;
            foreach (char c in texto)
                suma += (int)Math.Pow(int.Parse(c.ToString()), potencia);
            return suma == n;
        }

        static bool DigitosDiferentes(int n)
        {
            string texto = Math.Abs(n).ToString();
            for (int i = 0; i < texto.Length; i++)
                for (int j = i + 1; j < texto.Length; j++)
                    if (texto[i] == texto[j]) return false;
            return true;
        }
    }
}
