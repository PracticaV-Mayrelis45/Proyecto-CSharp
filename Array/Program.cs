using System;

namespace ProyectoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos elementos tendrá el array?: ");
            int tam = int.Parse(Console.ReadLine());
            double[] datos = new double[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Introduce el elemento {i + 1}: ");
                datos[i] = double.Parse(Console.ReadLine());
            }

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ARRAY ---");
                Console.WriteLine("1. Calcular máximo");
                Console.WriteLine("2. Calcular mínimo");
                Console.WriteLine("3. Calcular la mediana");
                Console.WriteLine("4. Calcular la media");
                Console.WriteLine("5. Ordenar array de menor a mayor");
                Console.WriteLine("6. Calcular desviación típica");
                Console.WriteLine("7. Binarizar array en base a un número n");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Máximo: " + CalcularMaximo(datos));
                        break;
                    case 2:
                        Console.WriteLine("Mínimo: " + CalcularMinimo(datos));
                        break;
                    case 3:
                        Console.WriteLine("Mediana: " + CalcularMediana(datos));
                        break;
                    case 4:
                        Console.WriteLine("Media: " + CalcularMedia(datos));
                        break;
                    case 5:
                        double[] ordenado = OrdenarArray(datos);
                        Console.WriteLine("Array ordenado: " + string.Join(", ", ordenado));
                        break;
                    case 6:
                        Console.WriteLine("Desviación típica: " + CalcularDesviacionTipica(datos));
                        break;
                    case 7:
                        Console.Write("Introduce el número umbral n: ");
                        double n = double.Parse(Console.ReadLine());
                        int[] binario = BinarizarArray(datos, n);
                        Console.WriteLine("Array binarizado: " + string.Join(", ", binario));
                        break;
                }
            } while (opcion != 0);
        }

        static double CalcularMaximo(double[] arr)
        {
            double max = arr[0];
            foreach (double num in arr) if (num > max) max = num;
            return max;
        }

        static double CalcularMinimo(double[] arr)
        {
            double min = arr[0];
            foreach (double num in arr) if (num < min) min = num;
            return min;
        }

        static double[] OrdenarArray(double[] arr)
        {
            double[] copia = (double[])arr.Clone();
            Array.Sort(copia);
            return copia;
        }

        static double CalcularMediana(double[] arr)
        {
            double[] ordenado = OrdenarArray(arr);
            int medio = ordenado.Length / 2;
            if (ordenado.Length % 2 == 0)
                return (ordenado[medio - 1] + ordenado[medio]) / 2.0;
            return ordenado[medio];
        }

        static double CalcularMedia(double[] arr)
        {
            double suma = 0;
            foreach (double num in arr) suma += num;
            return suma / arr.Length;
        }

        static double CalcularDesviacionTipica(double[] arr)
        {
            double media = CalcularMedia(arr);
            double sumaCuadrados = 0;
            foreach (double num in arr) sumaCuadrados += Math.Pow(num - media, 2);
            return Math.Sqrt(sumaCuadrados / arr.Length);
        }

        static int[] BinarizarArray(double[] arr, double n)
        {
            int[] resultado = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                resultado[i] = arr[i] < n ? 0 : 1;
            return resultado;
        }
    }
}
