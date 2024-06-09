﻿using interface_segregation_principle.Example1.Interfaces;

namespace interface_segregation_principle.Example1.Implementations
{
    public class InkjetPrinter : Printer
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing with Inkjet Printer: {content}");
        }
    }
}
