
Console.WriteLine("are you coming or leaving? (in/out):");
string userchoice = Console.ReadLine(); 
if(userchoice == "in")
{
    printhello();
}
else
{
    printgoodbye();
}


static void printhello() //function /method
{
    Console.WriteLine("hello, world!");
}

static void printgoodbye()
{
    Console.WriteLine("see you later, alligator");
}
