using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Dominio;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.InfraEstrutura.Mapeamento
{
    public class ProdutosInsumosMapeamento : EntityTypeConfiguration<ProdutosInsumos>
    {
        public ProdutosInsumosMapeamento()
        {
            ToTable("ProdutosInsumos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.ProdutoId).IsRequired();
            Property(c => c.InsumoId).IsRequired();
            Property(c => c.Quantidade).IsRequired();

        }
    }
}

