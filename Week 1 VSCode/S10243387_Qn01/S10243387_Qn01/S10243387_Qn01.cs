// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
// Question 1
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

