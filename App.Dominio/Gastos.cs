using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Gastos : BasicClass
    {
        public string Descricao { get; set; }

        // para mostrar que gastos é pai
        public virtual ICollection<GastosProjetos> GastosProjetos { get; set; }

        public Gastos()
        {
            this.GastosProjetos = new HashSet<GastosProjetos>();
        }
    }
}
