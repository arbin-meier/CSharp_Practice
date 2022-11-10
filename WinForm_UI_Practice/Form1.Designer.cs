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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_Tip = new System.Windows.Forms.Label();
            this.RadioButton_Male = new System.Windows.Forms.RadioButton();
            this.RadioButton_Female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(352, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(217, 115);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(352, 23);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(217, 157);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(352, 23);
            this.txtSalary.TabIndex = 5;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(281, 276);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(144, 37);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_Tip
            // 
            this.Label_Tip.AutoSize = true;
            this.Label_Tip.Location = new System.Drawing.Point(129, 313);
            this.Label_Tip.Name = "Label_Tip";
            this.Label_Tip.Size = new System.Drawing.Size(0, 15);
            this.Label_Tip.TabIndex = 8;
            // 
            // RadioButton_Male
            // 
            this.RadioButton_Male.AutoSize = true;
            this.RadioButton_Male.Location = new System.Drawing.Point(217, 210);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(51, 19);
            this.RadioButton_Male.TabIndex = 9;
            this.RadioButton_Male.TabStop = true;
            this.RadioButton_Male.Text = "Male";
            this.RadioButton_Male.UseVisualStyleBackColor = true;
            this.RadioButton_Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.Location = new System.Drawing.Point(375, 210);
            this.RadioButton_Female.Name = "RadioButton_Female";
            this.RadioButton_Female.Size = new System.Drawing.Size(63, 19);
            this.RadioButton_Female.TabIndex = 10;
            this.RadioButton_Female.TabStop = true;
            this.RadioButton_Female.Text = "Female";
            this.RadioButton_Female.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 383);
            this.Controls.Add(this.RadioButton_Female);
            this.Controls.Add(this.RadioButton_Male);
            this.Controls.Add(this.Label_Tip);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtDesignation;
        private TextBox txtSalary;
        private Button Button_Save;
        private Label Label_Tip;
        private RadioButton RadioButton_Male;
        private RadioButton RadioButton_Female;
    }
}