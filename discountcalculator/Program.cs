//<10 - 1%
// total >= 10 && <20 - 5%
//total >= 20 - 10%

Console.WriteLine("provide total: ");
int userintput = int32.Parse(Console.Readline());

double discount = calculatediscount(userintput);

Console.WriteLine($"your discount is: {discount}%");

double newtotal = calculatenewtotal(userinput, discount);

Console.WriteLine($"your update total with {discount}%: {newtotal}");
    static double calculatediscount(int total)
{
    if(total<10)
    {
        return 1;
    }
else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}
static double calculatenewtotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result; 
}
