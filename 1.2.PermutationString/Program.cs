using _1._2.PermutationString;

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
