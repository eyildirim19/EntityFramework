﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    public class User : BaseEntity
    {
        public string Password { get; set; }
    }
}