using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Repository
{
    public interface ISearchRepository<T>
    {
        T findByUserName(string userName);
    }
}
