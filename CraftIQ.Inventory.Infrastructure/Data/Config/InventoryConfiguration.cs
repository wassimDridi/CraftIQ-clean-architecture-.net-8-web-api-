using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Infrastructure.Data.Config
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Core.Entities.Inventory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Inventory> builder)
        {
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Location)
                   .HasMaxLength(200);

            builder.Property(p => p.Name)
                   .HasMaxLength(50);
        }
    }
}
