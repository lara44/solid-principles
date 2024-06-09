using interface_segregation_principle.Example1.Interfaces;

namespace interface_segregation_principle.Example1.Implementations
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
