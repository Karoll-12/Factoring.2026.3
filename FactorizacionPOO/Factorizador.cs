using System.Collections.Generic;

namespace FactorizacionPOO
{
    public class Factorizador
    {
        public List<int> Descomponer(int numero)
        {
            List<int> factores = new List<int>();

            for (int i = 2; i <= numero; i++)
            {
                while (numero % i == 0)
                {
                    factores.Add(i);
                    numero /= i;
                }
            }

            return factores;
        }
    }
}