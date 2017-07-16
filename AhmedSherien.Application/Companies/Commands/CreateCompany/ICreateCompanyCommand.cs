using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Application.Companies.Commands.CreateCompany
{
    public interface ICreateCompanyCommand
    {
        void Execute(CreateCompanyModel model);
    }
}
