using IsPalindromePermutation;

namespace _1._4.IsPalindromePermutation
{
    internal class Program
    {
        static void Main()
        {
            string input = "Tact Coa";

            bool result = PermutationChecker.IsPalindromePermutation(input);

            Console.WriteLine(result);

            // Add your test logic here or call your palindrome permutation checker logic
            Console.WriteLine("Add your test logic here.");
        }
    }
}