using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trabalho.Models.Domain;

namespace Trabalho.Types
{
    public class TypeBank:IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder){
            builder.ToTable("Banco");
            builder.HasKey(Banco => Banco.Id_bank);
            builder.Property(Banco => Banco.Nome).HasColumnType("varchar(50)");
            builder.Property(Banco => Banco.Conta).HasColumnType("varchar(14)");
            builder.Property(Banco => Banco.Limite).HasColumnType("double");
            builder.Property(Banco => Banco.Saldo).HasColumnType("double");
        }
    }
}