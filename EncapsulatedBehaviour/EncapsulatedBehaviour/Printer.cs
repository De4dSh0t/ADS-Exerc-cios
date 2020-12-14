namespace EncapsulatedBehaviour
{
    public class Printer
    {
        private IPrint printer;

        public Printer(IPrint printer)
        {
            this.printer = printer;
        }

        public void SetPrinter(IPrint printer)
        {
            this.printer = printer;
        }

        public void Print(string text)
        {
            printer.Print(text);
        }
    }
}