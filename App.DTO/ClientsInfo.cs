using App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.DTO
{
    public class ClientsInfo
    {
        public int ClienteId { get; set; }
        public int PessoaId {get;set;}
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public TipoDocumentoPessoa TipoDocumento { get; set; }
        public string Telefone { get; set; }
        public string CidadeEstado { get; set; }
    }
}
