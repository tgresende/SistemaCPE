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
    public class PessoasMapeamento : EntityTypeConfiguration<Pessoas>
    {
        public PessoasMapeamento()
        {
            ToTable("Pessoas");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome).HasMaxLength(100);
            Property(c => c.CPFCNPJ).HasMaxLength(15);
            Property(c => c.TipoDocumento);
            Property(c => c.Telefone).HasMaxLength(12);
            Property(c => c.Telefone2).HasMaxLength(12);
            Property(c => c.Rua).HasMaxLength(100);
            Property(c => c.Numero).HasMaxLength(10);
            Property(c => c.Complemento).HasMaxLength(50);
            Property(c => c.Cep).HasMaxLength(8);
            Property(c => c.Bairro).HasMaxLength(50);
            Property(c => c.CidadeId).IsRequired();

            HasRequired<Cidade>(c => c.Cidade).WithMany(c => c.Pessoas).HasForeignKey(c=>c.CidadeId);
        }
    }
}

