using interface_segregation_principle_example1.Interfaces;

namespace interface_segregation_principle_example1.Implementations
{
    public class DocumentScanner : Scanner
    {
        public string Scan()
        {
            Console.WriteLine("Scanning document...");
            return "Scanned content";
        }
    }
}
