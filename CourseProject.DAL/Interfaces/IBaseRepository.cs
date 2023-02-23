using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);

        T GetById(int id);

        Task<List<T>> Select();

        bool Delete(T entity);
    }
}
