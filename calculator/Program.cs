Console.WriteLine("enter the operation (+/-):");
char useroperator = char.Parse(Console.ReadLine());

Console.WriteLine("enter a:");
int firstnum = Int32.Parse(Console.ReadLine());
Console.WriteLine("enter b:");
int secondnum = Int32.Parse(Console.ReadLine());

switch (useroperator)
{
    case '+':
        addition(firstnum, secondnum);
        break;
    case '-':
        subtraction(firstnum, secondnum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void addition (int a, int b)
{
    Console.WriteLine($"{a}+{b}={a+b}")
}

static void subtraction (int a, int b)
{
    Console.WriteLine($"{a}-{b}={a-b}");
}
