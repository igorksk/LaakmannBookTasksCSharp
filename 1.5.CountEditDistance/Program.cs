using _1._5.CountEditDistance;

Console.WriteLine("Enter string 1: ");

var str1 = Console.ReadLine() ?? throw new NullReferenceException();

Console.WriteLine("Enter string 2: ");

var str2 = Console.ReadLine() ?? throw new NullReferenceException();

if (OneEditDistanceChecker.AreOneEditApart(str1, str2))
{
    Console.WriteLine("Strings are one edit away");
}
else
{
    Console.WriteLine("Strings are not one edit away");
}