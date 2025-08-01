using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebService.Domain.Entities;

namespace WebService.DAL.Data.Configurations
{
    public class UtilisateurConfig: IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable("Utilisateur");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasDefaultValueSql("lower(hex(randomblob(16)))");

            builder.Property(u => u.Prenom).HasMaxLength(80).IsRequired();
            builder.Property(u => u.Nom).HasMaxLength(80).IsRequired();
        }
    }
}
