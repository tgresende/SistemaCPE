using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class InsumosProdutos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public int InsumoId { get; set; }
    
    }
}
