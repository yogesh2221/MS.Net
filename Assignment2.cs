using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            GeneralManager g = new GeneralManager("payal", 10, 30200, "manager", "xyz");

            Console.WriteLine(g.EMPNAME + "  " + g.EMPNO + "  " + g.DEPTNO + "  " + g.DESIGNATION +"  "+ g.BASICSALARY);

            GeneralManager g1 = new GeneralManager("atul", 20, 40500, "dev", "ppp");

            Console.WriteLine(g1.EMPNAME + "  " + g1.EMPNO + "  " + g1.DEPTNO + "  " + g1.DESIGNATION + "  " + g1.BASICSALARY);

            Console.ReadLine();

        }
    }

    public abstract class Employee
    {
        private string empName;
        private static int empNo;
        private short deptNO;
        private decimal basicSalary;


        //properties
        public string EMPNAME
        {
            set {
                //if (empName.Length <= 0)

                        empName = value;
               // else
                 //       Console.WriteLine("name is blank");
            }

            get { return empName; }
        }

        public int EMPNO
        {
            set {
                empNo = value;
                empNo = empNo + 1;
            }
            get { return empNo; }
        }

        public short DEPTNO
        {
            set {
                //if (deptNO > 0)
                    deptNO = value;
                //else
                  //  Console.WriteLine("dept is not correct");
            }

            get { return deptNO; }
        }
        public decimal BASICSALARY
        {
            set { basicSalary = value; }
            get { return basicSalary; }
        }

        public Employee(string empName, short deptNO, decimal basicSalary)
        {
            this.EMPNAME = empName;
            this.EMPNO = empNo;
            this.DEPTNO = deptNO;
            this.BASICSALARY = basicSalary;
        }


        public abstract decimal CalcNetSalary();
    }

    public class Manager : Employee
    {
        private string designation;
        public string DESIGNATION
        {
            set { designation = value; }
            get { return designation; }
        }


        public Manager(string empName, short deptNO, decimal basicSalary, string designation) : base(empName, deptNO, basicSalary)
        {

            this.DESIGNATION = designation;
        }


        private decimal netSalary;

        public override decimal CalcNetSalary()
        {
            return netSalary;
        }

    }

    public class GeneralManager : Manager{

        private string perks;

        private string PERKS
        {
            set { perks = value; }
            get { return perks; }
        }

        public GeneralManager(string empName, short deptNO, decimal basicSalary, string designation, string perks) : base(empName, deptNO, basicSalary,designation)
        {
            this.PERKS = perks;
        }

    }

    public class CEO : Employee
    {
        private decimal netSalary;

        private string designation;
        public string DESIGNATION
        {
            set { designation = value; }
            get { return designation; }
        }

        public CEO(string empName, short deptNO, decimal basicSalary,string designation) : base(empName, deptNO, basicSalary)
        {

            this.DESIGNATION = designation;
        }

        public sealed override decimal CalcNetSalary()
        {
            return netSalary;
        }

    }

}
