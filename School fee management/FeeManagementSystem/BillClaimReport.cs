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
    public partial class BillClaimReport : Form
    {
       
       DataTable dt= new DataTable();
        string _studentName, _Class, _Section,_claimid, _ClaimMonth, _ClaimDate, _total, _previousdue, _grandtotal;
       
      
        public BillClaimReport(DataTable datasource, string studentname, string Class, string Section,int claimid, string claimmonth, string claimdate, decimal total, decimal previousdue)
        {
            InitializeComponent();
            dt = datasource;
            _studentName = studentname;
            _Class = Class;
            _Section = Section;
            _claimid = Convert.ToString(claimid);
            _ClaimMonth = claimmonth;
            _ClaimDate = claimdate;
            _total =Convert.ToString(total);
            _previousdue = Convert.ToString(previousdue);
            _grandtotal =Convert.ToString(total + previousdue);
        }

        private void BillClaimReport_Load(object sender, EventArgs e)
        {
            ////// TODO: This line of code loads data into the 'FeeManagementSystemDataSet.tblBillClaimDetails' table. You can move, or remove it, as needed.
            ////this.tblBillClaimDetailsTableAdapter.Fill(this.FeeManagementSystemDataSet.tblBillClaimDetails);
            

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
               new Microsoft.Reporting.WinForms.ReportParameter("pStudentName",_studentName),
                new Microsoft.Reporting.WinForms.ReportParameter("pClass",_Class),
                 new Microsoft.Reporting.WinForms.ReportParameter("pSection",_Section),
                  new Microsoft.Reporting.WinForms.ReportParameter("pClaimDate",_ClaimDate),
                   new Microsoft.Reporting.WinForms.ReportParameter("pClaimid",_claimid),
                    new Microsoft.Reporting.WinForms.ReportParameter("pClaimMonth",_ClaimMonth),
                     new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                      new Microsoft.Reporting.WinForms.ReportParameter("pPreviousDue",_previousdue),
                       new Microsoft.Reporting.WinForms.ReportParameter("pGrandTotal",_grandtotal)
          };

            this.reportViewer1.RefreshReport();
        }
    }
}
