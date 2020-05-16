using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class PaymentModel
    {
       public string cardNumber { get; set; }
        public string DateExpiry { get; set; }
        public double amount { get; set; }
        public string CVV { get; set; }

    }
}
