using System;

namespace Lab2_3
{
    class Employee
    {
        public string name;
        public string surname;
        public static string dateOfHire;
        public OperateCost operationCost;


        public Employee(string name, string surname, string dateOfHire, OperateCost opCost)
        {
            this.name = name;
            this.surname = surname;
            Employee.dateOfHire = dateOfHire;
            this.operationCost = opCost;

        }
        public static double DiscoverGrade(string dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.1;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.5;
        }
    }
    abstract class OperateCost
    {
        public double salary;
        public double tax;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
    }

    class First : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 2 * bonus) * grade;
        }

        public override void ApplyTax()
        {
            tax = salary * 0.3;
        }
    }

    class Second : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (20000 + 5 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.4;
        }
    }

    class Third : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (33000 + 10 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperateCost oc = new Second();
            Employee emp = new Employee("Vitaliy", "Rozumenko", "10.01.1998", oc);
            double grade = Employee.DiscoverGrade("10.01.1998");
            Console.WriteLine("Name: {0}, Surname: {1}, Date of Hire: {2}, Position: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
            oc.ApplyBonus(25000, grade);
            oc.ApplyTax();
            Console.WriteLine("Salary: {0}, Tax: {1}", emp.operationCost.salary, emp.operationCost.tax);
            Console.ReadKey();
        }
    }
}