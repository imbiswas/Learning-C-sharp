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
    public partial class ClaimBill : Form
    {
        public ClaimBill()
        {
            InitializeComponent();
        }
        BllStudentCRUD cs = new BllStudentCRUD();
        BllFee blf = new BllFee();
        BllClaimBill blc = new BllClaimBill();
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

        private void loadstudents()
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                DataTable dtstname = cs.GetStudentbyClassidandSectionidandStudentid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));

                DataRow drst = dtstname.NewRow();
                drst["StudentName"] = "All Students";
                dtstname.Rows.InsertAt(drst, 0);

                cboStudentName.DataSource = dtstname;
                cboStudentName.DisplayMember = "StudentName";
                cboStudentName.ValueMember = "Studentid";

                chkSelectAll.Checked = true;
                chkSelectAll.Visible = false;
                if (chkSelectAll.Checked == true)
                {
                    dataGridView2.Columns["colSelect2"].ReadOnly = true;
                }
                txtTaggedAmount.Text = null;

                DataTable dtf = blc.getFeeHeadandFeeid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                dataGridView2.Rows.Clear();
                for(int i = 0; i < dtf.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells["colSN2"].Value = i + 1;
                    dataGridView2.Rows[i].Cells["colFeeid"].Value =dtf.Rows[i]["Feeid"].ToString();
                    dataGridView2.Rows[i].Cells["colFeeHead"].Value = dtf.Rows[i]["FeeHead"].ToString();
                    dataGridView2.Rows[i].Cells["colSelect2"].Value = true;
                }


                //
                DataTable dt = blc.getAllFeeTaggingDetail(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                decimal sum1 = 0;
               
                for (int a = 0; a < dt.Rows.Count; a++)
                {
                    
                    for (int b = 0; b < dt.Columns.Count; b++)
                    {
                        if (dt.Columns[b].ColumnName != "Feetaggingid" && dt.Columns[b].ColumnName != "StudentName" && dt.Columns[b].ColumnName != "Total" && dt.Columns[b].ColumnName != "Classid" && dt.Columns[b].ColumnName != "Sectionid" && dt.Columns[b].ColumnName != "Studentid")
                        {
                            if (dt.Rows[a][b].ToString() != string.Empty )
                            {
                                decimal sum2 = Convert.ToDecimal(dt.Rows[a][b].ToString());
                                sum1 = sum2 + sum1;
                               
                                txtTaggedAmount.Text = Convert.ToString(sum1);
                            }
                        }
                    }
                }
                //
            }
            else
            {
                dataGridView2.Rows.Clear();
                cboStudentName.Text = null;
            }



            //
            dataGridView3.Rows.Clear();
            DataTable dtbcl = blc.getBillClaimlist(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
            for (int i = 0; i < dtbcl.Rows.Count; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
                dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
                dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
                dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
            }
            //
        }

        private void ClaimBill_Load(object sender, EventArgs e)
        {
            LoadClassandSectionandStudents();
            chkSelectAll.Visible = false;
            DateTimePicker dtp = new DateTimePicker();
            mktxtClaimDate.Text=DateTime.Now.ToString();
            //mktxtClaimDate.Text = DateTime.Today.ToShortDateString();
            DataTable dt = blc.getMonths();
            dataGridView1.Rows.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["colSN"].Value = dt.Rows[i]["Monthid"].ToString();
                dataGridView1.Rows[i].Cells["colMonthid"].Value = dt.Rows[i]["Monthid"].ToString();
                dataGridView1.Rows[i].Cells["colMonth"].Value = dt.Rows[i]["Month"].ToString();
                
            }
            cboClaimMonth.DataSource = dt;
            cboClaimMonth.DisplayMember = "Month";
            cboClaimMonth.ValueMember = "Monthid";
            DataRow dr = dt.NewRow();
            dr["Month"] = "Choose Your Claim Month";
            dt.Rows.InsertAt(dr, 0);
            cboClaimMonth.SelectedIndex = 0;


            cboClaimMonthforListtab.DataSource = dt;
            cboClaimMonthforListtab.DisplayMember = "Month";
            cboClaimMonthforListtab.ValueMember = "Monthid";
            //DataRow drtb = dt.NewRow();
            //drtb["Month"] = "Choose Your Claim Month";
            //dt.Rows.InsertAt(drtb, 0);
           
           
        }

        private void cboClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                loadstudents();
            }
         }
        
        private void cboSection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                loadstudents();
            }
        }

        private void cboStudentName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                if (cboStudentName.SelectedIndex != 0)
                {
                    if (chkSelectAll.Checked == true)
                    {
                        DataTable dt = blc.getTaggedAmount(Convert.ToInt32(cboStudentName.SelectedValue));
                        txtTaggedAmount.Text = dt.Rows[0]["Total"].ToString();
                    }
                    else
                    {
                        txtTaggedAmount.Text = null;
                    }

                    //
                    dataGridView3.Rows.Clear();
                    DataTable dtbcl = blc.getBillClaimlistbyStudentid(Convert.ToInt32(cboStudentName.SelectedValue));
                    for (int i = 0; i < dtbcl.Rows.Count; i++)
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
                        dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
                    }
                    //
                }
                else
                {
                    loadstudents();
                    DataTable dt = blc.getAllFeeTaggingDetail(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                    decimal sum1 = 0;

                    for (int a = 0; a < dt.Rows.Count; a++)
                    {

                        for (int b = 0; b < dt.Columns.Count; b++)
                        {
                            if (dt.Columns[b].ColumnName != "Feetaggingid" && dt.Columns[b].ColumnName != "StudentName" && dt.Columns[b].ColumnName != "Total" && dt.Columns[b].ColumnName != "Classid" && dt.Columns[b].ColumnName != "Sectionid" && dt.Columns[b].ColumnName != "Studentid")
                            {
                                if (dt.Rows[a][b].ToString() != string.Empty)
                                {
                                    decimal sum2 = Convert.ToDecimal(dt.Rows[a][b].ToString());
                                    sum1 = sum2 + sum1;

                                    txtTaggedAmount.Text = Convert.ToString(sum1);
                                }
                            }
                        }
                    }



                   
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                loadstudents();
                DataTable dtf = blc.getFeeHeadandFeeid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dtf.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells["colSN2"].Value = i + 1;
                    dataGridView2.Rows[i].Cells["colFeeid"].Value = dtf.Rows[i]["Feeid"].ToString();
                    dataGridView2.Rows[i].Cells["colFeeHead"].Value = dtf.Rows[i]["FeeHead"].ToString();
                    dataGridView2.Rows[i].Cells["colSelect2"].Value = true;
                }
            }
            else
            {
                dataGridView2.Columns["colSelect2"].ReadOnly = false;
                DataTable dtf = blc.getFeeHeadandFeeid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dtf.Rows.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells["colSN2"].Value = i + 1;
                    dataGridView2.Rows[i].Cells["colFeeid"].Value = dtf.Rows[i]["Feeid"].ToString();
                    dataGridView2.Rows[i].Cells["colFeeHead"].Value = dtf.Rows[i]["FeeHead"].ToString();
                    dataGridView2.Rows[i].Cells["colSelect2"].Value = false;
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int count = 0;
            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
               bool[] arr = new bool[dataGridView2.Rows.Count];

                arr[i] =Convert.ToBoolean(dataGridView2.Rows[i].Cells["colSelect2"].Value);
                foreach (bool b in arr )
                {
                    if (b == false)
                    {
                        count++;
                        
                    }
                }
            }
            if (count == dataGridView2.Rows.Count)
            {
                txtTaggedAmount.Text = string.Empty;
            }

        }

        private void btnClaimBill_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("Do you want to generate claim-bill?", "", MessageBoxButtons.OKCancel,MessageBoxIcon.None,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                return;
            }
             int m = 0;
              if(cboClass.SelectedIndex!=0 && cboSection.SelectedIndex != 0)
            {
                if (cboStudentName.SelectedIndex == 0)
                {
                    int month = 0;
                   
                    
                    int count = 0;
                    if(cboClaimMonth.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select Month");
                        return;
                    }
                    for(int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                       bool check=Convert.ToBoolean(dataGridView1.Rows[i].Cells["colSelect"].Value);
                        if (check == true)
                        {
                            month = Convert.ToInt32(dataGridView1.Rows[i].Cells["colMonthid"].Value);
                            count++;
                        }
                     }
                    DataTable dtBillClaim = blc.getBillClaimAllStudents(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), cboClaimMonth.Text, month);
                    DataTable dtmonth = blc.getMonthid();
                    for (int i = 0; i < dtmonth.Rows.Count; i++)
                    {
                        if (month < Convert.ToInt32(dtmonth.Rows[i]["Monthid"].ToString()))
                        {
                            MessageBox.Show("ClaimBill for this month not allowed");
                            return;
                        }

                    }

                    if (dtBillClaim.Rows.Count > 0)
                    {
                        MessageBox.Show("ClaimBill for this month is already done");
                        return;
                    }
                    if (count== 0)
                    {
                        MessageBox.Show("Please Select Month");
                        return;
                    }
                    DataTable dt = blc.getAllFeeTaggingDetail(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        int studentid = Convert.ToInt32(dt.Rows[i]["Studentid"].ToString());
                        string total = dt.Rows[i]["Total"].ToString();
                        string previousdue = dt.Rows[i]["SystemDue"].ToString();
                        int x = blc.insertinBillClaim(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), studentid, month, Convert.ToDecimal(total), mktxtClaimDate.Text, cboClaimMonth.Text, Convert.ToDecimal(previousdue));
                        
                        //
                        DataTable dtblc = blc.getClamidStudentidfromtblBillClaim();
                        int claimid = Convert.ToInt32(dtblc.Rows[0]["ClaimBillid"].ToString());
                        //int stdid = Convert.ToInt32(dtblc.Rows[0]["Studentid"].ToString());
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Columns[j].ColumnName != "Feetaggingid" && dt.Columns[j].ColumnName != "Classid" && dt.Columns[j].ColumnName != "Sectionid" && dt.Columns[j].ColumnName != "Studentid" && dt.Columns[j].ColumnName != "StudentName" && dt.Columns[j].ColumnName != "Total" && dt.Columns[j].ColumnName != "SystemDue")
                            {
                                string feehead = dt.Columns[j].ColumnName;

                                if (dt.Rows[i][j].ToString() == string.Empty)
                                {
                                    decimal amount = 0;
                                    int z = blc.insertinBillClaimDetails(claimid, studentid, feehead, amount);
                                    if(x>0 && z > 0)
                                    {
                                        m++;
                                    }
                                   
                                }
                                else
                                {
                                    decimal amount = Convert.ToDecimal(dt.Rows[i][j].ToString());
                                    int z = blc.insertinBillClaimDetails(claimid, studentid, feehead, amount);
                                    if (x > 0 && z > 0)
                                    {
                                        m++;
                                    }
                                   
                                }
                            }
                        }

                    }
                    if (m > 0)
                    {
                        MessageBox.Show("BillClaim  Successful");
                    }
                    else
                    {
                        MessageBox.Show("BillClaim not Successful");
                    }

                }
                else
                {
                    int month = 0;
                   
                    if (cboClaimMonth.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select Month");
                        return;
                    }
                    
                    int count = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        bool check = Convert.ToBoolean(dataGridView1.Rows[i].Cells["colSelect"].Value);
                        if (check == true)
                        {
                            month = Convert.ToInt32(dataGridView1.Rows[i].Cells["colMonthid"].Value);
                            count++;
                        }
                    }
                    DataTable dtBillClaim = blc.getBillClaimbyStudentid(Convert.ToInt32(cboStudentName.SelectedValue), cboClaimMonth.Text, month);
                    DataTable dtmonth = blc.getMonthid();
                    for (int i = 0; i < dtmonth.Rows.Count; i++)
                    {
                        if (month < Convert.ToInt32(dtmonth.Rows[i]["Monthid"].ToString()))
                        {
                            MessageBox.Show("ClaimBill for this month not allowed");
                            return;
                        }

                    }
                    if (dtBillClaim.Rows.Count > 0)
                    {
                        MessageBox.Show("ClaimBill for this month is already done");
                        return;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Please Select Month");
                        return;
                    }
                    DataTable dt = blc.getAllFeeTaggingDetails(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue),Convert.ToInt32(cboStudentName.SelectedValue));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int studentid = Convert.ToInt32(dt.Rows[i]["Studentid"].ToString());
                        string total = dt.Rows[i]["Total"].ToString();
                        string previousdue = dt.Rows[i]["SystemDue"].ToString();
                        int x = blc.insertinBillClaim(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), studentid, month, Convert.ToDecimal(total), mktxtClaimDate.Text, cboClaimMonth.Text, Convert.ToDecimal(previousdue));

                        //
                        DataTable dtblc = blc.getClamidStudentidfromtblBillClaim();
                        int claimid = Convert.ToInt32(dtblc.Rows[0]["ClaimBillid"].ToString());
                        //int stdid = Convert.ToInt32(dtblc.Rows[0]["Studentid"].ToString());
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Columns[j].ColumnName != "Feetaggingid" && dt.Columns[j].ColumnName != "Classid" && dt.Columns[j].ColumnName != "Sectionid" && dt.Columns[j].ColumnName != "Studentid" && dt.Columns[j].ColumnName != "StudentName" && dt.Columns[j].ColumnName != "Total" && dt.Columns[j].ColumnName != "SystemDue")
                            {
                                string feehead = dt.Columns[j].ColumnName;

                                if (dt.Rows[i][j].ToString() == string.Empty)
                                {
                                    decimal amount = 0;
                                    int z = blc.insertinBillClaimDetails(claimid, studentid, feehead, amount);
                                    if (x > 0 && z > 0)
                                    {
                                        m++;
                                    }

                                }
                                else
                                {
                                    decimal amount = Convert.ToDecimal(dt.Rows[i][j].ToString());
                                    int z = blc.insertinBillClaimDetails(claimid, studentid, feehead, amount);
                                    if (x > 0 && z > 0)
                                    {
                                        m++;
                                    }

                                }
                            }
                        }

                    }
                    if (m > 0)
                    {
                        MessageBox.Show("BillClaim  Successful");
                    }
                    else
                    {
                        MessageBox.Show("BillClaim not Successful");
                    }
                }
            }
        }

        private void cboClaimMonthforListtab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            //{
            //    if (cboStudentName.SelectedIndex != 0)
            //    {
            //        //
            //        dataGridView3.Rows.Clear();
            //        DataTable dtbcl = blc.getBillClaimlistbyClaimMonth(Convert.ToString(cboClaimMonthforListtab.DisplayMember));
            //        for (int i = 0; i < dtbcl.Rows.Count; i++)
            //        {
            //            dataGridView3.Rows.Add();
            //            dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
            //            dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
            //            dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
            //            dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
            //        }
            //        //
            //    }
            //    else
            //    {
            //        loadstudents();
            //        //
            //        dataGridView3.Rows.Clear();
            //        DataTable dtbcl = blc.getBillClaimlistbyClaimMonth(Convert.ToString(cboClaimMonthforListtab.DisplayMember));
            //        for (int i = 0; i < dtbcl.Rows.Count; i++)
            //        {
            //            dataGridView3.Rows.Add();
            //            dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
            //            dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
            //            dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
            //            dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
            //        }
            //        //
            //    }

            //}
                
            //        //
            //        dataGridView3.Rows.Clear();
            //DataTable dtbcl = blc.getBillClaimlistbyClaimMonth(Convert.ToString(cboClaimMonthforListtab.SelectedIndex));
            //for (int i = 0; i < dtbcl.Rows.Count; i++)
            //{
            //    dataGridView3.Rows.Add();
            //    dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
            //    dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
            //    dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
            //    dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
            //}
            ////
        }

        private void cboClaimMonthforListtab_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                if (cboStudentName.SelectedIndex != 0)
                {
                    //
                    
                    DataTable dtbcl = blc.getBillClaimlistbyClaimMonth(Convert.ToString(cboClaimMonthforListtab.DisplayMember));
                    dataGridView3.Rows.Clear();
                    for (int i = 0; i < dtbcl.Rows.Count; i++)
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
                        dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
                    }
                    //
                }
                else
                {
                   
                    //
                    
                    DataTable dtbcl = blc.getBillClaimlistbyClaimMonth(Convert.ToString(cboClaimMonthforListtab.DisplayMember));
                    dataGridView3.Rows.Clear();
                    for (int i = 0; i < dtbcl.Rows.Count; i++)
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[i].Cells["colClaimid"].Value = dtbcl.Rows[i]["ClaimBillid"].ToString();
                        dataGridView3.Rows[i].Cells["colStudentName3"].Value = dtbcl.Rows[i]["StudentName"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimDate"].Value = dtbcl.Rows[i]["ClaimDate"].ToString();
                        dataGridView3.Rows[i].Cells["colClaimMonth"].Value = dtbcl.Rows[i]["ClaimMonth"].ToString();
                    }
                    //
                }

            }
        }
    }
}
