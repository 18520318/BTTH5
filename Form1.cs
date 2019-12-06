using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTH5
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        public Form1()
        {
            InitializeComponent();
            QLSV.StartService();

            cbxPhone.DataSource = model.AreaCode;
            cbxPhone.SelectedIndex = 0;

            ToggleInfo();
            btnSave.Enabled = false;

            dataGridView1.MultiSelect = false;
            timepick.MaxDate = DateTime.Now.AddYears(-17);
            timepick.MinDate = DateTime.Now.AddYears(-35);

            LoadInfo();
        }

        private BindingList<Student> students = new BindingList<Student>();

        public Mode CurrentMode { get; set; } = Mode.NONE;
        private Student SelectedStudent { get; set; }

        public void ToggleInfo()
        {
            pnlInfo1.Enabled = !pnlInfo1.Enabled;
            pnlInfo2.Enabled = pnlInfo1.Enabled;
        }

        public void ClearInfo()
        {
            tbxID.Text = "";
            tbxName.Text = "";
            tbxPhone.Text = "";
            tbxMail.Text = "";
            timepick.Value = timepick.MaxDate;
        }

        public void LoadInfo()
        {
            students = new BindingList<Student>(QLSV.Instance.GetAllRecords());
            var source = new BindingSource(students, null);
            dataGridView1.DataSource = source;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DeleteModePrepare();            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddModePrepare();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            ChangeModePrepare();
        }

        public void AddModePrepare()
        {
            if (!pnlInfo1.Enabled)
            {
                ToggleInfo();
            }

            this.CurrentMode = Mode.ADDING;
            ClearInfo();

            btnAdd.Enabled = false;
            btnChange.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;

            this.ActiveControl = tbxName;
        }

        public void ChangeModePrepare()
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            this.CurrentMode = Mode.EDITING;

            if (!pnlInfo1.Enabled)
            {
                ToggleInfo();
            }

            tbxID.Enabled = false;

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnChange.Enabled = false;
            btnSave.Enabled = true;
        }



        public void DeleteModePrepare()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hay không?", "Xoá", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    Student std = row.DataBoundItem as Student;
                    QLSV.Instance.DeleteInfo(std.Id);
                    students.Remove(std);                    
                }
            }
        }

        public void SaveModePrepare()
        {
            ToggleInfo();

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnChange.Enabled = true;
            btnSave.Enabled = false;
            CurrentMode = Mode.NONE;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.ADDING)
            {
                Student student = new Student();
                student.Sv_name = tbxName.Text;
                student.Id = tbxID.Text;
                student.Sv_class = tbxClass.Text;
                student.Dob = timepick.Value;
                student.Gender = Gender.Male;
                student.Phone = Convert.ToInt32(tbxPhone.Text);
                student.Areacode = cbxPhone.SelectedItem.ToString();
                student.Mail = tbxMail.Text;

                QLSV.Instance.AddInfo(student);
                students.Add(student);
            }
            

            if (CurrentMode == Mode.EDITING)
            {
                Student std = students.Where(p => p.Id == tbxID.Text).First();

                std.Sv_name = tbxName.Text;
                std.Sv_class = tbxClass.Text;
                std.Dob = timepick.Value;
                std.Gender = Gender.Male;
                std.Phone = Convert.ToInt32(tbxPhone.Text);
                std.Areacode = cbxPhone.SelectedItem.ToString();
                std.Mail = tbxMail.Text;

                QLSV.Instance.UpdateInfo(std);
                dataGridView1.Refresh();
            }

            SaveModePrepare();
        }

        private void CellSelectionOverride(object sender, DataGridViewCellEventArgs e)
        {
            if (CurrentMode != Mode.NONE)
            {
                dataGridView1.ClearSelection();
                return;
            }

            dataGridView1.Rows[e.RowIndex].Selected = true;

            if (pnlInfo1.Enabled)
            {
                ToggleInfo();
            }
            Student std = dataGridView1.SelectedRows[0].DataBoundItem as Student;

            tbxName.Text = std.Sv_name;
            tbxID.Text = std.Id;
            tbxClass.Text = std.Sv_class;
            timepick.Value = std.Dob;
            tbxPhone.Text = std.Phone.ToString();
            tbxMail.Text = std.Mail;
            cbxPhone.SelectedItem = std.Areacode;

        }

        private void PhoneNumberFilter(object sender, KeyPressEventArgs e)
        {
            TextBox tbx = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbx.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        /*private string DataGridView1_CellClick(DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            string tam = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            return tam;
        }*/
    }

    public enum Mode
    {
        NONE,
        EDITING,
        ADDING
    }
}
