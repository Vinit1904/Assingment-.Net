using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Employee o1 = new Employee("Amol", 7000, 10);
            Employee o2 = new Employee("Ram", 8000);
            Employee o3 = new Employee("Sham");*/
            //Employee o4 = new Employee();

            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine(o1.EmpNo+" "+o1.Basic);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.ReadLine();
        }
    }


    class Employee
    {
        #region Proporties
        private string name;

        public string Name
        {
            set
            {
                if (value !=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be Null");
                }
            }
            
            get
            {
                return name;
            }

        }


        private static int empCounter=0;

        private int empno;
        public  int EmpNo
        {
            /*set
            {
                empCounter++;
                Console.WriteLine("counter"+empCounter);

                //empno = autoEmpNo;
            }*/
            get
            {
                return empno;
            }
        }

        private int basic;
        public int Basic
        {
            set
            {
                if (value > 5000 && value < 20000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Basic is not Valid");
                }
            }

            get
            {
                return basic;
            }
        }


        private short deptno;

        public short DeptNo
        {
            set 
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("DeptNo is not Valid");
                }
            }
            get
            {
                return deptno;
            }
            
        }
        #endregion



        #region Constructor
        public Employee()
        {
            empCounter++;
            this.empno = empCounter;
            this.Name = "unknown";
            this.Basic = 5500;
            this.DeptNo = 10;
        }

        

        public Employee(string Name)
        {
            this.Name = Name;
            this.Basic = 5500;
            this.DeptNo = 10;

            empCounter++;
            this.empno = empCounter;

        }

        public Employee(string Name, int Basic)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = 10;

            empCounter++;
            
            this.empno = empCounter;


        }

        public Employee(string Name,int Basic,short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            
            empCounter++;
            this.empno = empCounter;


        }


        #endregion


        #region Method
        public int GetNetSal() 
        {
            int netSal;
            netSal = basic + 5000;
            return netSal;
        }

        #endregion


    }
}
