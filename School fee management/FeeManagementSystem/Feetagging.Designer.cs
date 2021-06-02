namespace FeeManagementSystem
{
    partial class Feetagging
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeetaggingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystemDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(696, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(576, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 47);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Tagging";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colFeetaggingid,
            this.colClassid,
            this.colSectionid,
            this.colStudentid,
            this.colStudentName,
            this.colTotal,
            this.colSystemDue,
            this.colGrandTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1225, 431);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // cboSection
            // 
            this.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(279, 11);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(149, 21);
            this.cboSection.TabIndex = 1;
            this.cboSection.SelectedIndexChanged += new System.EventHandler(this.cboSection_SelectedIndexChanged);
            this.cboSection.SelectedValueChanged += new System.EventHandler(this.cboSection_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(69, 12);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(149, 21);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedValueChanged += new System.EventHandler(this.cboClass_SelectedValueChanged);
            // 
            // cboStudentName
            // 
            this.cboStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStudentName.FormattingEnabled = true;
            this.cboStudentName.Location = new System.Drawing.Point(102, 48);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(286, 21);
            this.cboStudentName.TabIndex = 2;
            this.cboStudentName.SelectedIndexChanged += new System.EventHandler(this.cboStudentName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "StudentName";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(453, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 47);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "LoadTagging";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // colSN
            // 
            this.colSN.Frozen = true;
            this.colSN.HeaderText = "SN";
            this.colSN.Name = "colSN";
            this.colSN.Width = 40;
            // 
            // colFeetaggingid
            // 
            this.colFeetaggingid.HeaderText = "Feetaggingid";
            this.colFeetaggingid.Name = "colFeetaggingid";
            this.colFeetaggingid.Visible = false;
            // 
            // colClassid
            // 
            this.colClassid.HeaderText = "Classid";
            this.colClassid.Name = "colClassid";
            this.colClassid.Visible = false;
            // 
            // colSectionid
            // 
            this.colSectionid.HeaderText = "Sectionid";
            this.colSectionid.Name = "colSectionid";
            this.colSectionid.Visible = false;
            // 
            // colStudentid
            // 
            this.colStudentid.HeaderText = "Studentid";
            this.colStudentid.Name = "colStudentid";
            this.colStudentid.Visible = false;
            // 
            // colStudentName
            // 
            this.colStudentName.Frozen = true;
            this.colStudentName.HeaderText = "StudentName";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.Width = 200;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colSystemDue
            // 
            this.colSystemDue.HeaderText = "SystemDue";
            this.colSystemDue.Name = "colSystemDue";
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.HeaderText = "GrandTotal";
            this.colGrandTotal.Name = "colGrandTotal";
            // 
            // Feetagging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 568);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStudentName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Name = "Feetagging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feetagging";
            this.Load += new System.EventHandler(this.Feetagging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeetaggingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystemDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
    }
}