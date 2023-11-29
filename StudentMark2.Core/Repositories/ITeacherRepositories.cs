
using studentsMark2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark2.Core.Repositories
{
    public interface ITeacherRepositories
    {
        List<Teacher> GetAllTeacher();
    }
}
