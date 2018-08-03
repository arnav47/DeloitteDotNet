using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFCard
{
    public class Card : ICard
    {
        StudentDBEntities2 db = new StudentDBEntities2();

        public bool Authenticate(int CardNo, string cvv)
        {
  
            var data = db.CardDetails.Where(x => x.CardNo == CardNo && x.cvv == cvv).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Invalid Card Details");
            else
                return true;
        }

        public bool DateCheck(int CardNo)
        {

            var data1 = db.CardDetails.Where(x => x.CardNo == CardNo && x.ExpDate > DateTime.Now ).SingleOrDefault();
            if (data1 == null)
                throw new ArgumentException("Card Expired :( ");
            else
                return true;

        }

        public decimal Trans(int CardNo, decimal amount)
        {
            var data = db.CardDetails.Where(x => x.CardNo == CardNo && x.bal > amount).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Balance is low");
            else
            {
                
                data.bal = data.bal - amount;
                var olddata = db.CardDetails.Where(x => x.CardNo == CardNo && x.bal > amount).SingleOrDefault();
                olddata.bal = data.bal;
                db.SaveChanges();
                Console.WriteLine("Balance sufficient for the transanction .Balance now is: "+ data.bal );
                return data.bal;

            }
                
        }
    }
}
