using System.Collections;

namespace _1._1.UniqueSymbols
{
    internal class SymbolsValidators
    {
        public static bool ValidateWithoutDataStructures(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ValidateUsingHashtable(string str)
        {
            Hashtable hashtable = [];

            int index = 0;

            foreach (char symbol in str)
            {
                if (hashtable.ContainsKey(symbol))
                {
                    return false;
                }

                hashtable.Add(symbol, index);

                index++;
            }

            return true;
        }
    }
}
