﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStore.BLL.DTO
{
    public class UserDTO
    {
        public string IdUser { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
    }
}
