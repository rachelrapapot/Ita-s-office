using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsMark2;
using studentsMark2.Core;
using studentsMark2.Core.Repositories;
namespace studentsMark2.Data.Repositories
{
    public class HiTechCompaniesRepositories_: ICompaniesRepositories
    {
            private readonly DataContext _context;

            public HiTechCompaniesRepositories_(DataContext dataContext)
            {
                _context = dataContext;
            }

            public List<Companies> GetAllCompanies()
            {
            return _context.companies;
            }
        
    }
}
