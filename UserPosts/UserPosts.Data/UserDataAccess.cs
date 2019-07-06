using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class UserDataAccess : BaseDataAccess<User>, IUserRepository
    {
        protected override string GetFile()
        {
            return @"C:\Users\vbudianu\Desktop\VIO\curs11\tema11.1\UserPosts\UserPosts.Data\Files\users.json";
        }
    }
}
