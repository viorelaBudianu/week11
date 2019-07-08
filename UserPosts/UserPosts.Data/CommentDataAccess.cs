using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    class CommentDataAccess : BaseDataAccess<Comment>, ICommentRepository
    {
        public IList<Comment> GetCommentsByUserId(int id)
        {
            var list = this.GetAll();
            PostDataAccess postList = new PostDataAccess();
            var ListOfPosts=postList.GetPostsByUserId(id);
            return list.Join(ListOfPosts, comment => comment.Id, post => post.Id, (comment, post) => comment).ToList();
                
        }

        protected override string GetFile()
        {
            return @"C:\Users\vbudianu\Desktop\VIO\curs11\tema11.1\UserPosts\UserPosts.Data\Files\comment.json";
        }

        protected override string SetFile()
        {
            return GetFile();
        }
    }
}
