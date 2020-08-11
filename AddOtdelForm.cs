using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompozitClient
{
    public partial class AddOtdelForm : Form
    {
        public AddOtdelForm()
        {
            InitializeComponent();
        }

        private void AddOtdelForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                otdelTableAdapter1.NewOtdel(NameTextBox.Text, TelTextBox.Text, AdresTextBox.Text, "Этаж " + EtagTextBox.Text + " Кабинет " + KabinetTextBox.Text);
                MainForm main = this.Owner as MainForm;
                if (main != null)
                {
                    main.OtedlSearchTextBox.Text = NameTextBox.Text;
                }
            }
            catch { MessageBox.Show("Ошибка выполнения запроса к БД!"); }
            this.Close();
        }
    }
}
