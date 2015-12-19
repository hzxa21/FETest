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

        public IList<Order> SubordinateList { get; set; }

        public virtual void Accept(Calculator c) { }
        public virtual void AcceptChildren(Calculator c) { }
    }

    public class Order
    {
        public double Time { get; set; }
        public Employee Subordinate { get; set; }
    }

    public class Director : Employee
    {

        
    }
    public class SeniorManager : Employee
    {


    }
    public class Manager : Employee
    {


    }
    public class Worker : Employee
    {


    }
}
