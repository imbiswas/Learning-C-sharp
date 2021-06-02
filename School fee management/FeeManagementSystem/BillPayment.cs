using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeeManagementSystem
{
    public partial class BillPayment : Form
    {
        public BillPayment()
        {
            InitializeComponent();
        }
        BllStudentCRUD cs = new BllStudentCRUD();
        BllFee blf = new BllFee();
        BllClaimBill blc = new BllClaimBill();
        BllBillPayment blbp = new BllBillPayment();
        public void LoadClassandSectionandStudents()
        {
            DataTable dtc = cs.GetClass();
            DataRow drc = dtc.NewRow();
            drc["Class"] = "Choose Your Class";
            dtc.Rows.InsertAt(drc, 0);

            cboClass.DataSource = dtc;
            cboClass.DisplayMember = "Class";
            cboClass.ValueMember = "Classid";

            DataTable dts = cs.GetSection();
            DataRow drs = dts.NewRow();
            drs["Section"] = "Choose Your Section";
            dts.Rows.InsertAt(drs, 0);

            cboSection.DataSource = dts;
            cboSection.DisplayMember = "Section";
            cboSection.ValueMember = "Sectionid";
        }
        private void BillPayment_Load(object sender, EventArgs e)
        {
            LoadClassandSectionandStudents();
            mktxtBillingDate.Text = DateTime.Now.ToShortDateString();
            txtPreviousAdvance.ReadOnly = true;
            txtDueAmount.ReadOnly = true;
            txtAdvanceAmount.ReadOnly = true;
            txtDiscountAmount.ReadOnly = true;
            txtNewDueAmount.ReadOnly = true;
            dataGridView1.Columns["colFeeHead"].ReadOnly = true;
            dataGridView1.Columns["colAmount"].ReadOnly = true;
            chkIndividualPayment.Checked = true;

        }

        private void cboClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSection.SelectedIndex!=0 && cboClass.SelectedIndex!=0)
            {
               

                DataTable dtbc = blbp.getStudentsForPayment(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                DataRow drbc = dtbc.NewRow();
                drbc["StudentName"] = "Select Student";
                dtbc.Rows.InsertAt(drbc, 0);
                cboStudentName.DataSource = dtbc;
                cboStudentName.DisplayMember = "StudentName";
                cboStudentName.ValueMember = "Studentid";
            }
        }

        private void cboSection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSection.SelectedIndex != 0 && cboClass.SelectedIndex != 0)
            {
                DataTable dtbc = blbp.getStudentsForPayment(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                DataRow drbc = dtbc.NewRow();
                drbc["StudentName"] = "Select Student";
                dtbc.Rows.InsertAt(drbc, 0);
                cboStudentName.DataSource = dtbc;
                cboStudentName.DisplayMember = "StudentName";
                cboStudentName.ValueMember = "Studentid";
            }
        }

        private void cboStudentName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboStudentName.SelectedIndex != 0)
            {
                DataTable dtbc = blbp.getBillClaimDetails(Convert.ToInt32(cboStudentName.SelectedValue));
                DataTable dtbd = blbp.getBillingDetails(Convert.ToInt32(cboStudentName.SelectedValue));
                DataTable dtbill = blbp.getBilling(Convert.ToInt32(cboStudentName.SelectedValue));
                if(dtbill.Rows.Count==0)
                {
                    txtPreviousAdvance.Text = "0";
                }
                else
                {
                  txtPreviousAdvance.Text=dtbill.Rows[0]["Advance"].ToString();
                }
                txtDiscountAmount.Text = "0";

                dataGridView1.Rows.Clear();
                decimal amount = 0M;
                for (int i=0;i<dtbc.Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["colFeeHead"].Value = dtbc.Rows[i]["FeeHead"].ToString();
                    if (dtbd.Rows.Count == 0)
                    {
                        dataGridView1.Rows[i].Cells["colAmount"].Value = Convert.ToString(Convert.ToDecimal(dtbc.Rows[i]["Amount"]));
                        //amount = amount + Convert.ToDecimal(dtbc.Rows[i]["Amount"].ToString());
                        amount = amount + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colAmount"].Value);
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["colAmount"].Value = Convert.ToString(Convert.ToDecimal(dtbc.Rows[i]["Amount"]) - Convert.ToDecimal(dtbd.Rows[i]["Payment"]));
                        //amount = amount + Convert.ToDecimal(dtbc.Rows[i]["Amount"].ToString());
                        amount = amount + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colAmount"].Value);
                    }
                    
                }
                txtDueAmount.Text =Convert.ToString(amount);
               
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string var = dataGridView1.Columns[e.ColumnIndex].Name;
            switch (var)
            {
              case "colDiscountbyPercentage":
                    if (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colDiscountbyPercentage"].Value) >= 0 && Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colDiscountbyPercentage"].Value) <= 100)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["colDiscountByAmount"].Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colAmount"].Value) * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colDiscountbyPercentage"].Value) / 100;
                    }
                        break;
              case "colDiscountByAmount":
                    dataGridView1.Rows[e.RowIndex].Cells["colDiscountbyPercentage"].Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colDiscountByAmount"].Value) / Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colAmount"].Value) * 100;
                    break;
                //case "colPaidAmount":
                //    //decimal a = 0;
                //    // decimal v = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colPaidAmount"].Value);
                //    //a = a + v;
                //    //txtPaidAmount.Text = Convert.ToString(a);
                //    break;
            }

            decimal sum = 0;
            decimal add = 0;
           for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //if (dataGridView1.Rows[i].Cells["colPaidAmount"].Value == null)
                //{
                //    dataGridView1.Rows[i].Cells["colPaidAmount"].Value = "0";
                //}
                sum = sum + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value);
                txtDiscountAmount.Text = Convert.ToString(sum);
                add = add + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colPaidAmount"].Value);
                txtPaidAmount.Text = Convert.ToString(add);
            }
        

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();

        }

        private void Cancel()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["colDiscountbyPercentage"].Value = "0";
                dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value = "0";
                dataGridView1.Rows[i].Cells["colPaidAmount"].Value = "0";
               
                txtDiscountAmount.Text = "0";
                txtAdvanceAmount.Text = "0";
                txtNewDueAmount.Text = "0";
                txtPaidAmount.Text = "0";

            }
        }

        private void chkIndividualPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndividualPayment.Checked == false)
            {
                dataGridView1.Columns["colPaidAmount"].ReadOnly = true;
                txtPaidAmount.ReadOnly = false;
                Cancel();
              
            }
            else
            {
                dataGridView1.Columns["colPaidAmount"].ReadOnly = false;
                txtPaidAmount.ReadOnly = true;
                Cancel();

            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            //if(txtPaidAmount.Text!=string.Empty && txtDueAmount.Text != string.Empty && txtDiscountAmount.Text != string.Empty && txtNewDueAmount.Text != string.Empty)
            //{
            
            
            decimal sum = Convert.ToDecimal(txtPaidAmount.Text) + Convert.ToDecimal(txtDiscountAmount.Text);
            if (sum < Convert.ToDecimal(txtDueAmount.Text))
            {
                txtNewDueAmount.Text = Convert.ToString(Convert.ToDecimal(txtDueAmount.Text) - Convert.ToDecimal(txtDiscountAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text));
                txtAdvanceAmount.Text = "0";
            }
            else
            {
                txtNewDueAmount.Text = "0";
              string  ad = Convert.ToString(Convert.ToDecimal(txtDueAmount.Text) - Convert.ToDecimal(txtDiscountAmount.Text));
                txtAdvanceAmount.Text = Convert.ToString(Convert.ToDecimal(txtPaidAmount.Text)-Convert.ToDecimal(ad));
            }
               
            //}
           


        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                decimal sum = Convert.ToDecimal(txtPaidAmount.Text);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    if (sum >= Convert.ToDecimal(dataGridView1.Rows[i].Cells["colAmount"].Value))
                    {
                        if (dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value == null)
                        {
                            dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value = 0;
                        }
                        sum = sum - Convert.ToDecimal(dataGridView1.Rows[i].Cells["colAmount"].Value);
                        dataGridView1.Rows[i].Cells["colPaidAmount"].Value =Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[i].Cells["colAmount"].Value) -Convert.ToDecimal(dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value));

                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["colPaidAmount"].Value = sum;
                        sum = 0;
                    }

                }
               
                    
              
            }
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(txtDiscountAmount.Text) > 0)
            //{
            //    txtNewDueAmount.Text = Convert.ToString(Convert.ToDecimal(txtDueAmount.Text) - Convert.ToDecimal(txtDiscountAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text));
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue BillPayment?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (txtAdvanceAmount.Text==null)
            {
                txtAdvanceAmount.Text = "0";
            }
            if (txtDiscountAmount.Text == null)
            {
                txtDiscountAmount.Text = "0";
            }
            int a = blbp.insertinBilling(Convert.ToInt32(cboClass.SelectedValue),Convert.ToInt32(cboSection.SelectedValue),Convert.ToInt32(cboStudentName.SelectedValue),Convert.ToDecimal(txtDueAmount.Text),Convert.ToDecimal(txtPaidAmount.Text),Convert.ToDecimal(txtNewDueAmount.Text),Convert.ToDecimal(txtDiscountAmount.Text),Convert.ToDecimal(txtAdvanceAmount.Text));
            int b = 0;
            DataTable dt = blbp.getBilling(Convert.ToInt32(cboStudentName.SelectedValue));
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int billid = Convert.ToInt32(dt.Rows[0]["Billid"].ToString());
                int classid = Convert.ToInt32(cboClass.SelectedValue);
                int sectionid = Convert.ToInt32(cboSection.SelectedValue);
                int studentid = Convert.ToInt32(cboStudentName.SelectedValue);
                string billingdate = mktxtBillingDate.Text;
                string month = Convert.ToString(DateTime.Today.Month);
                string feehead= Convert.ToString(dataGridView1.Rows[i].Cells["colFeeHead"].Value);
                decimal paidamount = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colPaidAmount"].Value);
                if (string.IsNullOrEmpty(Convert.ToString(dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value))==true)
                { 
                    dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value = "0";
                }
                decimal discount = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colDiscountByAmount"].Value);

                int x = blbp.insertinBillingDetails(billid, classid, sectionid, studentid, billingdate, month, feehead, paidamount, discount);
                if (x > 0)
                {
                    b++;
                }
            }
            if(a>0 && b > 0)
            {
                MessageBox.Show("BillPayment Succesful");
                txtPaidAmount.Text = "0";
                Cancel();
                cboStudentName_SelectedValueChanged(sender,e);
            }
        }
    }
}
