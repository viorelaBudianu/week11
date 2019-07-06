using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services
{
   public class CommentsManager
    {
        private static string path = @"C:\Users\vbudianu\Desktop\VIO\curs11\tema11.1\UserPosts\UserPosts.Data\Files\comments.json";
        private FileStream CommentsFile = File.Create(path);
        public void AddComment(Comment comment)
        {
            //serializez mai intai, si dupa salvez commentul in fisier
            string output = JsonConvert.SerializeObject(comment);
            Byte[] a = new UTF8Encoding(true).GetBytes(output);
            CommentsFile.Write(a, 0, a.Length);
        }            
    }
}
