using interface_segregation_principle_example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation_principle_example2.Implementations
{
    public class MoneyCoupon : CancellableCoupon
    {
        public void Redeem()
        {
            Console.WriteLine("Money coupon redeemed.");
        }

        public void VoidRedemption()
        {
            Console.WriteLine("Money coupon redemption voided.");
        }
    }
}
