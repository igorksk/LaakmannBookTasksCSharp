using _1._6.CompressString;

Console.WriteLine("Enter string: ");

var str = Console.ReadLine() ?? throw new NullReferenceException();

var result = StringCompressor.CompressString(str);

Console.WriteLine(result);