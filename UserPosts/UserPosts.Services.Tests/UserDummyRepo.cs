using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services.Tests
{
    public class UserDummyRepo : IUserRepository
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int id)
        {
            return new User
            {
                Id = id,
                Email = "andrei@wtf.com"
            };
        }

        public void Save(User item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, User item)
        {
            throw new System.NotImplementedException();
        }
    }
}
