using System;
using System.Collections.Generic;

namespace FactorizacionPOO
{
    public class MostrarResultado
    {
        public void Imprimir(int numero, List<int> factores)
        {
            Console.Write(numero + " = ");

            for (int i = 0; i < factores.Count; i++)
            {
                Console.Write(factores[i]);

                if (i < factores.Count - 1)
                {
                    Console.Write(" x ");
                }
            }

            Console.WriteLine();
        }
    }
}