// See https://aka.ms/new-console-template for more information
using System.IO;
/*static void ReadDistanceBasedFare()
{
    string[] csvLines = File.ReadAllLines("distance-based-fare.csv");
}
*/
string board;
string alight;
double board1 = 0;
double board2 = 0;
double cost = 0;
string[] csvLines = File.ReadAllLines("bus_174.csv");
string[] heading = csvLines[0].Split(',');

Console.WriteLine("{0,10}  {1,10}  {2,3}  {3,46} ",
        heading[0], heading[1], heading[2], heading[3]);


for (int i = 1; i < csvLines.Length; i++)
{
    string[] data = csvLines[i].Split(',');
    
    String output = String.Format("{0,-13}  {1,-13}  {2,-30}  {3}", data[0], data[1], data[2], data[3]);
    Console.WriteLine(output);
}
Console.Write("Enter boarding bus stop: ");
board = Console.ReadLine();
Console.Write("Enter alighting bus stop: ");
alight = Console.ReadLine();
for (int i = 1; i < csvLines.Length; i++)
{
    string[] data = csvLines[i].Split(',');
    if (board == data[1])
    {
        board1 = Convert.ToDouble(data[0]);
    }
    if (alight == data[1])
    {
        board2 = Convert.ToDouble(data[0]);
    }
}
double distance = board2 - board1;
Console.WriteLine("Distance travelled: " + distance + "km");
csvLines = File.ReadAllLines("distance-based-fare.csv");
for (int i = 1; i < csvLines.Length; i++)
{
    string[] travel = csvLines[i].Split(',');
    double dist = Convert.ToDouble(travel[0]);
    if (distance <= dist)
    {
        cost = Convert.ToDouble(travel[1]);
        break;
    }
}
Console.WriteLine("Fare to pay: $" + (cost / 100));
Console.WriteLine($"Estimated duration: {distance * 4:F0} mins");

