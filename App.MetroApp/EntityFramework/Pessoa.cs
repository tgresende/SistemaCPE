using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace App.MetroApp.EntityFramework
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public int CidadeId { get; set; }

        public DateTime? Data { get; set; }

        public double? Valor { get; set; }

        [Required]
        public bool Ativo { get; set; }

        public Cidade Cidade { get; set; }
    }
}
