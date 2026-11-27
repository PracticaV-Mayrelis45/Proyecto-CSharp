using System;
using System.Text;

namespace ProyectoString
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ STRING ---");
                Console.WriteLine("1. Comprobar si es palíndromo");
                Console.WriteLine("2. Escribir en mayúsculas y en minúsculas");
                Console.WriteLine("3. Contar ocurrencias de una letra");
                Console.WriteLine("4. Repetir dos strings N veces");
                Console.WriteLine("5. Duplicar cada letra de un string");
                Console.WriteLine("6. Borrar apariciones de un segundo string en el primero");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce un texto: ");
                        string pal = Console.ReadLine();
                        Console.WriteLine(EsPalindromo(pal) ? "Es palíndromo" : "No es palíndromo");
                        break;
                    case 2:
                        Console.Write("Introduce un nombre o texto: ");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Mayúsculas: " + nom.ToUpper());
                        Console.WriteLine("Minúsculas: " + nom.ToLower());
                        break;
                    case 3:
                        Console.Write("Introduce un texto: ");
                        string txt = Console.ReadLine();
                        Console.Write("Introduce la letra a buscar: ");
                        char letra = Console.ReadLine()[0];
                        Console.WriteLine("Ocurrencias: " + ContarLetra(txt, letra));
                        break;
                    case 4:
                        Console.Write("Primer string: ");
                        string s1 = Console.ReadLine();
                        Console.Write("Segundo string: ");
                        string s2 = Console.ReadLine();
                        Console.Write("Número de repeticiones: ");
                        int veces = int.Parse(Console.ReadLine());
                        Console.WriteLine(RepetirStrings(s1, s2, veces));
                        break;
                    case 5:
                        Console.Write("Introduce un texto: ");
                        string dup = Console.ReadLine();
                        Console.WriteLine("Resultado: " + DuplicarCaracteres(dup));
                        break;
                    case 6:
                        Console.Write("Texto principal: ");
                        string baseStr = Console.ReadLine();
                        Console.Write("Texto a borrar: ");
                        string borrar = Console.ReadLine();
                        Console.WriteLine("Resultado: " + baseStr.Replace(borrar, ""));
                        break;
                }
            } while (opcion != 0);
        }

        static bool EsPalindromo(string texto)
        {
            string limpio = texto.Replace(" ", "").ToLower();
            char[] arr = limpio.ToCharArray();
            Array.Reverse(arr);
            return limpio == new string(arr);
        }

        static int ContarLetra(string texto, char letra)
        {
            int contador = 0;
            foreach (char c in texto)
                if (char.ToLower(c) == char.ToLower(letra)) contador++;
            return contador;
        }

        static string RepetirStrings(string s1, string s2, int veces)
        {
            string[] partes = new string[veces];
            for (int i = 0; i < veces; i++) partes[i] = $"{s1} {s2}";
            return string.Join(" ", partes);
        }

        static string DuplicarCaracteres(string texto)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in texto)
            {
                sb.Append(c);
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
