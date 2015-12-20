using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Calculator
    {
        public abstract void Calculate(Director e);
        public abstract void Calculate(SeniorManager e);
        public abstract void Calculate(Manager e);
        public abstract void Calculate(Worker e);


    }

    public class TotalSalaryCalculator : Calculator
    {
        private int _total;
        public int Invoke(Employee e)
        {
            _total = 0;
            e.Accept(this);
            return _total;
        }
        public override void Calculate(Director e)
        {
            if (e.WorkTime <= 30)
                _total += e.WorkTime*300;
            else
            {
                _total += 30*300 + (e.WorkTime - 30)*600;
            }
            e.AcceptChildren(this);
        }

        public override void Calculate(SeniorManager e)
        {
            if (e.WorkTime <= 40)
                _total += e.WorkTime * 200;
            else
            {
                _total += 40 * 200 + (e.WorkTime - 40) * 400;
            } 
            e.AcceptChildren(this);
        }

        public override void Calculate(Manager e)
        {
            if (e.WorkTime <= 40)
                _total += e.WorkTime * 150;
            else
            {
                _total += 40 * 150 + (e.WorkTime - 40) * 350;
            } e.AcceptChildren(this);
        }

        public override void Calculate(Worker e)
        {
            _total += e.WorkTime*100;
            e.AcceptChildren(this);
        }
    }

    public class ActualSalaryCalculator:Calculator
    {
        double _total;
        public double Invoke(Employee e)
        {
            _total = 0;
            e.Accept(this);
            return _total;
        }
        public override void Calculate(Director e)
        {
            int cur;
            if (e.WorkTime <= 30)
                cur = e.WorkTime * 300;
            else
            {
                cur = 30 * 300 + (e.WorkTime - 30) * 600;
            }
            _total += cur*0.8;
            e.AcceptChildren(this);
        }

        public override void Calculate(SeniorManager e)
        {
            int cur;
            if (e.WorkTime <= 40)
                cur = e.WorkTime * 200;
            else
            {
                cur = 40 * 200 + (e.WorkTime - 40) * 400;
            }
            _total += cur*0.85;
            e.AcceptChildren(this);
        }

        public override void Calculate(Manager e)
        {
            int cur;
            if (e.WorkTime <= 40)
                cur = e.WorkTime * 150;
            else
            {
                cur = 40 * 150 + (e.WorkTime - 40) * 350;
            }
            _total += cur*0.9;
            e.AcceptChildren(this);
        }

        public override void Calculate(Worker e)
        {
            _total += e.WorkTime * 100 * 0.95;
            e.AcceptChildren(this);
        }
    }

    public class TotalOtCalculator : Calculator
    {
        private int _total;

        public int Invoke(Employee e)
        {
            _total = 0;
            e.Accept(this);
            return _total;
        }

        public override void Calculate(Director e)
        {
            if (e.WorkTime > 30)
            {
                _total += e.WorkTime - 30;
            }
            e.AcceptChildren(this);
        }

        public override void Calculate(SeniorManager e)
        {
            if (e.WorkTime > 40)
            {
                _total += e.WorkTime - 40;
            }
            e.AcceptChildren(this);
        }

        public override void Calculate(Manager e)
        {
            if (e.WorkTime > 40)
            {
                _total += e.WorkTime - 40;
            }
            e.AcceptChildren(this);
        }

        public override void Calculate(Worker e)
        {
        }
    }
}
