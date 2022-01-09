using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Repository
{
    // bütün repository sınıflarımız temel crud metotlarını bu interfaceden implemenet edecekler..
    // Create,Update,Delete,Read
    public interface IRepository<T> where T : class
    {
        int Create(T item); // create
        int Update(T item); // update
        int Delete(T item); //delete 
        T FindById(int Id); // read
        List<T> List(); // Read
    }
}