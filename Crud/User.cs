using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class User
    {
        public User()
        {
            CreDate = DateTime.Now; // instance aldığımızda credate o anki zamanı set edelim...
        }

        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Nullable<int> Age { get; set; }

        public DateTime CreDate { get; set; }
    }
}