﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    // principalTable
    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; } // çok kullanıcı...
    }

}
