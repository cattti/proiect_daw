using System;
using proiect_daw.Models;

namespace proiect_daw.Helpers.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<User> GetActiveUser(this IQueryable<User> query)
        {
            return query.Where(x => !x.IsDeleted);
        }
    }
}

