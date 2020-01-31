using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using Login_1.Models;

namespace Login_1.Models
{
    public class JobRolesViewModels
    {
        public List<UserDetails> userDetails { get; set; }
    }
}