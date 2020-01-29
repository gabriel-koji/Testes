using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Base.Domain;
using Teste.Base.Function;

namespace Altran.Business.CEP
{
    public class GerenciamentoCep
    {

        public void GravaCep(_Cep cep)
        {
            _CepData data = new _CepData();
            try
            {
                data.Insert(cep);
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
    }
}
