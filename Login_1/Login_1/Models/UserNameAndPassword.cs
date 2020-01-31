﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_1.Models
{
    public class UserNameAndPassword
    {
        [DisplayName("User Name")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string LoginErrorMSg { set; get; }

    }
 
}