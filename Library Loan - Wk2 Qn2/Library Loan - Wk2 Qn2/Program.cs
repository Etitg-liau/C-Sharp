// See https://aka.ms/new-console-template for more information
using System.IO;

string[] csvLines = File.ReadAllLines("loaninfo.csv");
string[] heading = csvLines[0].Split(',');
Console.WriteLine("{0,0}  {1,12}  {2,10}  {3,10}  {4,10}  {5,5}  {6,0}",
        heading[0], heading[1], heading[2], heading[3], "Days Loan", "Days Overdue", "Fine");
string overdue;
string fine;
for (int i = 1; i < csvLines.Length; i++)
{
    string[] data = csvLines[i].Split(',');
    DateTime borrowdate = Convert.ToDateTime(data[2]);
    DateTime duedate = Convert.ToDateTime(data[3]);
    int DateDiff = duedate.Subtract(borrowdate).Days;
    if (DateDiff > 14)
    {
        int overdueno = Convert.ToInt32(DateDiff - 14);
        
        overdue = Convert.ToString(overdueno);
    }
    else
    {
        overdue = null;
    }
    double overduedays = Convert.ToDouble(overdue);
    if (overduedays > 0)
    {
        double fineno = 0.5 * overduedays;
        fine = "$"+Convert.ToString(fineno)+"0";
    }   
    else
    {
        fine = null;
    }
    String output = String.Format("{0,-9} {1,-12} {2,-14} {3,-15} {4,-10} {5,-13} {6,0}", data[0], data[1], borrowdate.ToString("dd/MM/yyyy"), duedate.ToString("dd/MM/yyyy"), DateDiff, overdue, fine);
    Console.WriteLine(output);
}