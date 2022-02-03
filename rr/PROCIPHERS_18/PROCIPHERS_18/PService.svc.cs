using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PROCIPHERS_18
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PService.svc or PService.svc.cs at the Solution Explorer and start debugging.
    public class PService : IPService
    {
        PCDBMLDataContext db = new PCDBMLDataContext();

        public int RegisterBuyer(BuyerClass obj)
        {
            var buyer = new BuyerT
            {
                Buyer_ID = obj.Buyer_ID,
                First_Name = obj.First_Name,
                Last_Name = obj.Last_Name,
                Password = obj.Password,
                ID_Number = obj.ID_Number,
                Email = obj.Email

            };

            db.BuyerTs.InsertOnSubmit(buyer);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex) {
                ex.GetBaseException();
                return -1;
            }
            
        }

        public bool LogIn(int usertype, String username, String password) {

            if (usertype == 1) {
                dynamic founduser = (from p in db.BuyerTs where p.Email.Equals(username) && p.Password.Equals(password) select p).FirstOrDefault();

                if (founduser == null) {
                    return false;
                }
            }
            else if (usertype == 0)
            {
                dynamic founduser = (from p in db.Sellers where p.Email.Equals(username) && p.Password.Equals(password) select p).FirstOrDefault();

                if (founduser == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
