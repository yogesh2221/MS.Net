using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class Program
    {

        public static int myKey = 1;

        static void Main1()
        {
            SortedList<int, Employee> employeeList = new SortedList<int, Employee>();

            

            int x = 0;
            do
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("Enter your choice 1> Add Employee  2> Show Employee 3> Exit  4>Get Employee");
                Console.WriteLine("===============================================================");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter name");
                            string name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter salary");
                            decimal salary = Convert.ToDecimal(Console.ReadLine());
                            employeeList.Add(myKey, new Employee(name, salary));
                            myKey = myKey + 1;
                            break;
                        }
                        

                    case 2:
                        {
                            foreach (KeyValuePair<int, Employee> employee in employeeList)
                            {
                                employee.Value.getEmployees();
                            }
                            break;
                        }
                       

                    case 3:
                        {
                            x = x + 1;
                            Console.WriteLine("thank you :)");
                            Console.WriteLine("=============================================");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter EmpNo");
                            int empNO = Convert.ToInt32(Console.ReadLine());

                            foreach(KeyValuePair<int ,Employee> emp in employeeList)
                            {
                                emp.Value.getEmployee(empNO);
                            }
                            break;
                        }
                        

                    default:
                        {
                            break;
                        }
                }

            } while (x == 0);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private static int empNO = 1;
        private int EmpNO { set; get; }
        private string EmpName { set; get; }
        private decimal BasicSalary { set; get; }

        public Employee(string EmpName,decimal BasicSalary)
        {
            this.EmpNO = empNO;
            empNO = empNO + 1;
            this.EmpName = EmpName;
            this.BasicSalary = BasicSalary;
        }

        public void getEmployees()
        {
            Console.WriteLine("Employee Number  :  " + EmpNO);
            Console.WriteLine("Employee Name    :  " + EmpName);
            Console.WriteLine("Employee Salary  :  " + BasicSalary);
            Console.WriteLine("=============================================");
        }
       
        public void getEmployee(int empno)
        {
            if(empno == this.EmpNO)
            {
                Console.WriteLine("Employee Number  :  " + EmpNO);
                Console.WriteLine("Employee Name    :  " + EmpName);
                Console.WriteLine("Employee Salary  :  " + BasicSalary);
                Console.WriteLine("=============================================");
            }

        }

    }
}

namespace Assignment4_2
{
    class Program
    {
        public static void Main2()
        {
            Employee[] arr = new Employee[2];

            Employee obj1 = new Employee("payal",50560);
            Employee obj2 = new Employee("pallavi",76468);

            arr[0] = obj1;
            arr[1] = obj2;

            /*foreach(Employee e in arr)
            {
                e.getEmployees();
            }*/


            //array to list

            //1 approach
            //List<Employee> list1 = new List<Employee>(arr);

            //2 approach
            // List<Employee> list1 = arr.ToList<Employee>();

            //3 approach
            List<Employee> list1 = new List<Employee>();
            list1.AddRange(arr);


            foreach (Employee e in list1)
            {
               e.getEmployees();
            }

            Console.ReadLine();
        }

    }

    public class Employee
    {
        private static int empNO = 1;
        private int EmpNO { set; get; }
        private string EmpName { set; get; }
        private decimal BasicSalary { set; get; }


        public Employee()
        {

        }
        public Employee(string EmpName, decimal BasicSalary)
        {
            this.EmpNO = empNO;
            empNO = empNO + 1;
            this.EmpName = EmpName;
            this.BasicSalary = BasicSalary;
        }

        public void getEmployees()
        {
            Console.WriteLine("Employee Number  :  " + EmpNO);
            Console.WriteLine("Employee Name    :  " + EmpName);
            Console.WriteLine("Employee Salary  :  " + BasicSalary);
            Console.WriteLine("=============================================");
        }

    }
}

namespace Assignment4_3
{


    class Program
    {
        public static void Main()
        {

            List<Employee> list = new List<Employee>();

            list.Add(new Employee("payal", 50560));
            list.Add(new Employee("pallavi", 19748));
            list.Add(new Employee("sakshi", 76468));
           


            //list to array

            Employee[] arr = new Employee[list.Count];

            arr = list.ToArray();

            foreach (Employee e in arr)
            {
                e.getEmployees();
            }

            Console.ReadLine();
        }

    }

    public class Employee
    {
        private static int empNO = 1;
        private int EmpNO { set; get; }
        private string EmpName { set; get; }
        private decimal BasicSalary { set; get; }


        public Employee()
        {

        }
        public Employee(string EmpName, decimal BasicSalary)
        {
            this.EmpNO = empNO;
            empNO = empNO + 1;
            this.EmpName = EmpName;
            this.BasicSalary = BasicSalary;
        }

        public void getEmployees()
        {
            Console.WriteLine("Employee Number  :  " + EmpNO);
            Console.WriteLine("Employee Name    :  " + EmpName);
            Console.WriteLine("Employee Salary  :  " + BasicSalary);
            Console.WriteLine("=============================================");
        }

    }

}
