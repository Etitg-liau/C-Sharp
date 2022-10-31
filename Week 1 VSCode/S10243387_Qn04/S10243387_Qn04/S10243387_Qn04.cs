// See https://aka.ms/new-console-template for more information
int Option;
Console.WriteLine("------------- MENU --------------");
Console.WriteLine("[1] Calculate Body mass Index");
Console.WriteLine("[2] Calculate Discount");
Console.WriteLine("[3] Display Multiplication Table");
Console.WriteLine("[0] Exit");
Console.WriteLine("---------------------------------");


// Option 1
static void Option1()
{
    double weight;
    double height;
    Console.Write("Enter your weight (kg): ");
    weight = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter your height (m): ");
    height = Convert.ToDouble(Console.ReadLine());
    double bmi = weight / (height * height);
    Console.WriteLine("Your body mass index is {0}", bmi.ToString("0.00"));
    if (bmi < 18.5)
    {
        Console.WriteLine("You are Underweight.");
    }
    else if (bmi > 18.5 && bmi < 23)
    {
        Console.WriteLine("You are Normal Weight.");
    }
    else if (bmi > 23 && bmi < 27.5)
    {
        Console.WriteLine("You are Over Weight.");
    }
    else
    {
        Console.WriteLine("You are Obese.");
    }
}

//Option 2
static void Option2()
{

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
}

//Question 3
static void Option3()
{
    int number;
    Console.Write("Enter a number : ");
    number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < 13; i++)
    {
        Console.WriteLine(i + "      " + number * i);
    }
}

// Main
while (true)
{
    Console.Write("Enter Option: ");
    Option = Convert.ToInt32(Console.ReadLine());
    if (Option == 1)
    {
        Option1();
    }
    else if (Option == 2)
    {
        Option2();
    }
    else if (Option == 3)
    {
        Option3();
    }
    else if (Option == 0)
    {
        Console.WriteLine("Bye");
        break;
    }
    else
    {
        Console.WriteLine("Invalid Option! Please try again.");

    }
}