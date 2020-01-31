using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.WebPages.Html;


namespace Login_1.Models
{
    public class UserDetails
    {
        public string Mail { get; set; }
        public int PhoneNumber { get; set; }
        public Nullable<int> Marks { get; set; }
        public string IntervieweeErrorMsg { set; get; }
        public int JobId { get; set; }

    }
}