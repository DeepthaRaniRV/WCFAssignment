using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInfoLibrary
{
   public class CdInfo : ICardInfo
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public bool Transaction(int cardno, DateTime expdt, int cvv, float tramt)
        {
           if(cardno<=0)

            throw new ArgumentException("Card No. must be a valid one");

            var data = (db.CardInfoes.Where(x => x.CardNo == cardno)).SingleOrDefault();
            if (data == null)
            {
                throw new ArgumentException("Invalid Card Number");
            }
            else
            { if (expdt.Month <= 0 || expdt.Month > 12)
                    throw new ArgumentException("Entered details are invalid");
                else {
                    if (data.ExpDate < DateTime.Now)
                        throw new ArgumentException("Your card has expired");
                    else
                    {
                        if (expdt != data.ExpDate)
                            throw new ArgumentException("Your details doesn't match");
                        else
                        {
                            data.Balance = data.Balance - tramt;
                            var res = db.SaveChanges();
                            if (res > 0)
                                Console.WriteLine("Success");
                                return true;
                            
                        }

                    }

                } 
            }

        }
    }
}
