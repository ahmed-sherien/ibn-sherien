using AhmedSherien.Domain.Companies;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Application.Companies.Commands.CreateCompany.Factory
{
    public interface ICompanyFactory
    {
        Company Create(string name);
    }
}
