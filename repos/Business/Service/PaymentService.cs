using Business.Model;
using Business.FakeBankDB;
using System.Linq;

namespace Business.Service
{
    public class PaymentService
    {
        public bool Validate(PaymentModel pay)
        {
            // return true;
            BankDB fk = new BankDB();
            if (fk.cc1.FindAll(x => x.cardNumber == pay.cardNumber).Count > 0)
            {
                return true;

            }
            else 
                return false;
        }
    }
}
