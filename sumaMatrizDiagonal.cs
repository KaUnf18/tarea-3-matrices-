using System;

namespace suma_matriz_diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo:
            int[,] miMatriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int sumaDiagonalPrincipal = SumarDiagonalPrincipal(miMatriz);
            int sumaDiagonalSecundaria = SumarDiagonalSecundaria(miMatriz);

            Console.WriteLine("La suma de la diagonal principal es: " + sumaDiagonalPrincipal);
            Console.WriteLine("La suma de la diagonal secundaria es: " + sumaDiagonalSecundaria);

            Console.Read();
        }

        static int SumarDiagonalPrincipal(int[,] matriz)
        {
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Sumar solo si estamos en la diagonal principal (i == j)
                    if (i == j)
                    {
                        suma += matriz[i, j];
                    }
                }
            }

            return suma;
        }

        static int SumarDiagonalSecundaria(int[,] matriz)
        {
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Sumar solo si estamos en la diagonal secundaria
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        suma += matriz[i, j];
                    }
                }
            }

            return suma;
        }
    }
}
