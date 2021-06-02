namespace FeeManagementSystem
{
    partial class BillClaimReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FeeManagementSystemDataSet = new FeeManagementSystem.FeeManagementSystemDataSet();
            this.tblBillClaimDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBillClaimDetailsTableAdapter = new FeeManagementSystem.FeeManagementSystemDataSetTableAdapters.tblBillClaimDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FeeManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillClaimDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblBillClaimDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FeeManagementSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("http://localhost/reportserver/Report1.rdlc", System.UriKind.Absolute);
            this.reportViewer1.Size = new System.Drawing.Size(666, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // FeeManagementSystemDataSet
            // 
            this.FeeManagementSystemDataSet.DataSetName = "FeeManagementSystemDataSet";
            this.FeeManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBillClaimDetailsBindingSource
            // 
            this.tblBillClaimDetailsBindingSource.DataMember = "tblBillClaimDetails";
            this.tblBillClaimDetailsBindingSource.DataSource = this.FeeManagementSystemDataSet;
            // 
            // tblBillClaimDetailsTableAdapter
            // 
            this.tblBillClaimDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // BillClaimReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillClaimReport";
            this.Text = "BillClaimReport";
            this.Load += new System.EventHandler(this.BillClaimReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeeManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillClaimDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblBillClaimDetailsBindingSource;
        private FeeManagementSystemDataSet FeeManagementSystemDataSet;
        private FeeManagementSystemDataSetTableAdapters.tblBillClaimDetailsTableAdapter tblBillClaimDetailsTableAdapter;
    }
}