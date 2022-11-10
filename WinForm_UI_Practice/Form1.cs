using System.Xml.Linq;
using System.Xml.Serialization;

namespace WinForm_UI_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string designation = txtDesignation.Text;
            bool isSalary_int = int.TryParse(txtSalary.Text, out int salary);

            string gender;

            switch()
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void FillDataGridView(string name, string designation, int salary)
        //{
        //    //add row to dgv
        //    // fill
        //    int rowIdx = DataGridView_Test.Rows.Add();

        //    DataGridView_Test.Rows[rowIdx].Cells["Column_Name"].Value = name;
        //    DataGridView_Test.Rows[rowIdx].Cells["Column_Designation"].Value = designation;
        //    DataGridView_Test.Rows[rowIdx].Cells["Column_Salary"].Value = salary;

        //}
    }
}