using System.IO;

namespace EncapsulatedBehaviour
{
    public class FilePrinter : IPrint
    {
        public void Print(string text)
        {
            File.WriteAllText(Path.GetFullPath("Teste.txt"), text);
        }
    }
}