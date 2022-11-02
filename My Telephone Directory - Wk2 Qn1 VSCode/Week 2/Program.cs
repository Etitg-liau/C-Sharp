// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

while(true)
{
    Console.Write("Enter name: ");
    string name= Console.ReadLine();
    if (name == "Exit") break;
    Console.Write("Enter Phone number ");
    int phoneno = Convert.ToInt32(Console.ReadLine());
    string data = name + "," + phoneno;
    using (StreamWriter sw = new StreamWriter("PhoneDirectory.csv", true))
    {
        sw.WriteLine(data);
    }
}
