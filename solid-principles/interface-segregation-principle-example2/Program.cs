// Seleccionar el tipo de cupón en tiempo de ejecución
using interface_segregation_principle_example2.Implementations;
using interface_segregation_principle_example2.Interfaces;
using interface_segregation_principle_example2.Services;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de cupón: 1. Empleado, 2. Cortesía, 3. Dinero");
            var input = Console.ReadLine();
            Coupon coupon = input switch
            {
                "1" => new EmployeeCoupon(),
                "2" => new CourtesyCoupon(),
                "3" => new MoneyCoupon(),
                _ => throw new InvalidOperationException("Selección no válida")
            };

            // Crear una instancia de CouponManager con el cupón seleccionado
            var couponManager = new CouponManager(coupon);

            // Redimir el cupón
            couponManager.RedeemCoupon();

            // Anular la redención del cupón
            couponManager.VoidCouponRedemption();
            Console.ReadLine();
        }
    }
}