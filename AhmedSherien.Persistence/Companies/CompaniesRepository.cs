using AhmedSherien.Application.Interfaces.Persistence;
using AhmedSherien.Domain.Companies;
using AhmedSherien.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Persistence.Companies
{
    public class CompaniesRepository : Repository<Company>, ICompaniesRepository
    {
        public CompaniesRepository(IDatabaseContext database) : base(database) { }
    }
}
