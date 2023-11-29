using studentsMark2;
using studentsMark2.Core.Repositories;
using studentsMark2.Core.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark2.servies
{
    public class StudentServiescs : IStudentServies
    {
        private readonly IStudntRepositories _StudntRepositories;
        public StudentServiescs(IStudntRepositories StudntRepositories)
        {
            _StudntRepositories = StudntRepositories;
        }

        public List<students> GetStudent()
        {
            return _StudntRepositories.GetAllStudnt();
        }
    }
}
