namespace CompozitClient
{
    partial class ConectForm
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
            this.TypeConect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChousedDeviceLabel = new System.Windows.Forms.Label();
            this.DeviceSearchTextBox = new System.Windows.Forms.TextBox();
            this.DeviceDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeDevComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iNBASEDataSet1 = new CompozitClient.INBASEDataSet1();
            this.dEVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEVICETableAdapter = new CompozitClient.INBASEDataSet1TableAdapters.DEVICETableAdapter();
            this.iDDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEVDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBASEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeConect
            // 
            this.TypeConect.AutoCompleteCustomSource.AddRange(new string[] {
            "USB",
            "Витая пара",
            "Оптика",
            "Wi-Fi"});
            this.TypeConect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TypeConect.FormattingEnabled = true;
            this.TypeConect.Items.AddRange(new object[] {
            "USB",
            "Витая пара",
            "Оптика",
            "Wi-Fi"});
            this.TypeConect.Location = new System.Drawing.Point(13, 32);
            this.TypeConect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeConect.Name = "TypeConect";
            this.TypeConect.Size = new System.Drawing.Size(591, 27);
            this.TypeConect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Укажите вид подключения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "К чему подключено устройство:";
            // 
            // ChousedDeviceLabel
            // 
            this.ChousedDeviceLabel.AutoSize = true;
            this.ChousedDeviceLabel.Location = new System.Drawing.Point(12, 303);
            this.ChousedDeviceLabel.Name = "ChousedDeviceLabel";
            this.ChousedDeviceLabel.Size = new System.Drawing.Size(184, 19);
            this.ChousedDeviceLabel.TabIndex = 10;
            this.ChousedDeviceLabel.Text = "Выбрано устройство с ID:";
            // 
            // DeviceSearchTextBox
            // 
            this.DeviceSearchTextBox.Location = new System.Drawing.Point(134, 119);
            this.DeviceSearchTextBox.MaxLength = 100;
            this.DeviceSearchTextBox.Name = "DeviceSearchTextBox";
            this.DeviceSearchTextBox.Size = new System.Drawing.Size(470, 26);
            this.DeviceSearchTextBox.TabIndex = 3;
            this.DeviceSearchTextBox.TextChanged += new System.EventHandler(this.SotrudnikSearchTextBox_TextChanged);
            // 
            // DeviceDataGridView
            // 
            this.DeviceDataGridView.AutoGenerateColumns = false;
            this.DeviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDEVICEDataGridViewTextBoxColumn,
            this.tYPEDEVICEDataGridViewTextBoxColumn,
            this.nAMEDEVICEDataGridViewTextBoxColumn,
            this.dEVDEVICEDataGridViewTextBoxColumn});
            this.DeviceDataGridView.DataSource = this.dEVICEBindingSource;
            this.DeviceDataGridView.Location = new System.Drawing.Point(13, 151);
            this.DeviceDataGridView.Name = "DeviceDataGridView";
            this.DeviceDataGridView.Size = new System.Drawing.Size(591, 145);
            this.DeviceDataGridView.TabIndex = 4;
            this.DeviceDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DeviceDataGridView_CellPainting);
            this.DeviceDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeviceDataGridView_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип устройства:";
            // 
            // TypeDevComboBox
            // 
            this.TypeDevComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ПК",
            "Комутатор",
            "Маршрутизатор",
            "Модем"});
            this.TypeDevComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TypeDevComboBox.FormattingEnabled = true;
            this.TypeDevComboBox.Items.AddRange(new object[] {
            "ПК",
            "Комутатор",
            "Маршрутизатор",
            "Модем"});
            this.TypeDevComboBox.Location = new System.Drawing.Point(134, 85);
            this.TypeDevComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeDevComboBox.Name = "TypeDevComboBox";
            this.TypeDevComboBox.Size = new System.Drawing.Size(470, 27);
            this.TypeDevComboBox.TabIndex = 2;
            this.TypeDevComboBox.TextChanged += new System.EventHandler(this.TypeDevComboBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Название:";
            // 
            // iNBASEDataSet1
            // 
            this.iNBASEDataSet1.DataSetName = "INBASEDataSet1";
            this.iNBASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEVICEBindingSource
            // 
            this.dEVICEBindingSource.DataMember = "DEVICE";
            this.dEVICEBindingSource.DataSource = this.iNBASEDataSet1;
            // 
            // dEVICETableAdapter
            // 
            this.dEVICETableAdapter.ClearBeforeFill = true;
            // 
            // iDDEVICEDataGridViewTextBoxColumn
            // 
            this.iDDEVICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDEVICEDataGridViewTextBoxColumn.DataPropertyName = "ID_DEVICE";
            this.iDDEVICEDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDEVICEDataGridViewTextBoxColumn.Name = "iDDEVICEDataGridViewTextBoxColumn";
            this.iDDEVICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDEVICEDataGridViewTextBoxColumn.Width = 50;
            // 
            // tYPEDEVICEDataGridViewTextBoxColumn
            // 
            this.tYPEDEVICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tYPEDEVICEDataGridViewTextBoxColumn.DataPropertyName = "TYPE_DEVICE";
            this.tYPEDEVICEDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.tYPEDEVICEDataGridViewTextBoxColumn.Name = "tYPEDEVICEDataGridViewTextBoxColumn";
            this.tYPEDEVICEDataGridViewTextBoxColumn.Width = 61;
            // 
            // nAMEDEVICEDataGridViewTextBoxColumn
            // 
            this.nAMEDEVICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAMEDEVICEDataGridViewTextBoxColumn.DataPropertyName = "NAME_DEVICE";
            this.nAMEDEVICEDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nAMEDEVICEDataGridViewTextBoxColumn.Name = "nAMEDEVICEDataGridViewTextBoxColumn";
            this.nAMEDEVICEDataGridViewTextBoxColumn.Width = 98;
            // 
            // dEVDEVICEDataGridViewTextBoxColumn
            // 
            this.dEVDEVICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dEVDEVICEDataGridViewTextBoxColumn.DataPropertyName = "DEV_DEVICE";
            this.dEVDEVICEDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.dEVDEVICEDataGridViewTextBoxColumn.Name = "dEVDEVICEDataGridViewTextBoxColumn";
            this.dEVDEVICEDataGridViewTextBoxColumn.Width = 138;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeDevComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChousedDeviceLabel);
            this.Controls.Add(this.DeviceSearchTextBox);
            this.Controls.Add(this.DeviceDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeConect);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConectForm";
            this.Load += new System.EventHandler(this.ConectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBASEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeConect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChousedDeviceLabel;
        private System.Windows.Forms.TextBox DeviceSearchTextBox;
        private System.Windows.Forms.DataGridView DeviceDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeDevComboBox;
        private System.Windows.Forms.Label label4;
        private INBASEDataSet1 iNBASEDataSet1;
        private System.Windows.Forms.BindingSource dEVICEBindingSource;
        private INBASEDataSet1TableAdapters.DEVICETableAdapter dEVICETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}