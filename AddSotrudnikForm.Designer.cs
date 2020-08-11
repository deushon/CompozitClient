namespace CompozitClient
{
    partial class AddSotrudnikForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FamilTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OtchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DolgnostTextBox = new System.Windows.Forms.TextBox();
            this.OtdelSearchTextBox = new System.Windows.Forms.TextBox();
            this.OtdeldataGridView = new System.Windows.Forms.DataGridView();
            this.iDOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nACHOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESTOOTDELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTDELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNBASEDataSet1 = new CompozitClient.INBASEDataSet1();
            this.oTDELTableAdapter = new CompozitClient.INBASEDataSet1TableAdapters.OTDELTableAdapter();
            this.ChengeCheckBox = new System.Windows.Forms.CheckBox();
            this.WorkcheckBox = new System.Windows.Forms.CheckBox();
            this.NachCheckBox = new System.Windows.Forms.CheckBox();
            this.ChousedOtdelLabel = new System.Windows.Forms.Label();
            this.sotrudTableAdapter2 = new CompozitClient.INBASEDataSet1TableAdapters.SOTRUDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtdeldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBASEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(185, 31);
            this.NameTextBox.MaxLength = 80;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(167, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 332);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(513, 30);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // FamilTextBox
            // 
            this.FamilTextBox.Location = new System.Drawing.Point(12, 31);
            this.FamilTextBox.MaxLength = 80;
            this.FamilTextBox.Name = "FamilTextBox";
            this.FamilTextBox.Size = new System.Drawing.Size(167, 26);
            this.FamilTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // OtchTextBox
            // 
            this.OtchTextBox.Location = new System.Drawing.Point(358, 31);
            this.OtchTextBox.MaxLength = 80;
            this.OtchTextBox.Name = "OtchTextBox";
            this.OtchTextBox.Size = new System.Drawing.Size(167, 26);
            this.OtchTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Должность";
            // 
            // DolgnostTextBox
            // 
            this.DolgnostTextBox.Location = new System.Drawing.Point(12, 82);
            this.DolgnostTextBox.MaxLength = 120;
            this.DolgnostTextBox.Name = "DolgnostTextBox";
            this.DolgnostTextBox.Size = new System.Drawing.Size(513, 26);
            this.DolgnostTextBox.TabIndex = 3;
            // 
            // OtdelSearchTextBox
            // 
            this.OtdelSearchTextBox.Enabled = false;
            this.OtdelSearchTextBox.Location = new System.Drawing.Point(12, 133);
            this.OtdelSearchTextBox.Name = "OtdelSearchTextBox";
            this.OtdelSearchTextBox.Size = new System.Drawing.Size(513, 26);
            this.OtdelSearchTextBox.TabIndex = 9;
            this.OtdelSearchTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // OtdeldataGridView
            // 
            this.OtdeldataGridView.AutoGenerateColumns = false;
            this.OtdeldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtdeldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOTDELDataGridViewTextBoxColumn,
            this.nAMEOTDELDataGridViewTextBoxColumn,
            this.tELOTDELDataGridViewTextBoxColumn,
            this.nACHOTDELDataGridViewTextBoxColumn,
            this.aDRESSOTDELDataGridViewTextBoxColumn,
            this.mESTOOTDELDataGridViewTextBoxColumn});
            this.OtdeldataGridView.DataSource = this.oTDELBindingSource;
            this.OtdeldataGridView.Enabled = false;
            this.OtdeldataGridView.Location = new System.Drawing.Point(12, 165);
            this.OtdeldataGridView.Name = "OtdeldataGridView";
            this.OtdeldataGridView.Size = new System.Drawing.Size(511, 161);
            this.OtdeldataGridView.TabIndex = 11;
            this.OtdeldataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.OtdeldataGridView_CellPainting);
            this.OtdeldataGridView.Click += new System.EventHandler(this.OtdeldataGridView_Click);
            // 
            // iDOTDELDataGridViewTextBoxColumn
            // 
            this.iDOTDELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDOTDELDataGridViewTextBoxColumn.DataPropertyName = "ID_OTDEL";
            this.iDOTDELDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDOTDELDataGridViewTextBoxColumn.Name = "iDOTDELDataGridViewTextBoxColumn";
            this.iDOTDELDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOTDELDataGridViewTextBoxColumn.Width = 50;
            // 
            // nAMEOTDELDataGridViewTextBoxColumn
            // 
            this.nAMEOTDELDataGridViewTextBoxColumn.DataPropertyName = "NAME_OTDEL";
            this.nAMEOTDELDataGridViewTextBoxColumn.HeaderText = "Название отдела";
            this.nAMEOTDELDataGridViewTextBoxColumn.Name = "nAMEOTDELDataGridViewTextBoxColumn";
            this.nAMEOTDELDataGridViewTextBoxColumn.Width = 400;
            // 
            // tELOTDELDataGridViewTextBoxColumn
            // 
            this.tELOTDELDataGridViewTextBoxColumn.DataPropertyName = "TEL_OTDEL";
            this.tELOTDELDataGridViewTextBoxColumn.HeaderText = "TEL_OTDEL";
            this.tELOTDELDataGridViewTextBoxColumn.Name = "tELOTDELDataGridViewTextBoxColumn";
            this.tELOTDELDataGridViewTextBoxColumn.Visible = false;
            // 
            // nACHOTDELDataGridViewTextBoxColumn
            // 
            this.nACHOTDELDataGridViewTextBoxColumn.DataPropertyName = "NACH_OTDEL";
            this.nACHOTDELDataGridViewTextBoxColumn.HeaderText = "NACH_OTDEL";
            this.nACHOTDELDataGridViewTextBoxColumn.Name = "nACHOTDELDataGridViewTextBoxColumn";
            this.nACHOTDELDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDRESSOTDELDataGridViewTextBoxColumn
            // 
            this.aDRESSOTDELDataGridViewTextBoxColumn.DataPropertyName = "ADRESS_OTDEL";
            this.aDRESSOTDELDataGridViewTextBoxColumn.HeaderText = "ADRESS_OTDEL";
            this.aDRESSOTDELDataGridViewTextBoxColumn.Name = "aDRESSOTDELDataGridViewTextBoxColumn";
            this.aDRESSOTDELDataGridViewTextBoxColumn.Visible = false;
            // 
            // mESTOOTDELDataGridViewTextBoxColumn
            // 
            this.mESTOOTDELDataGridViewTextBoxColumn.DataPropertyName = "MESTO_OTDEL";
            this.mESTOOTDELDataGridViewTextBoxColumn.HeaderText = "MESTO_OTDEL";
            this.mESTOOTDELDataGridViewTextBoxColumn.Name = "mESTOOTDELDataGridViewTextBoxColumn";
            this.mESTOOTDELDataGridViewTextBoxColumn.Visible = false;
            // 
            // oTDELBindingSource
            // 
            this.oTDELBindingSource.DataMember = "OTDEL";
            this.oTDELBindingSource.DataSource = this.iNBASEDataSet1;
            // 
            // iNBASEDataSet1
            // 
            this.iNBASEDataSet1.DataSetName = "INBASEDataSet1";
            this.iNBASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oTDELTableAdapter
            // 
            this.oTDELTableAdapter.ClearBeforeFill = true;
            // 
            // ChengeCheckBox
            // 
            this.ChengeCheckBox.AutoSize = true;
            this.ChengeCheckBox.Location = new System.Drawing.Point(236, 110);
            this.ChengeCheckBox.Name = "ChengeCheckBox";
            this.ChengeCheckBox.Size = new System.Drawing.Size(94, 23);
            this.ChengeCheckBox.TabIndex = 12;
            this.ChengeCheckBox.Text = "Изменить";
            this.ChengeCheckBox.UseVisualStyleBackColor = true;
            this.ChengeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // WorkcheckBox
            // 
            this.WorkcheckBox.AutoSize = true;
            this.WorkcheckBox.Checked = true;
            this.WorkcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WorkcheckBox.Location = new System.Drawing.Point(103, 59);
            this.WorkcheckBox.Name = "WorkcheckBox";
            this.WorkcheckBox.Size = new System.Drawing.Size(294, 23);
            this.WorkcheckBox.TabIndex = 13;
            this.WorkcheckBox.Text = "Сотрудник работает в настоящее время";
            this.WorkcheckBox.UseVisualStyleBackColor = true;
            // 
            // NachCheckBox
            // 
            this.NachCheckBox.AutoSize = true;
            this.NachCheckBox.Location = new System.Drawing.Point(336, 110);
            this.NachCheckBox.Name = "NachCheckBox";
            this.NachCheckBox.Size = new System.Drawing.Size(189, 23);
            this.NachCheckBox.TabIndex = 14;
            this.NachCheckBox.Text = "Назначить начальником";
            this.NachCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChousedOtdelLabel
            // 
            this.ChousedOtdelLabel.AutoSize = true;
            this.ChousedOtdelLabel.Location = new System.Drawing.Point(8, 111);
            this.ChousedOtdelLabel.Name = "ChousedOtdelLabel";
            this.ChousedOtdelLabel.Size = new System.Drawing.Size(138, 19);
            this.ChousedOtdelLabel.TabIndex = 15;
            this.ChousedOtdelLabel.Text = "Выбран отдел с ID:";
            // 
            // sotrudTableAdapter2
            // 
            this.sotrudTableAdapter2.ClearBeforeFill = true;
            // 
            // AddSotrudnikForm
            // 
            this.ClientSize = new System.Drawing.Size(535, 374);
            this.Controls.Add(this.ChousedOtdelLabel);
            this.Controls.Add(this.NachCheckBox);
            this.Controls.Add(this.WorkcheckBox);
            this.Controls.Add(this.ChengeCheckBox);
            this.Controls.Add(this.OtdeldataGridView);
            this.Controls.Add(this.OtdelSearchTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DolgnostTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OtchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FamilTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(551, 413);
            this.MinimumSize = new System.Drawing.Size(551, 413);
            this.Name = "AddSotrudnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добваление нового сотрудника";
            this.Load += new System.EventHandler(this.AddSotrudnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtdeldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBASEDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSorudnikButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private INBASEDataSet1TableAdapters.SOTRUDTableAdapter sotrudTableAdapter1;
        private int OTDELID;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FamilTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DolgnostTextBox;
        private System.Windows.Forms.TextBox OtdelSearchTextBox;
        private System.Windows.Forms.DataGridView OtdeldataGridView;
        private INBASEDataSet1 iNBASEDataSet1;
        private System.Windows.Forms.BindingSource oTDELBindingSource;
        private INBASEDataSet1TableAdapters.OTDELTableAdapter oTDELTableAdapter;
        private System.Windows.Forms.CheckBox ChengeCheckBox;
        private System.Windows.Forms.CheckBox WorkcheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nACHOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESTOOTDELDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox NachCheckBox;
        private System.Windows.Forms.Label ChousedOtdelLabel;
        private INBASEDataSet1TableAdapters.SOTRUDTableAdapter sotrudTableAdapter2;
    }
}