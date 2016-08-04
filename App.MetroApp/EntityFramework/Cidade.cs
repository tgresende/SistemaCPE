using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.MetroApp.EntityFramework
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Estado { get; set; }

        public virtual ICollection<Pessoa> Pessoa { get; set; }

        public Cidade()
        {
            this.Pessoa = new HashSet<Pessoa>();
        }
    }
}
