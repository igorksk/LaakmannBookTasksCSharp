
using _1._1.UniqueSymbols;

Console.WriteLine("Enter string: ");

var str = Console.ReadLine() ?? throw new NullReferenceException();


if (SymbolsValidators.ValidateWithoutDataStructures(str!))
{
    Console.WriteLine("Symbols unique by first check");
}
else
{
    Console.WriteLine("Symbols not unique by first check");
}


if (SymbolsValidators.ValidateUsingHashtable(str!))
{
    Console.WriteLine("Symbols unique by second check");
}
else
{
    Console.WriteLine("Symbols not unique by second check");
}