using AhmedSherien.Application.Companies.Commands.CreateCompany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AhmedSherien.Web.Companies.Models
{
    public class CreateCompanyViewModel
    {
        [Required]
        public string Name { get; set; }
        public CreateCompanyModel Company
        {
            get
            {
                return new CreateCompanyModel
                {
                    Name = Name
                };
            }
        }
    }
}
