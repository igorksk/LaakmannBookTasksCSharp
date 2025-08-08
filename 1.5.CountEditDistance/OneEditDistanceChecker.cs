namespace _1._5.CountEditDistance
{
    internal class OneEditDistanceChecker
    {
        public static bool AreOneEditApart(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                return AreOneEditReplace(s1, s2);
            }
            else if (s1.Length + 1 == s2.Length)
            {
                return AreOneEditInsert(s1, s2);
            }
            else if (s1.Length - 1 == s2.Length)
            {
                return AreOneEditInsert(s2, s1);
            }
            else
            {
                return false; // More than one edit apart
            }
        }

        private static bool AreOneEditReplace(string s1, string s2)
        {
            const int maxEdits = 1;
            int editCount = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    editCount++;
                    if (editCount > maxEdits)
                    {
                        return false; // More than one edit
                    }
                }
            }
            if (editCount == 0)
            {
                return false; // No edits, strings are identical
            }
            return true; // Exactly one edit or no edits
        }

        private static bool AreOneEditInsert(string s1, string s2)
        {
            const int maxEdits = 1;
            int editCount = 0;

            int index1 = 0, index2 = 0;

            while (index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    editCount++;
                    if (editCount > maxEdits)
                    {
                        return false; // More than one edit
                    }
                    index2++; // Move the longer string pointer
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }
    }
}
