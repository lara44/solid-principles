// Seleccionar el tipo de impresora en tiempo de ejecución
using interface_segregation_principle_example1.Implementations;
using interface_segregation_principle_example1.Interfaces;
using interface_segregation_principle_example1.Services;

Console.WriteLine("Seleccione el tipo de impresora: 1. Láser, 2. Inyección de tinta");
var input = Console.ReadLine();
Printer printer = input switch
{
    "1" => new LaserPrinter(),
    "2" => new InkjetPrinter(),
    _ => throw new InvalidOperationException("Selección no válida")
};

// Crear una instancia de Scanner
Scanner scanner = new DocumentScanner();

// Crear una instancia de OfficeManager con la impresora y el escáner seleccionados
var officeManager = new OfficeManager(printer, scanner);

// Realizar las tareas de oficina
officeManager.PerformOfficeTasks();
Console.ReadLine();