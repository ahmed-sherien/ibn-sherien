using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Application.Companies.Queries.GetCompaniesList
{
    public interface IGetCompaniesListQuery
    {
        List<CompanyModel> Execute();
    }
}
