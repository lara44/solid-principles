using interface_segregation_principle_example2.Interfaces;

namespace interface_segregation_principle_example2.Implementations
{
    public class EmployeeCoupon : Coupon
    {
        public void Redeem()
        {
            Console.WriteLine("Employee coupon redeemed.");
        }
    }
}
