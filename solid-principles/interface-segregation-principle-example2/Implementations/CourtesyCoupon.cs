using interface_segregation_principle_example2.Interfaces;

namespace interface_segregation_principle_example2.Implementations
{
    public class CourtesyCoupon : CancellableCoupon
    {
        public void Redeem()
        {
            Console.WriteLine("Courtesy coupon redeemed.");
        }

        public void VoidRedemption()
        {
            Console.WriteLine("Courtesy coupon redemption voided.");
        }
    }
}
