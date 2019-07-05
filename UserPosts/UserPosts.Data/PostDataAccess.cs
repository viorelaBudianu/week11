using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class PostDataAccess : IPostRepository
    {
        public IList<Post> GetAll()
        {
            string file = @"D:\projects\wantsome\week11\UserPosts\UserPosts.Data\Files\posts.json";
            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<Post>>(text, settings);

            return list;
        }

        public Post GetById(int id)
        {
            string file = @"D:\projects\wantsome\week11\UserPosts\UserPosts.Data\Files\posts.json";
            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<Post>>(text, settings);

            return list.SingleOrDefault(x => x.Id == id);
        }
    }
}
