Console.WriteLine("Input an integer positive number");
UInt64.TryParse(Console.ReadLine(), out ulong ulNumber);
Console.WriteLine($"The number {ulNumber} has the folowing dividers:");
var nDividers = 0;
for (ulong i = 1; i <= ulNumber; i++)
{
    if (ulNumber % i == 0)
    {
        Console.Write("{0} ", i);
        nDividers++;
    }
}
Console.WriteLine();
switch (nDividers)
{
    case 0:
    case 1:
        Console.WriteLine($"The number {ulNumber} is neither complex nor prime");
        break;
    case 2:
        Console.WriteLine($"The number {ulNumber} is prime");
        break;
    default:
        Console.WriteLine($"The number {ulNumber} is complex");
        break;
}   
Console.Read();
