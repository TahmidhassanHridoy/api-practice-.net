using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class EnrollStudentController : ApiController
    {
        [Route("api/student/names")]
        [HttpGet]

        public List<string> StNames(object form)
        {
            var data = (form st in new AskNLearn().EnrolledUsers 
                select st.name).ToList();
            return data;
        }
        public List<EnrolledStudentModel> Get()
        {
            AskNLearn db = new AskNLearn();
            var data = new List<EnrolledStudentModel>();
            foreach(var e in db.EnrolledUsers)
            {
                var st = new EnrolledStudentModel()
                {
                    eid = e.eid,
                    coid = e.coid,
                    uid = e.uid,
                    dateTime = e.dateTime,
                };
                data.Add(st);
            }
            return data;
        }
        public EnrolledStudentModel Get(int id)
        {
            AskNLearn db = new AskNLearn();
            var e  = db.Users.FirstOrDefault(d => d.uid == id);

            var st = new EnrolledStudentModel()
            {
                uid = e.uid,
                name = e.name,
            };
            return st;
        }
    }
}
