using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Repository
{
    // User sınıfın crud işlemlerinden sorumlu sınıf...
    public class UserRepository : IRepository<User>, ISearchRepository<User>
    {
        CrudAppDbContext dbContext; // field
        public UserRepository()
        {
            dbContext = new CrudAppDbContext();
        }

        public int Create(User item)
        {
            dbContext.Add(item);
            try
            {
                return dbContext.SaveChanges(); // veritabanına yansıt. etkilenen satır sayısını dön...
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(User item)
        {
            try
            {
                dbContext.Remove(item);
                return dbContext.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public User findByUserName(string userName)
        {
            return dbContext.Kullanici.FirstOrDefault(c => c.Name == userName);
        }

        public User FindById(int Id)
        {
            return dbContext.Kullanici.Find(Id);
        }

        public List<User> List()
        {
            return dbContext.Kullanici.ToList();
        }

        public int Update(User item)
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int RemoveBloke()
        {
            int result = dbContext.Database.ExecuteSqlRaw("ResetUserBloke"); // sql cümlesin çalıştırır..
            return result;
        }
    }
}
