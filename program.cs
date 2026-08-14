using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace prog_icetask2
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Student Report System...");
            Console.WriteLine();

            await LoadStudentData();

            Console.WriteLine();

            await GenerateStudentReport();

            Console.WriteLine();
            Console.WriteLine("Student report completed.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static async Task LoadStudentData()
        {
            Console.WriteLine("Loading student data...");

            await Task.Delay(2000);

            students.Add(new Student("Lefa", "ST001", 78));
            students.Add(new Student("Thabo", "ST002", 65));
            students.Add(new Student("Mpho", "ST003", 82));
            students.Add(new Student("Kagiso", "ST004", 91));
            students.Add(new Student("Naledi", "ST005", 74));

            Console.WriteLine("Student data loaded successfully.");
        }

        static async Task GenerateStudentReport()
        {
            Console.WriteLine("Generating student report...");

            await Task.Delay(3000);

            Console.WriteLine("Report generated successfully.");
            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student.StudentName}");
                Console.WriteLine($"Student Number: {student.StudentNumber}");
                Console.WriteLine($"Marks: {student.Marks}");
                Console.WriteLine();
            }
        }
    }
}