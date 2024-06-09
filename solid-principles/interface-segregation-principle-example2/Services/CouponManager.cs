using interface_segregation_principle_example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation_principle_example2.Services
{
    public class CouponManager
    {
        private readonly Coupon _coupon;
        private readonly CancellableCoupon _cancellableCoupon;

        public CouponManager(Coupon coupon, CancellableCoupon cancellableCoupon = null)
        {
            _coupon = coupon;
            _cancellableCoupon = cancellableCoupon;
        }

        public void RedeemCoupon()
        {
            _coupon.Redeem();
        }

        public void VoidCouponRedemption()
        {
            if (_cancellableCoupon != null)
            {
                _cancellableCoupon.VoidRedemption();
            }
            else
            {
                Console.WriteLine("This coupon cannot be voided.");
            }
        }
    }
}
