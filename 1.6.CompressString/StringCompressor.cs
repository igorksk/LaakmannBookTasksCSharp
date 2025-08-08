using System.Text;

namespace _1._6.CompressString
{
    internal class StringCompressor
    {
        public static string CompressString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str; // Return empty string if input is null or empty
            }
            int compressedLength = CountCompressedLength(str);
            StringBuilder compressed = new(compressedLength);
            char currentChar = str[0];
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    compressed.Append(currentChar).Append(count);
                    currentChar = str[i];
                    count = 1;
                }
            }
            // Append the last character and its count
            compressed.Append(currentChar).Append(count);
            // Return the compressed string if it's shorter than the original, otherwise return the original
            return compressed.Length < str.Length ? compressed.ToString() : str;
        }

        private static int CountCompressedLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0; // Return 0 if input is null or empty
            }
            int compressedLength = 0;
            char currentChar = str[0];
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    compressedLength += 1 + count.ToString().Length; // 1 for the character and length of the count
                    currentChar = str[i];
                    count = 1;
                }
            }
            // Add the last character and its count
            compressedLength += 1 + count.ToString().Length;
            return compressedLength;
        }
    }
}
