namespace _1._3.ReplaceSpaces
{
    internal class Program
    {
        static void Main()
        {
            char[] input = ['M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', '\0', '\0', '\0', '\0'];
            int trueLength = 13;

            SpaceReplacer.ReplaceSpaces(input, trueLength);

            Console.WriteLine(new string(input));
        }
    }
}