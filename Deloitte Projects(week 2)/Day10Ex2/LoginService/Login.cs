using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService
{
    public class Login : ILogin
    {
        public bool Authentication(int id, string password)
        {
            TrainingDBEntities db = new TrainingDBEntities();

            if (id <= 0)
                throw new ArgumentException("ID invalid ? ");
            else if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password can't be blank");
            else
            {
                var data = db.RegisterShoppings.Where(x => x.Id == id && x.Password == password).SingleOrDefault() ;

                if (data==null)
                {
                    throw new ArgumentException("Invalid UN/Password");
                }
                else
                {
                    return true;
                }

            }
        }
    }
}
