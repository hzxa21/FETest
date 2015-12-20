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

        public int WorkTime { get; set; }

        public IList<Employee> SubordinateList { get; set; }

        public virtual void Accept(Calculator c) { }
        public virtual void AcceptChildren(Calculator c) { }
    }

    public class Director : Employee
    {
        public Director(string name, int workTime)
        {
            Name = name;
            WorkTime = workTime;
            SubordinateList = new List<Employee>();
        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }

        public override void AcceptChildren(Calculator c)
        {
            foreach (var employee in SubordinateList)
            {
                employee.Accept(c);
            }
        }

    }
    public class SeniorManager : Employee
    {
        public SeniorManager(string name, int workTime)
        {
            Name = name;
            WorkTime = workTime;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
        public override void AcceptChildren(Calculator c)
        {
            foreach (var employee in SubordinateList)
            {
                employee.Accept(c);
            }
        }
    }
    public class Manager : Employee
    {
        public Manager(string name, int workTime)
        {
            Name = name;
            WorkTime = workTime;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
        public override void AcceptChildren(Calculator c)
        {
            foreach (var employee in SubordinateList)
            {
                employee.Accept(c);
            }
        }
    }
    public class Worker : Employee
    {
        public Worker(string name, int workTime)
        {
            Name = name;
            WorkTime = workTime;
            SubordinateList = new List<Employee>();

        }
        public override void Accept(Calculator c)
        {
            c.Calculate(this);
        }
        public override void AcceptChildren(Calculator c)
        {
            foreach (var employee in SubordinateList)
            {
                employee.Accept(c);
            }
        }
    }
}
