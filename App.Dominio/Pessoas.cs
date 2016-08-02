using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Pessoas : BasicClass
    {               
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public TipoDocumentoPessoa TipoDocumento;
        public string Telefone { get; set; } 
        public string Telefone2 { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }        
        
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

    }
}
