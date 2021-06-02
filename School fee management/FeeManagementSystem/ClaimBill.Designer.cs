namespace FeeManagementSystem
{
    partial class ClaimBill
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClaimBill = new System.Windows.Forms.Button();
            this.cboClaimMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mktxtClaimDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTaggedAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreviousDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colSN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteClaim = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboClaimMonthforListtab = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colClaimid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(111, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 518);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPreview);
            this.tabPage1.Controls.Add(this.btnClaimBill);
            this.tabPage1.Controls.Add(this.cboClaimMonth);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.mktxtClaimDate);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(693, 299);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(154, 48);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Feetagging Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // btnClaimBill
            // 
            this.btnClaimBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClaimBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaimBill.Location = new System.Drawing.Point(592, 412);
            this.btnClaimBill.Name = "btnClaimBill";
            this.btnClaimBill.Size = new System.Drawing.Size(158, 61);
            this.btnClaimBill.TabIndex = 9;
            this.btnClaimBill.Text = "Claim Bill";
            this.btnClaimBill.UseVisualStyleBackColor = false;
            this.btnClaimBill.Click += new System.EventHandler(this.btnClaimBill_Click);
            // 
            // cboClaimMonth
            // 
            this.cboClaimMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClaimMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClaimMonth.FormattingEnabled = true;
            this.cboClaimMonth.Items.AddRange(new object[] {
            "Choose your Claim Month"});
            this.cboClaimMonth.Location = new System.Drawing.Point(358, 412);
            this.cboClaimMonth.Name = "cboClaimMonth";
            this.cboClaimMonth.Size = new System.Drawing.Size(148, 21);
            this.cboClaimMonth.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Claim Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Claim Date";
            // 
            // mktxtClaimDate
            // 
            this.mktxtClaimDate.Location = new System.Drawing.Point(87, 417);
            this.mktxtClaimDate.Mask = "00/00/0000";
            this.mktxtClaimDate.Name = "mktxtClaimDate";
            this.mktxtClaimDate.Size = new System.Drawing.Size(159, 20);
            this.mktxtClaimDate.TabIndex = 5;
            this.mktxtClaimDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTaggedAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPreviousDue);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(662, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Preview For Student";
            // 
            // txtTaggedAmount
            // 
            this.txtTaggedAmount.Location = new System.Drawing.Point(16, 149);
            this.txtTaggedAmount.Name = "txtTaggedAmount";
            this.txtTaggedAmount.ReadOnly = true;
            this.txtTaggedAmount.Size = new System.Drawing.Size(169, 22);
            this.txtTaggedAmount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tagged Amount";
            // 
            // txtPreviousDue
            // 
            this.txtPreviousDue.Location = new System.Drawing.Point(16, 71);
            this.txtPreviousDue.Name = "txtPreviousDue";
            this.txtPreviousDue.ReadOnly = true;
            this.txtPreviousDue.Size = new System.Drawing.Size(169, 22);
            this.txtPreviousDue.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "PreviousDue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSelectAll);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 387);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose FeeHeads";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Checked = true;
            this.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelectAll.Location = new System.Drawing.Point(21, 361);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(143, 20);
            this.chkSelectAll.TabIndex = 1;
            this.chkSelectAll.Text = "Select all FeeHead";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN2,
            this.colFeeid,
            this.colFeeHead,
            this.colSelect2});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 326);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // colSN2
            // 
            this.colSN2.HeaderText = "SN";
            this.colSN2.Name = "colSN2";
            this.colSN2.Width = 40;
            // 
            // colFeeid
            // 
            this.colFeeid.HeaderText = "Feeid";
            this.colFeeid.Name = "colFeeid";
            this.colFeeid.Visible = false;
            // 
            // colFeeHead
            // 
            this.colFeeHead.HeaderText = "FeeHead";
            this.colFeeHead.Name = "colFeeHead";
            this.colFeeHead.Width = 150;
            // 
            // colSelect2
            // 
            this.colSelect2.HeaderText = "Select";
            this.colSelect2.Name = "colSelect2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Month";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colMonthid,
            this.colMonth,
            this.colSelect});
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // colSN
            // 
            this.colSN.HeaderText = "SN";
            this.colSN.Name = "colSN";
            this.colSN.Width = 40;
            // 
            // colMonthid
            // 
            this.colMonthid.HeaderText = "Monthid";
            this.colMonthid.Name = "colMonthid";
            this.colMonthid.Visible = false;
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Month";
            this.colMonth.Name = "colMonth";
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteClaim);
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.cboClaimMonthforListtab);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClaim
            // 
            this.btnDeleteClaim.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteClaim.Location = new System.Drawing.Point(632, 16);
            this.btnDeleteClaim.Name = "btnDeleteClaim";
            this.btnDeleteClaim.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteClaim.TabIndex = 12;
            this.btnDeleteClaim.Text = "Delete Claim";
            this.btnDeleteClaim.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrint.Location = new System.Drawing.Point(446, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(125, 35);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // cboClaimMonthforListtab
            // 
            this.cboClaimMonthforListtab.FormattingEnabled = true;
            this.cboClaimMonthforListtab.Location = new System.Drawing.Point(108, 24);
            this.cboClaimMonthforListtab.Name = "cboClaimMonthforListtab";
            this.cboClaimMonthforListtab.Size = new System.Drawing.Size(148, 21);
            this.cboClaimMonthforListtab.TabIndex = 10;
            this.cboClaimMonthforListtab.SelectedIndexChanged += new System.EventHandler(this.cboClaimMonthforListtab_SelectedIndexChanged);
            this.cboClaimMonthforListtab.SelectedValueChanged += new System.EventHandler(this.cboClaimMonthforListtab_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Claim Month";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClaimid,
            this.colStudentName3,
            this.colClaimDate,
            this.colClaimMonth});
            this.dataGridView3.Location = new System.Drawing.Point(7, 74);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(920, 402);
            this.dataGridView3.TabIndex = 0;
            // 
            // colClaimid
            // 
            this.colClaimid.HeaderText = "Claimid";
            this.colClaimid.Name = "colClaimid";
            // 
            // colStudentName3
            // 
            this.colStudentName3.HeaderText = "StudentName";
            this.colStudentName3.Name = "colStudentName3";
            this.colStudentName3.Width = 300;
            // 
            // colClaimDate
            // 
            this.colClaimDate.HeaderText = "ClaimDate";
            this.colClaimDate.Name = "colClaimDate";
            this.colClaimDate.Width = 200;
            // 
            // colClaimMonth
            // 
            this.colClaimMonth.HeaderText = "ClaimMonth";
            this.colClaimMonth.Name = "colClaimMonth";
            this.colClaimMonth.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "StudentName";
            // 
            // cboStudentName
            // 
            this.cboStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStudentName.FormattingEnabled = true;
            this.cboStudentName.Location = new System.Drawing.Point(513, 12);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(286, 21);
            this.cboStudentName.TabIndex = 40;
            this.cboStudentName.SelectedValueChanged += new System.EventHandler(this.cboStudentName_SelectedValueChanged);
            // 
            // cboSection
            // 
            this.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(269, 12);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(149, 21);
            this.cboSection.TabIndex = 39;
            this.cboSection.SelectedValueChanged += new System.EventHandler(this.cboSection_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(55, 12);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(149, 21);
            this.cboClass.TabIndex = 38;
            this.cboClass.SelectedValueChanged += new System.EventHandler(this.cboClass_SelectedValueChanged);
            // 
            // ClaimBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStudentName);
            this.Controls.Add(this.cboSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClaimBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaimBill";
            this.Load += new System.EventHandler(this.ClaimBill_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStudentName;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClaimBill;
        private System.Windows.Forms.ComboBox cboClaimMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mktxtClaimDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTaggedAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreviousDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeHead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect2;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboClaimMonthforListtab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDeleteClaim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimMonth;
    }
}