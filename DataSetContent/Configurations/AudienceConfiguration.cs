using Content.DataSet.Entities;
using Content.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Configurations
{
    public class AudienceConfiguration: IEntityTypeConfiguration<AudiencesEntity>
    {
        public void Configure(EntityTypeBuilder<AudiencesEntity> builder)
        {
            builder.HasKey(x => x.audience_id);

            builder.Property(b=>b.audience_number).HasMaxLength(audiences.Audience_number_max_length).IsRequired();
        }
    }
}
