// See https://aka.ms/new-console-template for more information
int number;
Console.Write("Enter a number : ");
number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 13; i++)
{
    Console.WriteLine(i + "      " + number * i);
}