using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.dao
{
    public interface Dao<T>
    {
        T getById(int id);
        List<T> getAll();
        int insert(T t);
        int update(T t);
        int delete(T t);
    }
}
