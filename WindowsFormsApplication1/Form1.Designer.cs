namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployee = new System.Windows.Forms.Button();
            this.employeeTypes = new System.Windows.Forms.ComboBox();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srcId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sinkId = new System.Windows.Forms.TextBox();
            this.addRelationship = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.printTree = new System.Windows.Forms.Button();
            this.shortestPath = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(105, 155);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(92, 23);
            this.addEmployee.TabIndex = 0;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.ButtonAddEmployee);
            // 
            // employeeTypes
            // 
            this.employeeTypes.FormattingEnabled = true;
            this.employeeTypes.Items.AddRange(new object[] {
            "Director",
            "Senior Manager",
            "Manager",
            "Worker"});
            this.employeeTypes.Location = new System.Drawing.Point(105, 64);
            this.employeeTypes.Name = "employeeTypes";
            this.employeeTypes.Size = new System.Drawing.Size(121, 21);
            this.employeeTypes.TabIndex = 1;
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(105, 91);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(121, 20);
            this.employeeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(15, 206);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(497, 302);
            this.OutputBox.TabIndex = 5;
            this.OutputBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // employeeSalary
            // 
            this.employeeSalary.Location = new System.Drawing.Point(105, 117);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(121, 20);
            this.employeeSalary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // employeeId
            // 
            this.employeeId.Location = new System.Drawing.Point(105, 38);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(121, 20);
            this.employeeId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Superior ID";
            // 
            // srcId
            // 
            this.srcId.Location = new System.Drawing.Point(329, 38);
            this.srcId.Name = "srcId";
            this.srcId.Size = new System.Drawing.Size(121, 20);
            this.srcId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subordinate ID";
            // 
            // sinkId
            // 
            this.sinkId.Location = new System.Drawing.Point(329, 94);
            this.sinkId.Name = "sinkId";
            this.sinkId.Size = new System.Drawing.Size(121, 20);
            this.sinkId.TabIndex = 13;
            // 
            // addRelationship
            // 
            this.addRelationship.Location = new System.Drawing.Point(329, 155);
            this.addRelationship.Name = "addRelationship";
            this.addRelationship.Size = new System.Drawing.Size(104, 23);
            this.addRelationship.TabIndex = 17;
            this.addRelationship.Text = "Add Relationship";
            this.addRelationship.UseVisualStyleBackColor = true;
            this.addRelationship.Click += new System.EventHandler(this.addRelationship_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Total Salary",
            "Actual Salary",
            "HR"});
            this.checkedListBox1.Location = new System.Drawing.Point(499, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 19;
            // 
            // printTree
            // 
            this.printTree.Location = new System.Drawing.Point(525, 206);
            this.printTree.Name = "printTree";
            this.printTree.Size = new System.Drawing.Size(91, 23);
            this.printTree.TabIndex = 20;
            this.printTree.Text = "Print Tree";
            this.printTree.UseVisualStyleBackColor = true;
            this.printTree.Click += new System.EventHandler(this.printTree_Click);
            // 
            // shortestPath
            // 
            this.shortestPath.Location = new System.Drawing.Point(525, 247);
            this.shortestPath.Name = "shortestPath";
            this.shortestPath.Size = new System.Drawing.Size(91, 23);
            this.shortestPath.TabIndex = 21;
            this.shortestPath.Text = "Shortest Path";
            this.shortestPath.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(525, 288);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(91, 23);
            this.refresh.TabIndex = 22;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadEmployee,
            this.loadRelationshipToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadEmployee
            // 
            this.loadEmployee.Name = "loadEmployee";
            this.loadEmployee.Size = new System.Drawing.Size(100, 20);
            this.loadEmployee.Text = "Load Employee";
            this.loadEmployee.Click += new System.EventHandler(this.LoadEmployeeMenu_Click);
            // 
            // loadRelationshipToolStripMenuItem
            // 
            this.loadRelationshipToolStripMenuItem.Name = "loadRelationshipToolStripMenuItem";
            this.loadRelationshipToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.loadRelationshipToolStripMenuItem.Text = "Load Relationship";
            this.loadRelationshipToolStripMenuItem.Click += new System.EventHandler(this.loadRelationshipToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 520);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.shortestPath);
            this.Controls.Add(this.printTree);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addRelationship);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sinkId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.srcId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.employeeTypes);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Organization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.ComboBox employeeTypes;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox srcId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sinkId;
        private System.Windows.Forms.Button addRelationship;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button printTree;
        private System.Windows.Forms.Button shortestPath;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadEmployee;
        private System.Windows.Forms.ToolStripMenuItem loadRelationshipToolStripMenuItem;
    }
}

