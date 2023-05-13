Console.WriteLine("enter a word");
string userinput = Console.WriteLine();

printanyword(userinput); //userinput - argument

static void printanyword(string anystring) //anystring - parameter
{
anystring= anystring.Toupper();
    for(int i= 0; i < 5; i++)  
    {
        Console.WriteLine(anystring);
    }
}
