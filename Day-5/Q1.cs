using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingement_3_Q_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee[] objArr = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Employee Details:");
                Console.WriteLine("EmpName:");
                string name=Console.ReadLine();
                Console.WriteLine("Salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());
                objArr[i] = new Employee(name,salary);                
            }

            /*foreach (Employee a in objArr)
            {
                Console.WriteLine(a.EmpNo);
                Console.WriteLine(a.Name);
                Console.WriteLine(a.Salary);
            }*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Employee With Highest Salary");
            decimal maxSalary=0;
            
            
            foreach (Employee a in objArr)
            {
                if (a.Salary > maxSalary)
                {
                    maxSalary = a.Salary;
                }
            }
            foreach (Employee a in objArr)
            {
                if (a.Salary == maxSalary)
                {
                    Console.WriteLine(a.EmpNo);
                    Console.WriteLine(a.Name);
                    Console.WriteLine(a.Salary);

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Employee Search using Id");
            int id = Convert.ToInt32(Console.ReadLine());

         
                
            
            foreach (Employee a in objArr)
            {
                if (a.EmpNo == id)
                {
                    Console.WriteLine(a.EmpNo);
                    Console.WriteLine(a.Name);
                    Console.WriteLine(a.Salary);

                }
            }


            Console.ReadLine();
        }
    }


    class Employee
    {
        #region Properties
        public static int empNoCounter=0;
        private int empno;

        public int EmpNo
        {
            get 
            {
                return empno;
            }
        }

        private string name;

        public string Name
        {
            set 
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private decimal salary;
        public decimal Salary 
        {
            set 
            {
                salary = value;
            }
            get 
            {
                return salary;
            }
        }
        #endregion


        #region Constructor
        public Employee(string Name="unknown",decimal Salary=5000)
        {
            empNoCounter++;
            empno = empNoCounter;
            this.Name = Name;
            this.Salary = Salary;

        }

        #endregion
    }
}
