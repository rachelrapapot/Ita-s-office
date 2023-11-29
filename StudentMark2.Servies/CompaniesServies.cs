using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsMark2;
using studentsMark2.Core.Services;
using studentsMark2.Core;
using studentsMark2.Core.Repositories;

namespace studentsMark2.servies
{
    public class CompaniesServies : ICompaniesServies
    {
        private readonly ICompaniesRepositories _companiesRepositories ;
        public CompaniesServies(ICompaniesRepositories companiesRepositories)
        {
            _companiesRepositories= companiesRepositories ;
        }

        public List<Companies> GetCompanies()
        {
            return _companiesRepositories.GetAllCompanies();
        }
    }
}
