﻿using RecapProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Entities.Dtos
{
    public class UserForLoginDto: IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
