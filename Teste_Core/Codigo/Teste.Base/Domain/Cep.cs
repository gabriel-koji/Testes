using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Base.Domain
{
    [TableName("Cep")]
    [PrimaryKey("Id")]
    public class _Cep
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Cep")]
        public string Cep { get; set; }
        [Column("Logradouro")]
        public string logradouro { get; set; }
        [Column("Complemento")]
        public string complemento { get; set; }
        [Column("Bairro")]
        public string bairro { get; set; }
        [Column("Localidade")]
        public string localidade { get; set; }
        [Column("Uf")]
        public string uf { get; set; }
        [Column("Unidade")]
        public string unidade { get; set; }
        [Column("IBGE")]
        public string ibge { get; set; }
        [Column("GIA")]
        public string gia { get; set; }
       
    }
}
