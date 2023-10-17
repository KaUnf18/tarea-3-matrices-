using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace tarea_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aquí puedes ingresar la lógica para crear y llenar tu matriz

            // Ejemplo:
            int[,] miMatriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int resultado = SumarEsquinas(miMatriz);

            Console.WriteLine("La suma de las esquinas de la matriz es: " + resultado);

            Console.Read();
        }

        static int SumarEsquinas(int[,] matriz)
        {
            int suma = 0;

            if (matriz.Length == 0)
            {
                return suma;
            }

            suma += matriz[0, 0];
            suma += matriz[0, matriz.GetLength(1) - 1];
            suma += matriz[matriz.GetLength(0) - 1, 0];
            suma += matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1];

            return suma;
        }
    }
}
