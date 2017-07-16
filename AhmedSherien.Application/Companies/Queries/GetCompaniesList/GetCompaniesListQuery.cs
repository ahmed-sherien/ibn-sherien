using AhmedSherien.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AhmedSherien.Application.Companies.Queries.GetCompaniesList
{
    public class GetCompaniesListQuery : IGetCompaniesListQuery
    {
        private readonly ICompaniesRepository _repository;
        public GetCompaniesListQuery(ICompaniesRepository repository)
        {
            _repository = repository;
        }
        public List<CompanyModel> Execute()
        {
            var companies = _repository.GetAll()
                .Select(x => new CompanyModel
                {
                    Id = x.Id,
                    Name = x.Name
                });

            return companies.ToList();
        }
    }
}
