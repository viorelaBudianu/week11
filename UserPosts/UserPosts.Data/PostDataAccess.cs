using System.Collections.Generic;
using System.IO;
using System.Linq;
using UserPosts.Domain;
using UserPosts.Services;


namespace UserPosts.Data
{
    public class PostDataAccess : BaseDataAccess<Post>, IPostRepository
    {
        protected override string GetFile()
        {
            return @"C:\Users\vbudianu\Desktop\VIO\curs11\tema11.1\UserPosts\UserPosts.Data\Files\posts.json";
        }

        public IList<Post> GetPostsByUserId(int id)
        {
            var list = this.GetAll();
            return list.Where(x => x.UserId == id).ToList();
        }

        protected override string SetFile()
        {
            return GetFile();
        }
    }
}
    

