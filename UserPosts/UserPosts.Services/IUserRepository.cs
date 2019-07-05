using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface IUserRepository
    {
        User GetById(int id);

        IList<User> GetAll();
    }
}
