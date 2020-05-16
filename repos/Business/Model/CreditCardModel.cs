using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class CreditCardModel
    {
        public string cardNumber { get; set; }
        public DateTime DateExpiry { get; set; }
        public double amount { get; set; }
        public int CVV { get; set; }
    }
}
