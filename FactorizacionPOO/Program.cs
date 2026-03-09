using System;
using System.Collections.Generic;

namespace FactorizacionPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "s";

            while (opcion.ToLower() == "s")
            {
                Console.Write("Ingrese el número a descomponer: ");

                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.Write("Ingrese un número válido: ");
                }

                Numero numero = new Numero(valor);

                Factorizador factorizador = new Factorizador();
                List<int> factores = factorizador.Descomponer(numero.Valor);

                MostrarResultado mostrar = new MostrarResultado();
                mostrar.Imprimir(numero.Valor, factores);

                Console.Write("\n¿Desea probar con otro número? (s/n): ");
                opcion = Console.ReadLine() ?? "";

                Console.WriteLine();
            }

            Console.WriteLine("Programa finalizado.");
        }
    }
}