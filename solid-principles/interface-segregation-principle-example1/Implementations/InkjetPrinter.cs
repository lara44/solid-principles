using interface_segregation_principle_example1.Interfaces;

namespace interface_segregation_principle_example1.Implementations
{
    public class InkjetPrinter : Printer
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing with Inkjet Printer: {content}");
        }
    }
}
