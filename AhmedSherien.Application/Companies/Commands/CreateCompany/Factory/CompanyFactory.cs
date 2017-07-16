using System;
using System.Collections.Generic;
using System.Text;
using AhmedSherien.Domain.Companies;

namespace AhmedSherien.Application.Companies.Commands.CreateCompany.Factory
{
    public class CompanyFactory : ICompanyFactory
    {
        public Company Create(string name)
        {
            var company = new Company();
            company.Name = name;
            return company;
        }
    }
}
