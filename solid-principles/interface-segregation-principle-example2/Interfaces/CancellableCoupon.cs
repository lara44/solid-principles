namespace interface_segregation_principle_example2.Interfaces
{
    public interface CancellableCoupon : Coupon
    {
        void VoidRedemption();
    }
}
