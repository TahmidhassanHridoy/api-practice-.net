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
    public class UserController : ApiController
    {
        public List<UserModel> Get() 
        {
            //by default api maps method with request verbs

            List<UserModel> user = new List<UserModel>();
            for(int i =0; i < 10; i++)
            {
                user.Add(new UserModel() { uid = i + 1, name = "User" + 1 });
            }
            return user;
            //AskNLearn db = new AskNLearn();
           // return db.Users.ToList();
        }

        public UserModel Get(int id)
        {
            return new UserModel() { uid = id, name = "user" + id };
        }

        public string Post()
        {
            return "Post";
        }

        public string Put()
        {
            return "Put";
        }

        public string Delete()
        {
            return "Delete";
        }
    }
}
