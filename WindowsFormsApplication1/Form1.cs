using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<int, Employee> _employeeDict;
        private readonly Dictionary<int, bool> _employeeHasBoss;
        private int _headId;
        private static readonly Dictionary<string, int> PositionbLevel = new Dictionary<string, int>
        {
            {"Director" , 0},
            {"SeniorManager" , 1},
            {"Manager" , 2},
            {"Worker" , 3},
        };

        private Dictionary<Employee, int> _nodeOffset; 
        public Form1()
        {
            InitializeComponent();
            _employeeDict = new Dictionary<int, Employee>();
            _employeeHasBoss = new Dictionary<int, bool>();
            _headId = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddEmployee(object sender, EventArgs e)
        {
            bool valid = true;
            if (!employeeId.Text.Any())
            {
                OutputBox.AppendText("Please input a employee id.\n");
                valid = false;
            }
            if (employeeTypes.SelectedIndex < 0)
            {
                OutputBox.AppendText("Please select a employee type.\n");
                valid = false;
            }
            if (!employeeName.Text.Any())
            {
                OutputBox.AppendText("Please input the name of the employee you want to add.\n");
                valid = false;
            }
            if (!employeeWorkTime.Text.Any())
            {
                OutputBox.AppendText("Please input the work time of the employee you want to add.\n");
                valid = false;
            }

            if (!valid)
                return;

            string name = employeeName.Text;
            int id = Convert.ToInt32(employeeId.Text);
            int workTime = Convert.ToInt32(employeeWorkTime.Text);
            if (id < 0)
            {
                OutputBox.AppendText("Id should not less than 0");
            }
            if (_employeeDict.ContainsKey(id))
            {
                OutputBox.AppendText("Id already exists.\n");
                return;
            }
            AddEmployee(employeeTypes.SelectedItem.ToString(), id, name, workTime);
        }

        private void AddEmployee(string type, int id, string name, int workTime)
        {
            switch (type)
            {
                case "Director":
                    {
                        if (_headId < 0)
                            _headId = id;
                        else
                        {
                            OutputBox.AppendText("Only one Director can be added");
                            return;
                        }
                        _employeeDict.Add(id, new Director(name, workTime));
                        break;
                    }
                case "Senior Manager":
                    {
                        _employeeDict.Add(id, new SeniorManager(name, workTime));
                        _employeeHasBoss.Add(id, false);
                        break;
                    }
                case "Manager":
                    {
                        _employeeDict.Add(id, new Manager(name, workTime));
                        _employeeHasBoss.Add(id, false);
                        break;
                    }
                case "Worker":
                    {
                        _employeeDict.Add(id, new Worker(name, workTime));
                        _employeeHasBoss.Add(id, false);
                        break;
                    }
            }
            _employeeHasBoss[id] = false;
            OutputBox.AppendText(string.Format("Add a {0} (ID:{1}, Name:{2}, WorkTime:{3}).\n", type, id, name, workTime));
        }

        private void AddRelationship(int src, int sink)
        {
            bool valid = true;
            Employee srcEmployee, sinkEmployee;
            if (!_employeeDict.TryGetValue(src, out srcEmployee))
            {
                OutputBox.AppendText("Superior ID not exists.\n");
                valid = false;
            }
            if (!_employeeDict.TryGetValue(sink, out sinkEmployee))
            {
                OutputBox.AppendText("Subordinate ID not exists.\n");
                valid = false;
            }
            if (sink == _headId)
            {
                OutputBox.AppendText("Director cannot have a boss.\n");
                valid = false;
            }
            if (!valid)
                return;
            if (PositionbLevel[srcEmployee.GetType().Name] >= PositionbLevel[sinkEmployee.GetType().Name])
            {
                OutputBox.AppendText("Invalid relationship.\n");
                return;
            }

            srcEmployee.SubordinateList.Add(sinkEmployee);
            _employeeHasBoss[sink] = true;
            OutputBox.AppendText(string.Format("Add relationship from ID {0} to ID {1}.\n", src, sink));
        }

        private void addRelationship_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (!srcId.Text.Any())
            {
                OutputBox.AppendText("Please input a superior id.\n");
                valid = false;
            }
            if (!sinkId.Text.Any())
            {
                OutputBox.AppendText("Please input a subordinate id.\n");
                valid = false;
            }
            if (!valid)
                return;
            int src = Convert.ToInt32(srcId.Text);
            int sink = Convert.ToInt32(sinkId.Text);
            AddRelationship(src, sink);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
        }

        private void printTree_Click(object sender, EventArgs e)
        {
            if (_headId < 0)
            {
                OutputBox.AppendText("No head found.\n");
                return;
            }
            else if (_employeeHasBoss.Count(k => k.Value) != _employeeHasBoss.Count - 1)
            {
                OutputBox.AppendText("The tree is incomplete. All the employees except the Diector should have a boss.\n");
                return;
            }
            var head = _employeeDict[_headId];
            _nodeOffset = new Dictionary<Employee, int>();
            _nodeOffset[head] = GetPrintTreeOffset(head, 0);
            PrintTree(head);
        }



        private int GetPrintTreeOffset(Employee employee, int curOffset)
        {
            int offset = curOffset-8;
            if (employee.SubordinateList.Count == 0)
            {
                offset = (int) (curOffset + employee.Name.Length);
                _nodeOffset[employee] = offset;
                return offset;
            }
            foreach (var next in employee.SubordinateList)
            {
                offset = GetPrintTreeOffset(next, offset + 8);
            }
            offset = (int) Math.Ceiling((offset+curOffset)/2.0 + employee.Name.Length/2.0);
            _nodeOffset[employee] = offset;
            return offset;
        }

        private void PrintTree(Employee head)
        {
            Queue<Employee> q = new Queue<Employee>();
            q.Enqueue(head);
            int preLevel = 1;
            int nextLevel = 0;
            int preWidth = 0;
            int preBegin = 0;
            string line1, line2,line3, line4;
            line1 = line2 = line3 = line4 = "";
            while (q.Count != 0)
            {
                var e = q.Dequeue();
                bool hasNext = e.SubordinateList.Any();
                int width = _nodeOffset[e];
                string format = "";
                
                for (int i = 0; i < width - preWidth - e.Name.Length; i++)
                    format += " ";
                line2 += format + e.Name;

                format = "";
                for (int i = preBegin; i < width - e.Name.Length; i++)
                    format += " ";
                line1 += format + "|";
                line3 += format + (hasNext ? "|" : " ");
                if (hasNext)
                {
                    int begin = _nodeOffset[e.SubordinateList.First()]-e.SubordinateList.First().Name.Length;
                    int end = _nodeOffset[e.SubordinateList.Last()]-e.SubordinateList.Last().Name.Length;
                    int ii = line4.Length;
                    for (; ii < begin; ii++)
                        line4 += " ";
                    for (; ii <= end; ii++)
                        line4 += "-";
                }
                foreach (var next in e.SubordinateList)
                {
                    q.Enqueue(next);
                }

                preLevel--;
                nextLevel += e.SubordinateList.Count;
                preWidth = width;
                preBegin = width - e.Name.Length+1;
                if (preLevel == 0)
                {
                    if (e != head)
                        OutputBox.AppendText(line1 + "\n");
                    OutputBox.AppendText(line2 + "\n");
                    OutputBox.AppendText(line3 + "\n");
                    OutputBox.AppendText(line4 + "\n");

                    preLevel = nextLevel;
                    nextLevel = 0;
                    preWidth = 0;
                    preBegin = 0;
                    line1 = line2 = line3 = line4 = "";
                }

            }

        }

        private void LoadEmployeeMenu_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(@"C:\Users\v-zhah\Source\Repos\FETest\WindowsFormsApplication1\employee.txt",Encoding.Default);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var subStr = line.Split(',');
                int id = Convert.ToInt32(subStr[0]);
                string type = subStr[1];
                string name = subStr[2];
                int workTime = Convert.ToInt32(subStr[3]);
                AddEmployee(type, id, name, workTime);
            }
            sr.Close();
        }

        private void loadRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(@"C:\Users\v-zhah\Source\Repos\FETest\WindowsFormsApplication1\relationship.txt", Encoding.Default);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var subStr = line.Split(',');
                int src = Convert.ToInt32(subStr[0]);
                int sink = Convert.ToInt32(subStr[1]);
                AddRelationship(src, sink);
            }
            sr.Close();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            if (calculatorTypes.GetItemChecked(0))
            {
                var c = new TotalOtCalculator();
                var res = c.Invoke(_employeeDict[_headId]);
                OutputBox.AppendText(string.Format("Total Overtime on work is {0}\n", res));
            }
            if (calculatorTypes.GetItemChecked(1))
            {
                var c = new TotalSalaryCalculator();
                var res = c.Invoke(_employeeDict[_headId]);
                OutputBox.AppendText(string.Format("Total salary is {0}\n", res));
            }
            if (calculatorTypes.GetItemChecked(2))
            {
                var c = new ActualSalaryCalculator();
                var res = c.Invoke(_employeeDict[_headId]);
                OutputBox.AppendText(string.Format("Actual salary is {0}\n", res));
            }
        }

    }
}
