using Atlantis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Infra.Repository.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(c => c.Id);

            Property(c => c.RazaoSocial)
                .HasColumnName("RazaoSocial")
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.NomeFantasia)
                .HasColumnName("NomeFantasia")
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.CNPJ)
               .HasMaxLength(18)
               .HasColumnName("CNPJ")
               .HasColumnType("char")
               .IsFixedLength()
               .IsRequired()
               .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("CNPJ") { IsUnique = true }));

            Property(c => c.Email)
               .HasColumnName("Email")
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();
        }
    }
}
