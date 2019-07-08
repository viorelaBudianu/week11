using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public abstract class BaseDataAccess<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected abstract string GetFile();

        protected abstract string SetFile();

        public IList<T> GetAll()
        {
            string file = this.GetFile();

            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<T>>(text, settings);

            return list;
        }

        public T GetById(int id)
        {
            string file = this.GetFile();

            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<T>>(text, settings);

            return list.SingleOrDefault(x => x.Id == id);
        }

        public void Save(T item)
        {
            string path = this.SetFile();
            FileStream Files = File.Create(path);
            Byte[] a = new UTF8Encoding(true).GetBytes((dynamic)item);
            Files.Write(a, 0, a.Length);
        }

        public void Delete(int id)
        {
            IList<T> AllList = this.GetAll();
            AllList.RemoveAt(AllList.IndexOf(this.GetById(id)));
        }

        public void Update(int id, T item)
        {
            
        }
    }
}

