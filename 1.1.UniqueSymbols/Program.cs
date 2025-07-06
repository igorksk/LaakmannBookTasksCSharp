
Console.WriteLine("Enter string: ");

var str = Console.ReadLine();

// Without using data structures

var hasUnique = true;

for(int i = 0; i < str!.Length; i++)
{
    for (int j = i + 1; j < str!.Length; j++)
    {
        if (str[i] == str[j])
        {
            hasUnique = false; 
            break;
        }
    }
}

if (hasUnique)
{
    Console.WriteLine("Symbols unique");
}
else
{
    Console.WriteLine("Symbols not unique");
}