using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.dao
{
    internal interface Dao<T>
    {
        T getById(int id);
        List<T> getAll();
        int insert(T t);
        int update(T t);
        int delete(T t);
    }
}
