namespace _1._9.IsRotation
{
    internal class RotationChecker
    {
        // Helper method to check if str2 is a substring of str1
        private static bool IsSubstring(string str1, string str2)
        {
            return str1.Contains(str2);
        }

        public static bool IsRotation(string str1, string str2)
        {
            // Check if lengths are equal
            if (str1.Length != str2.Length)
            {
                return false;
            }
            // Concatenate str1 with itself
            string concatenated = str1 + str1;
            // Check if str2 is a substring of the concatenated string
            return IsSubstring(concatenated, str2);
        }
    }
}
