using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface IPostRepository
    {
        Post GetById(int id);

        IList<Post> GetAll();
    }
}