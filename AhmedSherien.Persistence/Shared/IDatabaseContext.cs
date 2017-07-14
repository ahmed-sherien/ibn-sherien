
using AhmedSherien.Domain.Common;
using AhmedSherien.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Persistence.Shared
{
    public interface IDatabaseContext
    {
        DbSet<T> Set<T>() where T : class, IEntity;
        void Save();
    }
}
