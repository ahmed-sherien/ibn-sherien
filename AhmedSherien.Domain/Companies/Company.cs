using AhmedSherien.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Domain.Companies
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
