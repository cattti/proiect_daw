using System;
using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

namespace proiect_daw.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> FindByUsername(string username);
        //Task<User> FindByUsernameAndPassword(string username, string password);


        Task<List<User>> FindAll();

        Task<List<User>> FindAllActive();

    }
}

