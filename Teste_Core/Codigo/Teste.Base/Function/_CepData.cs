using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Base.Domain;

namespace Teste.Base.Function
{
    public class _CepData
    {
        public _Cep Get(int IdAnexo)
        {
            using (Database db = new NPoco.Database("Teste"))
            {
                return db.SingleOrDefaultById<_Cep>(IdAnexo);
            }
        }

        public List<_Cep> FetchAll()
        {
            using (Database db = new NPoco.Database("Teste"))
            {
                return db.Fetch<_Cep>();
            }
        }


        public _Cep Insert(_Cep oAnexo)
        {
            using (Database db = new NPoco.Database("Teste"))
            {
                db.Insert<_Cep>(oAnexo);
                return oAnexo;
            }
        }

        public _Cep Update(_Cep oAnexo)
        {
            using (Database db = new NPoco.Database("Teste"))
            {
                db.Update(oAnexo);
                return oAnexo;
            }
        }

        public void Delete(_Cep oAnexo)
        {
            using (Database db = new NPoco.Database("Teste"))
            {
                db.Delete<_Cep>(oAnexo);
            }
        }

    }
}
