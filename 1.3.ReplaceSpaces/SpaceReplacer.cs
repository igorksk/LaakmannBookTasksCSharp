namespace _1._3.ReplaceSpaces
{
    internal class SpaceReplacer
    {
        //Main idea:
        //First, count how many spaces are in the substring of length trueLength.
        //Calculate the new end index of the string after inserting %20.
        //Fill the array from the end to the beginning to avoid overwriting characters.
        public static void ReplaceSpaces(char[] str, int trueLength)
        {
            int spaceCount = 0;
            for (int i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }

            int newIndex = trueLength + spaceCount * 2;

            // If there is a \0 character at the end of the array, you can place it at the end of the string after all replacements.
            if (newIndex < str.Length)
            {
                str[newIndex] = '\0';
            }

            for (int i = trueLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[newIndex - 1] = '0';
                    str[newIndex - 2] = '2';
                    str[newIndex - 3] = '%';
                    newIndex -= 3;
                }
                else
                {
                    str[newIndex - 1] = str[i];
                    newIndex--;
                }
            }
        }
    }
}
