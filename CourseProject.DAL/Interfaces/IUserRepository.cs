using CourseProject.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByName(string name);
    }
}
