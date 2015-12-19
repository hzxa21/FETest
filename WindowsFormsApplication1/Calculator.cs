using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Calculator
    {
        public abstract void Calculate(Employee e);
        public abstract void Calculate(Director e);

    }

    public class TotalCalculator : Calculator
    {
        public override void Calculate(Employee e)
        {
            Console.WriteLine("Employee");
        }

        public override void Calculate(Director e)
        {
            Console.WriteLine("Director");
        }
    }
}
