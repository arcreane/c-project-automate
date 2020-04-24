
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automate.Payment
{
    public abstract class PaymentMethod
    {

        public PaymentMethod()
        {
        }

        public decimal value;
        public decimal givenValue;

        public abstract void Pay(decimal Price);
        public abstract void Refund();

    }
}
