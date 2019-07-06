using System.Collections.Generic;

namespace UserPosts.Services
{
    public interface IBaseRepository<T>
    {
        T GetById(int id);

        IList<T> GetAll();

        //void Save(T item);

        //void Delete(int id);

        //void Update(int id, T item);
    }
}
