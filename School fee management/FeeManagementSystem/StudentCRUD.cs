using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FeeManagementSystem
{
    public partial class StudentCRUD : Form
    {
        public StudentCRUD()
        {
            InitializeComponent();
        }

        private void StudentCRUD_Load(object sender, EventArgs e)
        {
            LoadClassandSection();
            LoadDataGridView();
            btnDelete.Enabled = false;
        }
        public void Clearform()
        {
                txtStudentName.Text = "";
                txtAddress.Text = "";
                txtGuardian.Text = "";
                txtContact.Text = "";
                cboClass.SelectedIndex = 0;
                cboSection.SelectedIndex = 0;
        }
        BllStudentCRUD bllst = new BllStudentCRUD();
        private void LoadClassandSection()
        {
            DataTable dtc = bllst.GetClass();

            DataRow drc = dtc.NewRow();
            drc["Class"] = "Choose your Class";
            dtc.Rows.InsertAt(drc, 0);

            cboClass.DataSource = dtc;
            cboClass.DisplayMember = "Class";
            cboClass.ValueMember = "Classid";

            DataTable dts = bllst.GetSection();

            DataRow drs = dts.NewRow();
            drs["Section"] = "Choose your Section";
            dts.Rows.InsertAt(drs, 0);

            cboSection.DataSource = dts;
            cboSection.DisplayMember = "Section";
            cboSection.ValueMember = "Sectionid";
        }
        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = bllst.GetAllStudent();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                dataGridView1.Rows[i].Cells["colClass"].Value = dt.Rows[i]["Class"];
                dataGridView1.Rows[i].Cells["colSection"].Value = dt.Rows[i]["Section"];
                dataGridView1.Rows[i].Cells["colStudentid"].Value = dt.Rows[i]["Studentid"];
                dataGridView1.Rows[i].Cells["colStudentName"].Value = dt.Rows[i]["StudentName"].ToString();
                dataGridView1.Rows[i].Cells["colAddress"].Value = dt.Rows[i]["Address"].ToString();
                dataGridView1.Rows[i].Cells["colGuardian"].Value = dt.Rows[i]["Guardian"].ToString();
                dataGridView1.Rows[i].Cells["colContact"].Value = dt.Rows[i]["Contact"].ToString();
            }

        }
      
       
        BllFee blf = new BllFee();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                int i = bllst.InsertStudent(txtStudentName.Text, txtAddress.Text, txtGuardian.Text, txtContact.Text, Convert.ToInt32(cboClass.SelectedValue.ToString()), Convert.ToInt32(cboSection.SelectedValue.ToString()));
                //int j = blf.insertintoFeetagging(studentid, Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), txtStudentName.Text);

                if (i > 0)
                {
                    MessageBox.Show("New Student Inserted");
                    Clearform();
                }
            }
            else
            {
                MessageBox.Show("Choose Your Class and Section");
            }

            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = bllst.UpdateStudent(studentid, txtStudentName.Text, txtAddress.Text,txtGuardian.Text, txtContact.Text, Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
            int j = bllst.UpdateStudentatfeetagging(studentid, txtStudentName.Text, Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
            if (i > 0)
            {
                MessageBox.Show("Student Updated");
                Clearform();
            }
            if (j > 0)
            {
                MessageBox.Show("Student Updated in feetagging table");
            }
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = bllst.DeleteStudent(studentid);
            if (i > 0)
            {
                MessageBox.Show("Student Deleted");
                Clearform();
            }
            LoadDataGridView();
        }
        int studentid = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["colStudentid"].Value.ToString());
            cboClass.Text = dataGridView1.CurrentRow.Cells["colClass"].Value.ToString();
            cboSection.Text = dataGridView1.CurrentRow.Cells["colSection"].Value.ToString();
            txtStudentName.Text = dataGridView1.CurrentRow.Cells["colStudentName"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["colAddress"].Value.ToString();
            txtGuardian.Text = dataGridView1.CurrentRow.Cells["colGuardian"].Value.ToString();
            txtContact.Text = dataGridView1.CurrentRow.Cells["colContact"].Value.ToString();
        }
    }
}
