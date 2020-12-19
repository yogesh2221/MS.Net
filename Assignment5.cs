using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    class Program
    {
        static void Main1(string[] args)
        {

            Func<decimal, decimal, decimal, decimal> simpleIntrest = (decimal P, decimal R, decimal N) =>
              {
                  decimal result = (P * N * R) / 100;
                  return result;

              };

          //  Func<decimal, decimal, decimal, decimal> simpleIntrest = (decimal P, decimal R, decimal N) => (P * N * R) / 100;

            Console.WriteLine(simpleIntrest(1000, 9, 2));
            Console.ReadLine();
        }
    }

   
}

namespace IsGreater
{
    class program
    {
        public static void Main2()
        {
/*            Func<int, int, bool> isGreater = (int a, int b) =>
            {
                if (a > b)
                    return true;
                else
                    return false;
            };*/

            Func<int, int, bool> isGreater = (int a, int b) => a > b;
             
            Console.WriteLine(isGreater(20, 10));
            Console.ReadLine();
        }
    }

}

namespace BasicSalary
{
    class program
    {
        public static void Main3()
        {
            Employee e1 = new Employee();

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(){EmpNO = 1, EmpName = "payal", BasicSalary = 36000 });
            empList.Add(new Employee(){EmpNO = 2, EmpName = "atul", BasicSalary = 39000 });
            empList.Add(new Employee(){EmpNO = 3, EmpName = "pallu", BasicSalary = 38000 });


            /* Func<Employee, decimal> getBasic = (Employee e) =>
             {
                 decimal basic = e.BasicSalary;
                 return basic;
             };*/

            Func<Employee, decimal> getBasic = (Employee e) => e.BasicSalary;

            Console.WriteLine("Basic salary : " + getBasic(empList.ElementAt(2)));
            Console.ReadLine();
        }

    }

    public class Employee
    {
        public int EmpNO{ set; get; }
        public string EmpName{ set; get; }
        public decimal BasicSalary{ set; get; }

    }

}

namespace IsEvenNumber
{
    class program
    {
        public static void Main4()
        {
            /*            Func<int, bool> isEven = (int b) =>
                        {
                            if (b % 2 == 0)
                                return true;
                            else
                                return false;
                        };*/

            Func<int, bool> isEven = (int b) => b % 2 == 0;

           Console.WriteLine(isEven(53));
            Console.ReadLine();
        }
    }

}

namespace GreaterBasicSalary
{
    class program
    {
        public static void Main()
        {
            Employee e1 = new Employee();

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { EmpNO = 1, EmpName = "payal", BasicSalary = 36000 });
            empList.Add(new Employee() { EmpNO = 2, EmpName = "atul", BasicSalary = 39000 });
            empList.Add(new Employee() { EmpNO = 3, EmpName = "pallu", BasicSalary = 38000 });


            /*            Func<Employee, bool> getBasic = (Employee e) =>
                        {
                            if (e.BasicSalary > 10000)
                                return true;
                            else
                                return false;
                        };*/

            Func<Employee, bool> getBasic = (Employee e) => e.BasicSalary > 10000;

            Console.WriteLine(getBasic(empList.ElementAt(0)));
            Console.ReadLine();
        }

    }

    public class Employee
    {
        public int EmpNO { set; get; }
        public string EmpName { set; get; }
        public decimal BasicSalary { set; get; }

    }

}