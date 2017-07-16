using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhmedSherien.Web.Companies.Models;
using AhmedSherien.Application.Companies.Commands.CreateCompany;

namespace AhmedSherien.Web.Companies.Services
{
    public class CreateCompanyViewModelFactory : ICreateCompanyViewModelFactory
    {
        public CreateCompanyViewModel Create()
        {
            var viewModel = new CreateCompanyViewModel();

            return viewModel;
        }
    }
}
