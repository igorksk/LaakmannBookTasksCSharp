namespace _1._9.IsRotation
{
    internal class Program
    {
        static void Main()
        {
            string str1 = "waterbottle";
            string str2 = "erbottlewat";

            bool isRotation = RotationChecker.IsRotation(str1, str2);
            Console.WriteLine($"Is '{str2}' a rotation of '{str1}'? {isRotation}");
        }
    }
}
