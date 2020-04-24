
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

        public int value;

        public abstract bool Pay(decimal price);
    }
}
