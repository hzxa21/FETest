using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();
            employeeList = new List<Employee>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddEmployee(object sender, EventArgs e)
        {
            if (employeeTypes.SelectedIndex < 0)
                OutputBox.AppendText("Please select a employee type.\n");
            else if (!employeeName.Text.Any())
            {
                OutputBox.AppendText("Please enter the name of te employee you want to add.\n");
            }
            else
            {


                switch (employeeTypes.SelectedIndex)
                {
                    case 0:
                    {
                        employeeList.Add(new Director());
                        break;
                    }
                    case 1:
                    {
                        employeeList.Add(new SeniorManager());

                        break;
                    }
                    case 2:
                    {
                        employeeList.Add(new Manager());

                        break;
                    }
                    case 3:
                    {
                        employeeList.Add(new Worker());
                        break;
                    }
                }
                OutputBox.AppendText(string.Format("Add a {0} named {1}.\n", employeeTypes.SelectedItem, employeeName.Text));
            }
            var c = new Director();
           var visitor = new TotalCalculator();
            c.Accept(visitor);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
