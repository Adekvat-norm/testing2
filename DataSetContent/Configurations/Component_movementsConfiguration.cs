using Content.DataSet.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Configurations
{
    public class Component_movementsConfiguration : IEntityTypeConfiguration<Component_movementsEntity>
    {
        public void Configure(EntityTypeBuilder<Component_movementsEntity> builder)
        {
            builder.HasKey(x => x.movement_id);
            builder.HasAlternateKey(q => q.component_id);
            builder.HasAlternateKey(w => w.old_location);
            builder.HasAlternateKey(e => e.new_location);
            builder.Property(z=>z.movement_date).IsRequired();
            builder.Property(c => c.movement_reason);
            builder.HasAlternateKey(r => r.moved_by);
        }
    }
}
