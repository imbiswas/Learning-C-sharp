namespace FeeManagementSystem
{
    partial class BillPayment
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewDueAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdvanceAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFeeHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountbyPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountByAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkIndividualPayment = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreviousAdvance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mkttxtLastBillingDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mktxtBillingDate = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboClaimMonthforListtab = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "StudentName";
            // 
            // cboStudentName
            // 
            this.cboStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStudentName.FormattingEnabled = true;
            this.cboStudentName.Location = new System.Drawing.Point(501, 12);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(286, 21);
            this.cboStudentName.TabIndex = 47;
            this.cboStudentName.SelectedValueChanged += new System.EventHandler(this.cboStudentName_SelectedValueChanged);
            // 
            // cboSection
            // 
            this.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(257, 12);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(149, 21);
            this.cboSection.TabIndex = 46;
            this.cboSection.SelectedValueChanged += new System.EventHandler(this.cboSection_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(43, 12);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(149, 21);
            this.cboClass.TabIndex = 45;
            this.cboClass.SelectedValueChanged += new System.EventHandler(this.cboClass_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(111, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 483);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtNewDueAmount);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtDiscountAmount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtAdvanceAmount);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtDueAmount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtPaidAmount);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.chkIndividualPayment);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtPreviousAdvance);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.mkttxtLastBillingDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.mktxtBillingDate);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Remarks";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(91, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 59);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(810, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 43);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(810, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(699, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "NewDueAmount";
            // 
            // txtNewDueAmount
            // 
            this.txtNewDueAmount.Location = new System.Drawing.Point(810, 257);
            this.txtNewDueAmount.Name = "txtNewDueAmount";
            this.txtNewDueAmount.Size = new System.Drawing.Size(141, 22);
            this.txtNewDueAmount.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(699, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "DiscountAmount";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(810, 202);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(141, 22);
            this.txtDiscountAmount.TabIndex = 14;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.txtDiscountAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "AdvanceAmount";
            // 
            // txtAdvanceAmount
            // 
            this.txtAdvanceAmount.Location = new System.Drawing.Point(810, 147);
            this.txtAdvanceAmount.Name = "txtAdvanceAmount";
            this.txtAdvanceAmount.Size = new System.Drawing.Size(141, 22);
            this.txtAdvanceAmount.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "DueAmount";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(810, 92);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(141, 22);
            this.txtDueAmount.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "PaidAmount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(535, 368);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(141, 22);
            this.txtPaidAmount.TabIndex = 8;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeeHead,
            this.colAmount,
            this.colDiscountbyPercentage,
            this.colDiscountByAmount,
            this.colPaidAmount});
            this.dataGridView1.Location = new System.Drawing.Point(7, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 293);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // colFeeHead
            // 
            this.colFeeHead.HeaderText = "FeeHead";
            this.colFeeHead.Name = "colFeeHead";
            this.colFeeHead.Width = 200;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // colDiscountbyPercentage
            // 
            this.colDiscountbyPercentage.HeaderText = "Dis.ByPer";
            this.colDiscountbyPercentage.Name = "colDiscountbyPercentage";
            // 
            // colDiscountByAmount
            // 
            this.colDiscountByAmount.HeaderText = "Dis.ByAmount";
            this.colDiscountByAmount.Name = "colDiscountByAmount";
            // 
            // colPaidAmount
            // 
            this.colPaidAmount.HeaderText = "PaidAmount";
            this.colPaidAmount.Name = "colPaidAmount";
            // 
            // chkIndividualPayment
            // 
            this.chkIndividualPayment.AutoSize = true;
            this.chkIndividualPayment.Location = new System.Drawing.Point(865, 21);
            this.chkIndividualPayment.Name = "chkIndividualPayment";
            this.chkIndividualPayment.Size = new System.Drawing.Size(137, 20);
            this.chkIndividualPayment.TabIndex = 6;
            this.chkIndividualPayment.Text = "IndividualPayment";
            this.chkIndividualPayment.UseVisualStyleBackColor = true;
            this.chkIndividualPayment.CheckedChanged += new System.EventHandler(this.chkIndividualPayment_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "PreviousAdvance";
            // 
            // txtPreviousAdvance
            // 
            this.txtPreviousAdvance.Location = new System.Drawing.Point(682, 19);
            this.txtPreviousAdvance.Name = "txtPreviousAdvance";
            this.txtPreviousAdvance.Size = new System.Drawing.Size(141, 22);
            this.txtPreviousAdvance.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "LastBillingDate";
            // 
            // mkttxtLastBillingDate
            // 
            this.mkttxtLastBillingDate.Location = new System.Drawing.Point(369, 19);
            this.mkttxtLastBillingDate.Mask = "00/00/0000";
            this.mkttxtLastBillingDate.Name = "mkttxtLastBillingDate";
            this.mkttxtLastBillingDate.Size = new System.Drawing.Size(133, 22);
            this.mkttxtLastBillingDate.TabIndex = 2;
            this.mkttxtLastBillingDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "BillingDate";
            // 
            // mktxtBillingDate
            // 
            this.mktxtBillingDate.Location = new System.Drawing.Point(91, 19);
            this.mktxtBillingDate.Mask = "00/00/0000";
            this.mktxtBillingDate.Name = "mktxtBillingDate";
            this.mktxtBillingDate.Size = new System.Drawing.Size(133, 22);
            this.mktxtBillingDate.TabIndex = 0;
            this.mktxtBillingDate.ValidatingType = typeof(System.DateTime);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cboClaimMonthforListtab);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(763, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(575, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cboClaimMonthforListtab
            // 
            this.cboClaimMonthforListtab.FormattingEnabled = true;
            this.cboClaimMonthforListtab.Location = new System.Drawing.Point(119, 9);
            this.cboClaimMonthforListtab.Name = "cboClaimMonthforListtab";
            this.cboClaimMonthforListtab.Size = new System.Drawing.Size(148, 24);
            this.cboClaimMonthforListtab.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Claim Month";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1040, 375);
            this.dataGridView2.TabIndex = 13;
            // 
            // BillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStudentName);
            this.Controls.Add(this.cboSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Name = "BillPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillPayment";
            this.Load += new System.EventHandler(this.BillPayment_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStudentName;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountbyPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountByAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidAmount;
        private System.Windows.Forms.CheckBox chkIndividualPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreviousAdvance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mkttxtLastBillingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mktxtBillingDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdvanceAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNewDueAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cboClaimMonthforListtab;
        private System.Windows.Forms.Label label13;
    }
}