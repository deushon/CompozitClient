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
    public partial class AddSotrudnikForm : Form
    {
        int idotdel,idsotrud;
        public AddSotrudnikForm(int OTDELID)
        {
            this.idotdel = OTDELID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AddSotrudnikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iNBASEDataSet1.OTDEL". При необходимости она может быть перемещена или удалена.
            this.oTDELTableAdapter.Fill(this.iNBASEDataSet1.OTDEL);
            oTDELBindingSource.Filter = "ID_OTDEL = "+ idotdel;
            OtdelSearchTextBox.Text= OtdeldataGridView[1, Convert.ToInt32(OtdeldataGridView.CurrentRow.Index.ToString())].Value.ToString();
            ChousedOtdelLabel.Text = "Выбран отдел с ID:" + idotdel.ToString();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            oTDELBindingSource.Filter = "NAME_OTDEL LIKE '*" + OtdelSearchTextBox.Text + "*'";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChengeCheckBox.Checked) { OtdeldataGridView.Enabled = true; OtdelSearchTextBox.Enabled = true; OtdelSearchTextBox.Focus(); }
            else { OtdeldataGridView.Enabled = false; OtdelSearchTextBox.Enabled = false; }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (idotdel > 0)
            {
                try
                {
                    idsotrud = Convert.ToInt32(sotrudTableAdapter2.NewSotrudnik(FamilTextBox.Text, NameTextBox.Text, OtchTextBox.Text, idotdel, DolgnostTextBox.Text, WorkcheckBox.Checked));
                    if (NachCheckBox.Checked) { oTDELTableAdapter.SetNachOtdel(idotdel, idsotrud); }

                    MainForm main = this.Owner as MainForm;
                    if (main != null)
                    {
                        main.SotrudnikSearchTextBox.Text = FamilTextBox.Text+" "+NameTextBox.Text+" "+OtchTextBox.Text;
                    }
                }
                catch { MessageBox.Show("Ошибка выполения запроса к БД!"); }
                this.Close();
            }
        }
        private void OtdeldataGridView_Click(object sender, EventArgs e)
        {
            idotdel = Convert.ToInt32(OtdeldataGridView[0, Convert.ToInt32(OtdeldataGridView.CurrentRow.Index.ToString())].Value);
            ChousedOtdelLabel.Text = "Выбран отдел с ID:" + idotdel.ToString();
        }

        private void OtdeldataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (OtdeldataGridView.Rows.Count > 1)
                idotdel = Convert.ToInt32(OtdeldataGridView[0, Convert.ToInt32(OtdeldataGridView.CurrentRow.Index.ToString())].Value);
            else
                idotdel = 0;
            ChousedOtdelLabel.Text = "Выбран отдел с ID:" + idotdel.ToString();
        }
    }
}
