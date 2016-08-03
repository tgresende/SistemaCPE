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
        public TipoDocumentoPessoa TipoDocumento { get; set; }
        public string Telefone { get; set; } 
        public string Telefone2 { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoBairro { get; set; }        
        
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

    }
}
