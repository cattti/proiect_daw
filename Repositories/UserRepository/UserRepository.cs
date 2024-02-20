using System;
using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;
using proiect_daw.Data;
using Microsoft.EntityFrameworkCore;
using proiect_daw.Helpers.Extensions;

namespace proiect_daw.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(clasaContext context) : base(context)
        {
        }

        public async Task<List<User>> FindAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<List<User>> FindAllActive()
        {
            return await _table.GetActiveUser().ToListAsync();
        }

        public async Task<User> FindByUsername(string username)
        {
            return (await _table.FirstOrDefaultAsync(u => u.Username.Equals(username)))!;
        }

        //public  async Task<User> FindByUsernameAndPassword(string username, string password)
        //{
        //    return (await _table.FirstOrDefaultAsync(u => u.Username.Equals(username) && u.Password.Equals(password)))!;
        //}
    }
}

