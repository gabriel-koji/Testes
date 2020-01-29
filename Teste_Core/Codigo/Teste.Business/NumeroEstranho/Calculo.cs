using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Business.NumeroEstranho
{
    public class Calculo
    {
        /// <summary>
        /// Método para calcular os divisores e dizer se são numeros estranhos
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public RetornoCalculo CalculoNumEstranho(int numero)
        {
            RetornoCalculo retorno = new RetornoCalculo();

            List<int> divisores = new List<int>();
            int fator = numero / 2;
            int total = 0;

            /// Separa e soma os números divisores
            for (int i = 1; i <= fator; i++)
            {
                if ((numero % i) == 0)
                {
                    divisores.Add(i);
                    total += i;
                }
            }

            retorno.Lista = divisores;
            retorno.Total = total;
            
            if (total > numero)
                retorno.NumeroEstranho = true;
            else
                retorno.NumeroEstranho = false;

            return retorno;

        }

    }
}
