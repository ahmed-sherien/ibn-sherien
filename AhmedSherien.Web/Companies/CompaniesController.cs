using AhmedSherien.Application.Companies.Commands.CreateCompany;
using AhmedSherien.Application.Companies.Queries.GetCompaniesList;
using AhmedSherien.Web.Companies.Models;
using AhmedSherien.Web.Companies.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhmedSherien.Web.Companies
{
    public class CompaniesController : Controller
    {
        private readonly IGetCompaniesListQuery _getCompanies;
        private readonly ICreateCompanyCommand _createCompany;
        private readonly ICreateCompanyViewModelFactory _createCompanyFactory;
        public CompaniesController(IGetCompaniesListQuery getCompanies,
            ICreateCompanyCommand createCompany,
            ICreateCompanyViewModelFactory createCompanyFactory)
        {
            _getCompanies = getCompanies;
            _createCompany = createCompany;
            _createCompanyFactory = createCompanyFactory;
        }
        public IActionResult Index()
        {
            var model = _getCompanies.Execute();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = _createCompanyFactory.Create();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(CreateCompanyViewModel viewModel)
        {
            var model = viewModel.Company;
            _createCompany.Execute(model);
            return RedirectToAction("Index");
        }
    }
}
