namespace prog_icetask2
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentNumber { get; set; }
        public int Marks { get; set; }

        public Student(string studentName, string studentNumber, int marks)
        {
            StudentName = studentName;
            StudentNumber = studentNumber;
            Marks = marks;
        }
    }
}