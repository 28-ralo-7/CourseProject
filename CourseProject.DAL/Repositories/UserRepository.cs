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

        public async Task<bool> Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(User entity)
        {
            _db.Users.Remove(entity);
            _db.SaveChangesAsync();
            return true;
        }

        public async Task<User> GetById(int id)
        {
            return await _db.Users.FirstOrDefaultAsync(x=> x.UserId == id);
        }

        public async Task<User> GetByName(string name)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.UserName == name);
        }

        public Task<List<User>> Select()
        {
            return _db.Users.ToListAsync();
        }
    }
}
