using AhmedSherien.Domain.Companies;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Persistence.Companies
{
    public class CompaniesConfiguration
    {
        public CompaniesConfiguration(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
