using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenicoElio_Bressanello_MVC.RestaurantEntity.Config
{
    public class PiattoConfig IEntityTypeConfiguration<Piatto>{
        public void Configure(EntityTypeBuilder<Piatto> builder)
    {
        builder.ToTable("Piatto");
        builder.HasKey(t => t.Id);
        builder.HasIndex(p => p.Nome).IsUnique();
        builder.Property(p => p.Prezzo).HasColumnType("decimal(9,2)");
    }
}