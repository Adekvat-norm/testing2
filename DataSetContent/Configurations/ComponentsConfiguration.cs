using Content.DataSet.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content.Library.Models;

namespace Content.DataSet.Configurations
{
    public class ComponentsConfiguration : IEntityTypeConfiguration<ComponentsEntity>
    {
        public void Configure(EntityTypeBuilder<ComponentsEntity> builder)
        {
            builder.HasKey(x => x.component_id);
            builder.HasAlternateKey(q => q.contract_id);
            builder.HasAlternateKey(w => w.equipment_id);
            builder.Property(z=>z.nomenclature_number).HasMaxLength(components.Nomenclature_number_max_length).IsRequired();
            builder.Property(c => c.component_name).HasMaxLength(components.Component_name_max_length).IsRequired();
            builder.Property(v => v.quantity);
            builder.Property(b => b.price);
            builder.HasAlternateKey(e => e.user_id);
            builder.Property(n => n.compatibility).HasMaxLength(components.Compatibility_max_length).IsRequired();
            builder.HasAlternateKey(r => r.current_location);
        }
    }
}
