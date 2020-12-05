using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee m1= new Manager("ram",3,6000,"Manager");
            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine("empNo "+ m1.EmpNo);

            Employee m2 = new Manager("sham", 9, 8000, "Manager");
            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("empNo " + m2.EmpNo);


            Employee m3 = new Manager("Allen", 9, 10000, "Manager");
            Console.WriteLine(m3.CalcNetSalary());
            Console.WriteLine("empNo " + m3.EmpNo);

            Console.WriteLine(m3.CalcNetSalary());
            Console.WriteLine("empNo " + m3.EmpNo);

            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("empNo " + m2.EmpNo);

            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine("empNo " + m1.EmpNo);
            */

            /*Employee m1 = new GeneralManager("ram", 2, 80000);
            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine("empNo " + m1.EmpNo);

            Employee m2 = new GeneralManager("Sham", 3, 90000);
            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("empNo " + m2.EmpNo);

            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("empNo " + m2.EmpNo);

            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine("empNo " + m1.EmpNo);
            */

            Employee m2 = new GeneralManager("Sham", 3, 90000);
            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("empNo " + m2.EmpNo);



            Console.ReadLine();
        }
    }


    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public abstract class Employee
    {
        #region Properties

        private string name;
        public string Name
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should Not Be Blank");
                }
            }
            get
            {
                return name;
            }
        }

        private static int EmpNoCounter = 0;
        private int empno;
        public int EmpNo
        {
            get
            {
                return empno;
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
                    Console.WriteLine("Invalid Dept No");
                }
            }

        }

        protected decimal basic;
        public abstract decimal Basic
        {
            set;
            get;

        }

        #endregion


        #region Constructor
        public Employee(string Name = "unknown", short DeptNo = 10, decimal Basic = 5500)
        {
            EmpNoCounter++;
            empno = EmpNoCounter;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;

        }
        #endregion

        #region AbstractMethod
        public abstract decimal CalcNetSalary();
        #endregion

    }

    public class Manager : Employee,IDbFunctions
    {
        #region Properties
        public override decimal Basic
        {
            set
            {
                if (value > 5000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Manager Basic Should not be less than 5000");
                }
            }
            get
            {
                return basic;
            }
        }


        private string designation;

        public string Designation
        {
            set
            {
                if (value != "")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Blank Entry not Allowed");
                }
            }

            get
            {
                return designation;
            }
        }
        #endregion


        #region Constructor

        public Manager(string Name = "unkown", short DeptNo = 10, decimal Basic = 5500, string Designation = "Manager") : base(Name, DeptNo, Basic)
        {
            //this.Basic = Basic;
            this.Designation = Designation;
        }
        #endregion


        #region Method
        public override decimal CalcNetSalary()
        {

            return Basic + 4000;

        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }
        #endregion
    }



    public class GeneralManager : Manager,IDbFunctions
    {
        #region Properties
        public override decimal Basic
        {

            set
            {
                if (value > 700)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Manager Basic Should not be less than 7000");
                }
            }
            get
            {
                return basic;
            }
        }


        private string perks;

        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

        #endregion


        #region Constructor
        public GeneralManager(string Name = "unknown", short DeptNo = 10, decimal Basic = 7500, string Designation = "GeneralManager", string perks = "Two") : base(Name, DeptNo, Basic, Designation)
        {
            //this.Basic = Basic;
            //this.Designation = Designation;
            this.Perks = Perks;
        }

        #endregion



        #region Method
        public override decimal CalcNetSalary()
        {
            return Basic + 5000;
        }
        #endregion
    }

    public class CEO : Employee,IDbFunctions
    {
        public override decimal Basic
        {
            set
            {
                if (value > 12000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Manager Basic Should not be less than 12000");
                }
            }
            get
            {
                return basic;
            }
        }

        public CEO(string Name = "unknown", short DeptNo = 10, decimal Basic = 12000) : base(Name, DeptNo, Basic)
        {

        }

        public sealed override decimal CalcNetSalary()
        {
            return Basic + 10000;
        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }
    }




}

