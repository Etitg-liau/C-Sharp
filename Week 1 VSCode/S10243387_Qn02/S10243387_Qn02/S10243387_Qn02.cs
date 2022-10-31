// See https://aka.ms/new-console-template for more information
double amount;
double discount;
Console.Write("Enter Amount ($) : ");
amount = Convert.ToDouble(Console.ReadLine());
if (amount <= 100)
{
    discount = 0;
    Console.WriteLine("Discount given (%) : 0");
}
else if (amount > 100 && amount <= 500)
{
    discount = 5;
    Console.WriteLine("Discount given (%) : 5");
}
else if (amount > 500 && amount <= 1000)
{
    discount = 10;
    Console.WriteLine("Discount given (%) : 10");
}
else
{
    discount = 20;
    Console.WriteLine("Discount given (%) : 20");
}
double discountamt = (discount / 100) * amount;
Console.WriteLine("Discount amount($) : " + discountamt);
