﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    // user tablosundaki alanları adress tablosuna bölüyorum..
    public class Adress
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        // navigation property
        public User User { get; set; } // bir kullanıcı



    }
}
