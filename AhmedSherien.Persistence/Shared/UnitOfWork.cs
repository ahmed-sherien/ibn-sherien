using AhmedSherien.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Persistence.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _database;

        public UnitOfWork(IDatabaseContext database)
        {
            _database = database;
        }

        public void Save()
        {
            _database.Save();
        }
    }
}
