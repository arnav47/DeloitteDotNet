using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;
using System.Web.Http.Cors;


namespace webAPI.Controllers
{
    [EnableCors(origins:"*",methods:"*",headers:"*")]
    public class UserInfoAPIController : ApiController
    {
        TrainingDBEntities db = new TrainingDBEntities();

        public List<UserInfo> Get()
        {
            var data = db.UserInfoes.ToList();
            return data;
        }
        public UserInfo Get(int id)
        {
            var data = db.UserInfoes.Where(x => x.Id == id).SingleOrDefault();
            return data;
        }

        public bool Post(UserInfo ui)
        {
            db.UserInfoes.Add(ui);
            var res = db.SaveChanges();
            if (res > 0)
                return true;
            else
                return false;
        }

        public UserInfo delete(int id)
        {
            var data=db.UserInfoes.Where(x => x.Id == id).SingleOrDefault();
            var res = db.SaveChanges();
            return data;
        }


    }
}
