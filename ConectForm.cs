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
    public partial class ConectForm : Form
    {
        public ConectForm()
        {
            InitializeComponent();
        }

        int DEVICEID;

        private void ConectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iNBASEDataSet1.DEVICE". При необходимости она может быть перемещена или удалена.
            this.dEVICETableAdapter.Fill(this.iNBASEDataSet1.DEVICE);
            TypeConect.AutoCompleteSource = AutoCompleteSource.ListItems;
            TypeDevComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            TypeDevComboBox.Text = "Комутатор";
        }

        private void TypeDevComboBox_TextChanged(object sender, EventArgs e)
        {
            dEVICEBindingSource.Filter = "TYPE_DEVICE LIKE '*" + TypeDevComboBox.Text + "*'";
        }

        private void SotrudnikSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            dEVICEBindingSource.Filter = "TYPE_DEVICE LIKE '*" + TypeDevComboBox.Text + "*' and "+"NAME_DEVICE LIKE '*" + DeviceSearchTextBox.Text + "*'";
        }

        private void DeviceDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeviceDataGridView.Rows.Count > 1)
                DEVICEID = Convert.ToInt32(DeviceDataGridView[0, Convert.ToInt32(DeviceDataGridView.CurrentRow.Index.ToString())].Value);
            else
                DEVICEID = 0;
            ChousedDeviceLabel.Text = "Выбрано устройство с ID:" + DEVICEID.ToString();
        }

        private void DeviceDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (DeviceDataGridView.Rows.Count > 1)
                DEVICEID = Convert.ToInt32(DeviceDataGridView[0, Convert.ToInt32(DeviceDataGridView.CurrentRow.Index.ToString())].Value);
            else
                DEVICEID = 0;
            ChousedDeviceLabel.Text = "Выбрано устройство с ID:" + DEVICEID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                main.MYPC.conect = DEVICEID;
                main.MYPC.typeconct = TypeConect.Text;
            }
            Close();
        }
    }
}
