using AhmedSherien.Application.Companies.Commands.CreateCompany.Factory;
using AhmedSherien.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhmedSherien.Application.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommand : ICreateCompanyCommand
    {
        private readonly ICompaniesRepository _repository;
        private readonly ICompanyFactory _factory;
        private readonly IUnitOfWork _unitOfWork;
        public CreateCompanyCommand(ICompaniesRepository repository,
            ICompanyFactory factory,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _factory = factory;
            _unitOfWork = unitOfWork;
        }

        public void Execute(CreateCompanyModel model)
        {
            var company = _factory.Create(model.Name);
            _repository.Add(company);
            _unitOfWork.Save();
        }
    }
}
