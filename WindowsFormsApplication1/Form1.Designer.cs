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
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(102, 66);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(75, 21);
            this.addEmployee.TabIndex = 0;
            this.addEmployee.Text = "Add";
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
            this.employeeTypes.Location = new System.Drawing.Point(102, 11);
            this.employeeTypes.Name = "employeeTypes";
            this.employeeTypes.Size = new System.Drawing.Size(121, 20);
            this.employeeTypes.TabIndex = 1;
            this.employeeTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(102, 39);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(100, 21);
            this.employeeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // richTextBox1
            // 
            this.OutputBox.Location = new System.Drawing.Point(15, 125);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(208, 182);
            this.OutputBox.TabIndex = 5;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 383);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.employeeTypes);
            this.Controls.Add(this.addEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

