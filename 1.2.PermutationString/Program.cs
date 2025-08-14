namespace _1._2.PermutationString
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string 1: ");

            var str1 = Console.ReadLine() ?? throw new NullReferenceException();

            Console.WriteLine("Enter string 2: ");

            var str2 = Console.ReadLine() ?? throw new NullReferenceException();


            if (PermutationChecker.CheckIfPermutations(str1, str2))
            {
                Console.WriteLine("Strings are permutations");
            }
            else
            {
                Console.WriteLine("Strings are not permutations");
            }

            // Add your test logic here or call your permutation checker logic
            Console.WriteLine("Add your test logic here.");
        }
    }
}
