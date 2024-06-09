using interface_segregation_principle_example1.Interfaces;

namespace interface_segregation_principle_example1.Implementations
{
    public class LaserPrinter : Printer
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing with Laser Printer: {content}");
        }
    }
}
