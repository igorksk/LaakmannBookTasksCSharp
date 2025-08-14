namespace _1._6.CompressString
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");

            var str = Console.ReadLine() ?? throw new NullReferenceException();

            var result = StringCompressor.CompressString(str);

            Console.WriteLine(result);

            // Add your test logic here or call your string compressor logic
            Console.WriteLine("Add your test logic here.");
        }
    }
}