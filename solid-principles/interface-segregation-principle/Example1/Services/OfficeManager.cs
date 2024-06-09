using interface_segregation_principle.Example1.Interfaces;

namespace interface_segregation_principle.Example1.Services
{
    public class OfficeManager
    {
        private readonly Printer _printer;
        private readonly Scanner _scanner;

        public OfficeManager(Printer printer, Scanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void PerformOfficeTasks()
        {
            string document = _scanner.Scan();
            _printer.Print(document);
            Console.WriteLine("Office tasks completed.");
        }
    }
}
