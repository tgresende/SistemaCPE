using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Produtos : BasicClass
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public string Descricao { get; set; } 
        public int UnidadeId { get; set; } // filho de unidades
        public double ValorVendaUnitario { get; set; }
        public double QuantidadeProduzida { get; set; } // quantidade produzida em cada "receita"
        public double CustoTotalProducao { get; set; } // soma do custo de todos insumos
        public double CustoUnitarioProducao { get; set; } // custo total/quantidade
        public bool Insumo { get; set; }
    }

    






}
