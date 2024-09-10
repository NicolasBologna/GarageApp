﻿using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; } // Es el mail
        public string Password { get; set; }
        public string Phone { get; set; }
        public States State { get; set; }
        public bool IsActive { get; set; }
    }
}
