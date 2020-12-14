using System;

namespace EncapsulatedBehaviour
{
    public class ConsolePrinter : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}