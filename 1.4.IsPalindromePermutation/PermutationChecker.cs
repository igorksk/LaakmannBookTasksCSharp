namespace IsPalindromePermutation
{
    internal class PermutationChecker
    {
        public static bool IsPalindromePermutation(string str)
        {
            Dictionary<char, int> dictionary = [];

            foreach (char symbol in str)
            {
                if (symbol == ' ')
                    continue; // Ignore spaces

                char lowerSymbol = char.ToLower(symbol); // Ignore case

                if (dictionary.TryGetValue(lowerSymbol, out int value))
                {
                    dictionary[lowerSymbol] = ++value;
                }
                else
                {
                    dictionary[lowerSymbol] = 1;
                }
            }

            int oddCount = 0;

            foreach (var dictValue in dictionary)
            {
                if (dictValue.Value % 2 == 1)
                {
                    oddCount++;
                }
            }

            // Can be only 0 or 1 odd chars count
            return oddCount < 2;
        }
    }
}
