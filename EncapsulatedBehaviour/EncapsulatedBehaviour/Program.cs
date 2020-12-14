namespace EncapsulatedBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint console = new ConsolePrinter();
            IPrint file = new FilePrinter();
            
            // Console
            Printer printer = new Printer(console);
            printer.Print("Test");
            
            // File
            printer.SetPrinter(file);
            printer.Print("Test File");
        }
    }
}