using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class EnrolledStudentModel
    {
        public int eid { get; set; }
        public int uid { get; set; }
        public int coid { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string userType { get; set; }
        public System.DateTime dateTime { get; set; }

        public virtual UserModel User { get; set; }
    }
}