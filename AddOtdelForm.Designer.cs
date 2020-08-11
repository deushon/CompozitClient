namespace CompozitClient
{
    partial class AddOtdelForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KabinetTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EtagTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.otdelTableAdapter1 = new CompozitClient.INBASEDataSet1TableAdapters.OTDELTableAdapter();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Название отдела:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 31);
            this.NameTextBox.MaxLength = 240;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(507, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // TelTextBox
            // 
            this.TelTextBox.Location = new System.Drawing.Point(16, 82);
            this.TelTextBox.MaxLength = 120;
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.Size = new System.Drawing.Size(507, 26);
            this.TelTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон:";
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(16, 133);
            this.AdresTextBox.MaxLength = 128;
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(507, 26);
            this.AdresTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес:";
            // 
            // KabinetTextBox
            // 
            this.KabinetTextBox.Location = new System.Drawing.Point(271, 190);
            this.KabinetTextBox.MaxLength = 40;
            this.KabinetTextBox.Name = "KabinetTextBox";
            this.KabinetTextBox.Size = new System.Drawing.Size(252, 26);
            this.KabinetTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кабинет:";
            // 
            // EtagTextBox
            // 
            this.EtagTextBox.Location = new System.Drawing.Point(16, 190);
            this.EtagTextBox.MaxLength = 12;
            this.EtagTextBox.Name = "EtagTextBox";
            this.EtagTextBox.Size = new System.Drawing.Size(252, 26);
            this.EtagTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Этаж:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 222);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(507, 36);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // otdelTableAdapter1
            // 
            this.otdelTableAdapter1.ClearBeforeFill = true;
            // 
            // AddOtdelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EtagTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KabinetTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(551, 311);
            this.MinimumSize = new System.Drawing.Size(551, 311);
            this.Name = "AddOtdelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового отдела";
            this.Load += new System.EventHandler(this.AddOtdelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KabinetTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EtagTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private INBASEDataSet1TableAdapters.OTDELTableAdapter otdelTableAdapter1;
    }
}