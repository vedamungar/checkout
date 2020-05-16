using System;
using System.Collections.Generic;
using Business.Model;
namespace Business.FakeBankDB
{
    public  class BankDB
    {
     
 
         CreditCardModel c1 = new CreditCardModel()
        {
            cardNumber = "1234",
            amount = 100,
            CVV = 12,
            DateExpiry = new DateTime(2020, 12, 12)
        };
        CreditCardModel c2 = new CreditCardModel()
        {
            cardNumber = "1235",
            amount = 100,
            CVV = 12,
            DateExpiry = new DateTime(2020, 12, 12)
        };
        CreditCardModel c3 = new CreditCardModel()
        {
            cardNumber = "1236",
            amount = 100,
            CVV = 12,
            DateExpiry = new DateTime(2020, 12, 12)
        };
        public  List<CreditCardModel> cc1 = new List<CreditCardModel>();

        public BankDB()
        {
            cc1.Add(c1);
            cc1.Add(c2);
            cc1.Add(c3);
        }

    }
}
