using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public interface IService<T>
    {
        void Create(T t);
        List<T> Reader();
        void Update(T t);
        void Delete(int id);
    }
}
