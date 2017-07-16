using AhmedSherien.Web.Companies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhmedSherien.Web.Companies.Services
{
    public interface ICreateCompanyViewModelFactory
    {
        CreateCompanyViewModel Create();
    }
}
