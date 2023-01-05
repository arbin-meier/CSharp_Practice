using System.Data;
using System.Text;

namespace WinForm_UI_Practice
{
    public partial class Form1 : Form
    {
        #region Fields
        private int _salary;
        private string _name;
        private string _designation;
        private string _gender;
        private string _jobTitle;

        DataTable _dataTable = new DataTable();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TextBox_Name;
            Init_DataGridView();            
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (IsValid_Input())
            {
                Populate_DataGridView();
                MessageBox.Show("Successfully Populated Table!");
            }
        }

        private bool IsValid_Input()
        {
            _name = TextBox_Name.Text;
            _designation = TextBox_Designation.Text;
            if (!int.TryParse(TextBox_Salary.Text, out _salary))
            {
                MessageBox.Show("Input is not valid!");
                return false;
            }

            bool isRadio = IsChecked_AllRadioBtn();
            bool isTextBox = IsFilled_AllTextBox();

            return isRadio && isTextBox;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsChecked_AllRadioBtn()
        {
            //If Panel_RadioBtn exists in current form
            IEnumerable<Panel> radioPanel = this.Controls.OfType<Panel>().
                               Where(panel => panel.Name.ToLower().Contains("radiobtn"));

            bool isAllRadioBtnChecked = false;
            if (radioPanel.Any())
            {
                foreach (Panel panel in radioPanel)
                {
                    if (!panel.Controls.OfType<RadioButton>().Any()) continue;
                    isAllRadioBtnChecked = false;
                    foreach (RadioButton radioBtn in panel.Controls.OfType<RadioButton>())
                        if (radioBtn.Checked) isAllRadioBtnChecked = true;
                    if (!isAllRadioBtnChecked)
                    {
                        MessageBox.Show("Exists unchecked options!");
                        return false;
                    }
                }
            }

            return isAllRadioBtnChecked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        private bool IsFilled_AllTextBox() 
        {
            IEnumerable<Panel> textBoxPanel = this.Controls.OfType<Panel>().
                               Where(panel => panel.Name.ToLower().Contains("textbox"));
            //If all text boxes are filled
            bool isAllTextBoxChecked = true;

            if (textBoxPanel.Any())
            {
                foreach (Panel panel in textBoxPanel)
                {
                    if (!panel.Controls.OfType<TextBox>().Any()) continue;
                    foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
                        if (string.IsNullOrEmpty(textBox.Text.Trim())) isAllTextBoxChecked = false;
                }
            }

            if (!isAllTextBoxChecked) MessageBox.Show("Please fill all boxes!");
            return isAllTextBoxChecked;
        }

        /// <summary>
        /// Pass the radioBtn choices to fields of class. And it 
        /// will separate groups of radioBtn by panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Set_Info_RadioBtn(object sender, EventArgs e)
        {
            RadioButton currButton = (RadioButton)sender;
            if (((RadioButton)sender).Checked == true)
            {
                Panel parentPanel = (Panel)currButton.Parent;
                switch (parentPanel.Name)
                {
                    case "Panel_RadioBtnGender":
                        _gender = currButton.Text;
                        break;
                    case "Panel_RadioBtnTitle": 
                        _jobTitle = currButton.Text;
                        break;
                }
            }
        }       

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TextBox_Salary.ContainsFocus)
                {
                    if (e.KeyCode == Keys.Enter)
                        Button_Save.PerformClick();
                }
                else ((TextBox)sender).Parent.GetNextControl((TextBox)sender, true).Focus();                
            }             
            else if (e.KeyCode == Keys.Up)
            {
                if (!TextBox_Name.ContainsFocus) 
                    ((TextBox)sender).Parent.GetNextControl((TextBox)sender, false).Focus();
            }
        }

        private void Populate_DataGridView()
        {
            int rowIndex = DataGridView_Test.Rows.Add();

            var row = this.DataGridView_Test.Rows[rowIndex];
            row.Cells["Column_Name"].Value = _name;
            row.Cells["Column_Designation"].Value = _designation;
            row.Cells["Column_Salary"].Value = _salary;
            row.Cells["Column_Gender"].Value = _gender;
            row.Cells["Column_JobTitle"].Value = _jobTitle;
        }
       
        private void Init_DataGridView()
        {
            DataGridView_Test.ColumnCount = 5;
            DataGridView_Test.Columns[0].Name = "Column_Name";
            DataGridView_Test.Columns[1].Name = "Column_Designation";
            DataGridView_Test.Columns[2].Name = "Column_Salary";
            DataGridView_Test.Columns[3].Name = "Column_Gender";
            DataGridView_Test.Columns[4].Name = "Column_JobTitle";

            DataGridView_Test.Columns[0].HeaderText = "Name";
            DataGridView_Test.Columns[1].HeaderText = "Designation";
            DataGridView_Test.Columns[2].HeaderText = "Salary";
            DataGridView_Test.Columns[3].HeaderText = "Gender";
            DataGridView_Test.Columns[4].HeaderText = "JobTitle";

            DataGridView_Test.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_Test.MultiSelect = false;
        }

        private void Button_SaveTableToCsv_Click(object sender, EventArgs e)
        {
            if (DataGridView_Test.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //if (File.Exists(sfd.FileName))
                    //{
                    //    try { File.Delete(sfd.FileName); }
                    //    catch (IOException ex)
                    //    {
                    //        fileError = true;
                    //        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    //    }
                    //}
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = DataGridView_Test.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[DataGridView_Test.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += DataGridView_Test.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < DataGridView_Test.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                    outputCsv[i] += Convert.ToString(DataGridView_Test.Rows[i - 1].Cells[j].Value) + ",";
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex) { MessageBox.Show("Error :" + ex.Message); }
                    }
                }
            }
            else { MessageBox.Show("No Record To Export !!!", "Info"); }
        }
    }
}