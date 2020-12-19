using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("payal", 44000, 20);
            Employee e2 = new Employee("atul", 35000, 10);
            Employee e3 = new Employee("pallu");

            Console.WriteLine(e1.EMPNO + " " + e1.EMPNAME + " " + e1.BASIC_SALARY + " " + e1.NET_SALARY + " " + e1.DEPTNO);
            Console.WriteLine(e2.EMPNO + " " + e2.EMPNAME + " " + e2.BASIC_SALARY + " " + e2.NET_SALARY + " " + e2.DEPTNO);
            Console.WriteLine(e3.EMPNO + " " + e3.EMPNAME + " " + e3.BASIC_SALARY + " " + e3.NET_SALARY + " " + e3.DEPTNO);
           

            Console.WriteLine("                             ");

            Console.WriteLine(e3.EMPNO);
            Console.WriteLine(e2.EMPNO);
            Console.WriteLine(e1.EMPNO);

            Console.ReadLine();

        }
    }
     
    class Employee
    {
        private string empName;
        private int empNo;
        private decimal basicSalary;
        private short deptNo;

        public static int empNO1 = 1;


        private decimal netSalary;
        

        public decimal getNetSalary()
        {
            
            return basicSalary - 300;
        
        }


        //===================================

        //properties
        public int EMPNO
        {
            get { return empNo; }
        }
        
        public string EMPNAME
        {
            get { return empName; }
        }
        
        public decimal BASIC_SALARY
        {
            get { return basicSalary; }
        }
        
        public short DEPTNO
        {
            get { return deptNo; }
        }
        
        public decimal NET_SALARY
        {
            get { return netSalary; }
        }

        //============================================

        //Contructors

        public Employee()
        {

        }

        public Employee(string empName)
        {
            this.empNo = empNO1;
            empNO1 = empNO1 + 1;
            this.empName = empName;
            this.basicSalary = 40000;
            this.deptNo = 20;
            decimal result = getNetSalary();
            this.netSalary = result;

        }
        public Employee(string empName,decimal basicSalary)
        {
            this.empNo = empNO1;
            empNO1 = empNO1 + 1;
            this.empName = empName;
            if (basicSalary >= 30000 && basicSalary <= 50000)
            {

                this.basicSalary = basicSalary;
            }
            else
            {
                Console.WriteLine("invalid salary");
            }
            this.deptNo = 10;
            decimal result = getNetSalary();
            this.netSalary = result;

        }
        public Employee(string empName,decimal basicSalary, short deptNo)
        {
            this.empNo = empNO1;
            empNO1 = empNO1 + 1;
            this.empName = empName;

            if(basicSalary >= 30000 && basicSalary <= 50000)
            {

                this.basicSalary = basicSalary;
            }
            else
            {
                Console.WriteLine("invalid salary");
            }

            decimal result = getNetSalary();
            this.netSalary = result;
            if (deptNo > 0)
            {
                this.deptNo = deptNo; 
            }
            else
            {
                Console.WriteLine("invalid dept No");
            }

        }

    }
}
