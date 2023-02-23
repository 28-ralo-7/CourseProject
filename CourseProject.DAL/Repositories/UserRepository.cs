using CourseProject.DAL.Interfaces;
using CourseProject.Domain.Entity;
using CourseWeb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PracticeControlContext _db;

        public UserRepository(PracticeControlContext db)
        {
            _db = db;
        }

        public bool Create(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> Select()
        {
            return _db.Users.ToListAsync();
        }
    }
}
