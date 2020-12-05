using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    /*3. Create a struct Student with the following properties. Put in appropriate validations.
        string Name
        int RollNo
        decimal Marks
        Create a parameterized constructor.
        Create an array to accept details for 5 students
    */

    struct Student
    {
        private int RollNo;
        private string Name;
        private decimal Marks;


        public Student(int rollNo = 10, string name = "xyz", decimal marks = 90)
        {
            this.RollNo = 0;
            this.Name = "";
            this.Marks = 0;
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        public int rollNo
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid RollNo. !!!...");
                else
                    RollNo = value;
            }

            get { return RollNo; }
        }

        public string name
        {
            set
            {
                if (Equals(value, ""))
                    Console.WriteLine("Invalid Name !!!...");
                else
                    Name = value;
            }

            get { return Name; }
        }

        public decimal marks
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid Marks !!!...");
                else
                    Marks = value;
            }

            get { return Marks; }
        }


    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Students Array \n");
            Student[] student = new Student[5];
            Console.WriteLine("Enter 5 Students Details : \n");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("======== Student-" + (i + 1) + "========");
                Console.Write("RollNo. : ");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Marks : ");
                decimal marks = Convert.ToDecimal(Console.ReadLine());

                student[i] = new Student(rollno, name, marks);

            }

            for (int i = 0; i < student.Length; i++)
                Console.WriteLine("\nRoll NO: " + student[i].rollNo + "\nName: " + student[i].name + "\nMarks: " + student[i].marks);

            Console.ReadLine();
        }
    }

}
