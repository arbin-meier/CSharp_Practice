namespace WinForm_UI_Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Designation = new System.Windows.Forms.Label();
            this.Label_Salary = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Designation = new System.Windows.Forms.TextBox();
            this.TextBox_Salary = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Panel_TextBoxInfo = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DataGridView_Test = new System.Windows.Forms.DataGridView();
            this.Panel_RadioBtnTitle = new System.Windows.Forms.Panel();
            this.RadioButton_Employee = new System.Windows.Forms.RadioButton();
            this.RadioButton_Manager = new System.Windows.Forms.RadioButton();
            this.Panel_RadioBtnGender = new System.Windows.Forms.Panel();
            this.RadioButton_Male = new System.Windows.Forms.RadioButton();
            this.RadioButton_Female = new System.Windows.Forms.RadioButton();
            this.Panel_RadioBtnParent = new System.Windows.Forms.Panel();
            this.Button_SaveTableToExcel = new System.Windows.Forms.Button();
            this.Panel_TextBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Test)).BeginInit();
            this.Panel_RadioBtnTitle.SuspendLayout();
            this.Panel_RadioBtnGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(46, 136);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(42, 15);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Name:";
            // 
            // Label_Designation
            // 
            this.Label_Designation.AutoSize = true;
            this.Label_Designation.Location = new System.Drawing.Point(46, 176);
            this.Label_Designation.Name = "Label_Designation";
            this.Label_Designation.Size = new System.Drawing.Size(73, 15);
            this.Label_Designation.TabIndex = 1;
            this.Label_Designation.Text = "Designation:";
            // 
            // Label_Salary
            // 
            this.Label_Salary.AutoSize = true;
            this.Label_Salary.Location = new System.Drawing.Point(46, 218);
            this.Label_Salary.Name = "Label_Salary";
            this.Label_Salary.Size = new System.Drawing.Size(41, 15);
            this.Label_Salary.TabIndex = 2;
            this.Label_Salary.Text = "Salary:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(4, 14);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(252, 23);
            this.TextBox_Name.TabIndex = 3;
            this.TextBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBox_Designation
            // 
            this.TextBox_Designation.Location = new System.Drawing.Point(4, 54);
            this.TextBox_Designation.Name = "TextBox_Designation";
            this.TextBox_Designation.Size = new System.Drawing.Size(252, 23);
            this.TextBox_Designation.TabIndex = 4;
            this.TextBox_Designation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBox_Salary
            // 
            this.TextBox_Salary.Location = new System.Drawing.Point(4, 96);
            this.TextBox_Salary.Name = "TextBox_Salary";
            this.TextBox_Salary.Size = new System.Drawing.Size(252, 23);
            this.TextBox_Salary.TabIndex = 5;
            this.TextBox_Salary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(46, 369);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(144, 37);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_Gender
            // 
            this.Label_Gender.AutoSize = true;
            this.Label_Gender.Location = new System.Drawing.Point(46, 267);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(48, 15);
            this.Label_Gender.TabIndex = 12;
            this.Label_Gender.Text = "Gender:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(46, 304);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(53, 15);
            this.Label_Title.TabIndex = 13;
            this.Label_Title.Text = "Job Title:";
            // 
            // Panel_TextBoxInfo
            // 
            this.Panel_TextBoxInfo.Controls.Add(this.TextBox_Name);
            this.Panel_TextBoxInfo.Controls.Add(this.TextBox_Salary);
            this.Panel_TextBoxInfo.Controls.Add(this.TextBox_Designation);
            this.Panel_TextBoxInfo.Location = new System.Drawing.Point(121, 119);
            this.Panel_TextBoxInfo.Name = "Panel_TextBoxInfo";
            this.Panel_TextBoxInfo.Size = new System.Drawing.Size(284, 125);
            this.Panel_TextBoxInfo.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DataGridView_Test
            // 
            this.DataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Test.Location = new System.Drawing.Point(448, 61);
            this.DataGridView_Test.Name = "DataGridView_Test";
            this.DataGridView_Test.RowTemplate.Height = 25;
            this.DataGridView_Test.Size = new System.Drawing.Size(535, 434);
            this.DataGridView_Test.TabIndex = 17;
            // 
            // Panel_RadioBtnTitle
            // 
            this.Panel_RadioBtnTitle.Controls.Add(this.RadioButton_Employee);
            this.Panel_RadioBtnTitle.Controls.Add(this.RadioButton_Manager);
            this.Panel_RadioBtnTitle.Location = new System.Drawing.Point(125, 299);
            this.Panel_RadioBtnTitle.Name = "Panel_RadioBtnTitle";
            this.Panel_RadioBtnTitle.Size = new System.Drawing.Size(220, 28);
            this.Panel_RadioBtnTitle.TabIndex = 14;
            // 
            // RadioButton_Employee
            // 
            this.RadioButton_Employee.AutoSize = true;
            this.RadioButton_Employee.Location = new System.Drawing.Point(117, 3);
            this.RadioButton_Employee.Name = "RadioButton_Employee";
            this.RadioButton_Employee.Size = new System.Drawing.Size(77, 19);
            this.RadioButton_Employee.TabIndex = 16;
            this.RadioButton_Employee.TabStop = true;
            this.RadioButton_Employee.Text = "Employee";
            this.RadioButton_Employee.UseVisualStyleBackColor = true;
            this.RadioButton_Employee.CheckedChanged += new System.EventHandler(this.Set_Info_RadioBtn);
            // 
            // RadioButton_Manager
            // 
            this.RadioButton_Manager.AutoSize = true;
            this.RadioButton_Manager.Location = new System.Drawing.Point(0, 3);
            this.RadioButton_Manager.Name = "RadioButton_Manager";
            this.RadioButton_Manager.Size = new System.Drawing.Size(72, 19);
            this.RadioButton_Manager.TabIndex = 15;
            this.RadioButton_Manager.TabStop = true;
            this.RadioButton_Manager.Text = "Manager";
            this.RadioButton_Manager.UseVisualStyleBackColor = true;
            this.RadioButton_Manager.CheckedChanged += new System.EventHandler(this.Set_Info_RadioBtn);
            // 
            // Panel_RadioBtnGender
            // 
            this.Panel_RadioBtnGender.Controls.Add(this.RadioButton_Male);
            this.Panel_RadioBtnGender.Controls.Add(this.RadioButton_Female);
            this.Panel_RadioBtnGender.Location = new System.Drawing.Point(125, 262);
            this.Panel_RadioBtnGender.Name = "Panel_RadioBtnGender";
            this.Panel_RadioBtnGender.Size = new System.Drawing.Size(220, 27);
            this.Panel_RadioBtnGender.TabIndex = 11;
            // 
            // RadioButton_Male
            // 
            this.RadioButton_Male.AutoSize = true;
            this.RadioButton_Male.Location = new System.Drawing.Point(0, 3);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(51, 19);
            this.RadioButton_Male.TabIndex = 9;
            this.RadioButton_Male.TabStop = true;
            this.RadioButton_Male.Text = "Male";
            this.RadioButton_Male.UseVisualStyleBackColor = true;
            this.RadioButton_Male.CheckedChanged += new System.EventHandler(this.Set_Info_RadioBtn);
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.Location = new System.Drawing.Point(117, 3);
            this.RadioButton_Female.Name = "RadioButton_Female";
            this.RadioButton_Female.Size = new System.Drawing.Size(63, 19);
            this.RadioButton_Female.TabIndex = 10;
            this.RadioButton_Female.TabStop = true;
            this.RadioButton_Female.Text = "Female";
            this.RadioButton_Female.UseVisualStyleBackColor = true;
            this.RadioButton_Female.CheckedChanged += new System.EventHandler(this.Set_Info_RadioBtn);
            // 
            // Panel_RadioBtnParent
            // 
            this.Panel_RadioBtnParent.Location = new System.Drawing.Point(0, 0);
            this.Panel_RadioBtnParent.Name = "Panel_RadioBtnParent";
            this.Panel_RadioBtnParent.Size = new System.Drawing.Size(200, 100);
            this.Panel_RadioBtnParent.TabIndex = 0;
            // 
            // Button_SaveTableToExcel
            // 
            this.Button_SaveTableToExcel.Location = new System.Drawing.Point(233, 369);
            this.Button_SaveTableToExcel.Name = "Button_SaveTableToExcel";
            this.Button_SaveTableToExcel.Size = new System.Drawing.Size(144, 37);
            this.Button_SaveTableToExcel.TabIndex = 6;
            this.Button_SaveTableToExcel.Text = "Save Table";
            this.Button_SaveTableToExcel.UseVisualStyleBackColor = true;
            this.Button_SaveTableToExcel.Click += new System.EventHandler(this.Button_SaveTableToCsv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 560);
            this.Controls.Add(this.Button_SaveTableToExcel);
            this.Controls.Add(this.DataGridView_Test);
            this.Controls.Add(this.Panel_TextBoxInfo);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_Gender);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Label_Salary);
            this.Controls.Add(this.Label_Designation);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Panel_RadioBtnGender);
            this.Controls.Add(this.Panel_RadioBtnTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_TextBoxInfo.ResumeLayout(false);
            this.Panel_TextBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Test)).EndInit();
            this.Panel_RadioBtnTitle.ResumeLayout(false);
            this.Panel_RadioBtnTitle.PerformLayout();
            this.Panel_RadioBtnGender.ResumeLayout(false);
            this.Panel_RadioBtnGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label_Name;
        private Label Label_Designation;
        private Label Label_Salary;
        private TextBox TextBox_Name;
        private TextBox TextBox_Designation;
        private TextBox TextBox_Salary;
        private Button Button_Save;
        private RadioButton RadioButton_Male;
        private RadioButton RadioButton_Female;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel Panel_RadioBtnGender;
        private Label Label_Gender;
        private Label Label_Title;
        private Panel Panel_RadioBtnTitle;
        private RadioButton RadioButton_Employee;
        private RadioButton RadioButton_Manager;
        private Panel Panel_TextBoxInfo;
        private Panel Panel_RadioBtnParent;
        private ErrorProvider errorProvider1;
        private DataGridView DataGridView_Test;
        private Button Button_SaveTableToExcel;
    }
}