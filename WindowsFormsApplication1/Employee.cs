using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }


        //public IList<Subordinate> SubordinateList { get; set; }
        public IList<Employee> SubordinateList { get; set; }

        public virtual void Accept(Calculator c) { }
        public virtual void AcceptChildren(Calculator c) { }
    }

    //public class Subordinate
    //{
    //    public double Weight { get; set; }
    //    public Employee SubordinateEmployee { get; set; }
    //}

    public class Director : Employee
    {
        public Director(string name, int salary)
        {
            Name = name;
            Salary = salary;
            SubordinateList = new List<Employee>();
        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
    }
    public class SeniorManager : Employee
    {
        public SeniorManager(string name, int salary)
        {
            Name = name;
            Salary = salary;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
    }
    public class Manager : Employee
    {
        public Manager(string name, int salary)
        {
            Name = name;
            Salary = salary;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
    }
    public class Worker : Employee
    {
        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
    }
}
