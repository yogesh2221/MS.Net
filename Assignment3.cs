using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    class Program
    {
        static void Main1(string[] args)
        {
            
            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                string name;
                Console.WriteLine("Enter your name");
                name = Convert.ToString(Console.ReadLine());

                decimal salary;
                Console.WriteLine("Enter your salary");
                salary = Convert.ToDecimal(Console.ReadLine());

                Employee employee = new Employee(name, salary);
                employees[i] = employee;
            }

            Console.WriteLine("Enter your choice 1>List of Emplyees  2>Get Employee  3>exit  4>highest salary");
            int ch;
            ch = Convert.ToInt32(Console.ReadLine());

            Boolean exit = true;
          //  do
            //{      
                switch (ch)
                {
                    case 3:
                        exit = false;
                        break;

                    case 1:

                        foreach (Employee e in employees)
                        {
                            e.ListOfEmployees();
                            
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter EmpNo ");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        
                        foreach (Employee e in employees)
                        {
                            e.getEmployee(empno);
                            
                        }
                        break;
                    
                    case 4 :
                        foreach (Employee e in employees)
                        {
                            e.highestSalary(employees);

                        }
                        break;

                default:

                        Console.WriteLine("wrong choice");
                        break;


                }

            //} while ( exit == true );

            

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private static int empNO = 1;

        private int EmpNO
        {
            get;
            set;
        }
        private string EmpName
        {
            set;
            get;
        }
        private decimal EmpSalary
        {
            set;
            get;
        }

        public Employee()
        {

        }
        public Employee(string EmpName, decimal EmpSalary)
        {
            this.EmpNO = empNO;
            empNO = empNO + 1;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;

        }


        public void ListOfEmployees()
        {
            Console.WriteLine("Employee Number  :  " + EmpNO);
            Console.WriteLine("Employee Name    :  " + EmpName);
            Console.WriteLine("Employee Salary  :  " + EmpSalary);
            Console.WriteLine("=========================================");
        }


        public void getEmployee(int empNum)
        {
            if( EmpNO == empNum)
            {
                Console.WriteLine("Employee Number  :  " + EmpNO);
                Console.WriteLine("Employee Name    :  " + EmpName);
                Console.WriteLine("Employee Salary  :  " + EmpSalary);
            }
  
        }

        public void highestSalary(Employee [] employees )
        {
           
                
                Console.WriteLine("Employee Number  :  " + employees[2].EmpNO);
                Console.WriteLine("Employee Number  :  " + employees[2].EmpName);
                Console.WriteLine("Employee Number  :  " + employees[2].EmpSalary);
            

        }

    }
}


namespace Assignment3_2
{

    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine(" Enter the how many batches C-Dac has ");
            int batches;
            batches = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" Enter the how many student are in each batch ");
            int student;
            student = Convert.ToInt32(Console.ReadLine());

            float[,,] arr = new float[batches,student,1];

            for(int i = 0; i<batches; i++)
            {
                for(int j = 0; j<student; j++)
                {
                    for(int k = 0; k<1; k++)
                    {
                        Console.WriteLine("Enter the marks");
                        float marks = Convert.ToInt32(Console.ReadLine());
                        arr[i,j,k] = marks;
                    }
                }
            } 
            
            for(int i = 0; i<batches; i++)
            {
                for(int j = 0; j<student; j++)
                {
                    for(int k = 0; k<1; k++)
                    {
                        Console.WriteLine("Student from batch {0} and the id of student is {1} and he got  :  {2} marks ", i , j, arr[i,j,k]);           
                    }
                }
            }

            Console.ReadLine();
        }

    }


}

namespace Assignment3_3
{

    class Program
    {
        static void Main()
        {
            Student[] students = new Student[2];


            for(int i=0; i<students.Length; i++)
            { 
                Console.WriteLine("Enter Name");
                string name;
                name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Roll no");
                int rollno;
                rollno = Convert.ToInt32(Console.ReadLine()); 
                
                Console.WriteLine("Enter Marks");
                decimal marks;
                marks = Convert.ToInt32(Console.ReadLine());
                
                Student s = new Student(name,rollno,marks);
                students[i] = s ;
            }

            foreach(Student s in students)
            {
               s.getStudents();
            }

            Console.ReadLine();
        }
    }


    public struct Student{

        private string Name;
        private int RollNo;
        private decimal Marks;

        public Student(string Name, int RollNo, decimal Marks)
        {
            this.Name = Name;
            this.RollNo = RollNo;
            this.Marks = Marks;
        }

        public void getStudents()
        {
            Console.WriteLine( RollNo + "   " + Name + "  " + Marks );
        }
    }

}

