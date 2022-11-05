using Practical_3___OOP;
using System.Collections.Generic;
using System.IO;
// Practical 3
// part a
DateTime dob1 = new DateTime(2000, 10, 13);
DateTime dob2 = new DateTime(2001, 11, 01);
DateTime dob3 = new DateTime(2000, 01, 03);
DateTime dob4 = new DateTime(2000, 05, 07);
DateTime dob5 = new DateTime(2000, 08, 09);


Student s1 = new Student(1, "John Tan", "88552211", dob1);
Student s2 = new Student(2, "Peter Lim", "85678141", dob2);
Student s3 = new Student(3, "David Chan", "88555461", dob3);
Student s4 = new Student(4, "Muhammed Faizal", "98762211", dob4);
Student s5 = new Student(5, "Esther Eng", "83352245", dob5);

// part b
Console.WriteLine("{0,-5} {1,-17} {2,-10} {3,0}", "ID", "Name", "Tel", "Date Of Birth");
String output1 = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", s1.Id, s1.name2, s1.Tel, s1.DateOfBirth.ToString("dd/MM/yyyy"));
String output2 = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", s2.Id, s2.name2, s2.Tel, s2.DateOfBirth.ToString("dd/MM/yyyy"));
String output3 = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", s3.Id, s3.name2, s3.Tel, s3.DateOfBirth.ToString("dd/MM/yyyy"));
String output4 = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", s4.Id, s4.name2, s4.Tel, s4.DateOfBirth.ToString("dd/MM/yyyy"));
String output5 = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", s5.Id, s5.name2, s5.Tel, s5.DateOfBirth.ToString("dd/MM/yyyy"));
Console.WriteLine(output1);
Console.WriteLine(output2);
Console.WriteLine(output3);
Console.WriteLine(output4);
Console.WriteLine(output5);

// part c
List <Student> studentList = new List <Student>();
studentList.Add(s1);
studentList.Add(s2);
studentList.Add(s3);
studentList.Add(s4);
studentList.Add(s5);

// part d
void DisplayOutput(List<Student> sList)
{
    foreach (Student student in sList)
    {
        String partd = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", student.Id, student.name2, student.Tel, student.DateOfBirth.ToString("dd/MM/yyyy"));
        Console.WriteLine(partd);
    }
}

DisplayOutput(studentList);

// part e
Student GetStudent()
{
    Console.Write("Enter your student ID: ");
    string studentID = Console.ReadLine();
    Console.Write("Enter your name: ");
    string name3 = Console.ReadLine();
    Console.Write("Enter your phone number: ");
    string phoneno = Console.ReadLine();
    Console.Write("Enter your dob: ");
    string dob = Console.ReadLine();
    return new Student(Convert.ToInt32(studentID), name3, phoneno, Convert.ToDateTime(dob));
}
studentList.Add (GetStudent());
DisplayOutput(studentList);

//part f
List < Student > studentList2 = new List < Student > ();
string[] csvLines = File.ReadAllLines("Students.csv");
string[] heading = csvLines[0].Split(',');
for (int i = 1; i < csvLines.Length; i++)
{
    // Console.WriteLine("{0,-5} {1,-17} {2,-10} {3,0}", heading[0], heading[1], heading[2], heading[3]);
    string[] studentfile = csvLines[i].Split(',');
    String outputfile = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", studentfile[0], studentfile[1], studentfile[2], studentfile[3]);
    Console.WriteLine (outputfile);
}
void newDisplayOutput(List<Student> stdList2)
{
    foreach(var data in stdList2)
    {
        String partf = String.Format("{0,-5} {1,-17} {2,-10} {3,0}", data.Id, data.name2, data.Tel, data.DateOfBirth.ToString("dd/MM/yyyy"));
        Console.WriteLine(partf);
    }

}
newDisplayOutput(studentList2);