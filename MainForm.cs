using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace CompozitClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        const string CRIPTPASS = "БольшойБрат#";
        //ID сотрудника для передачи оборудования и ID выбранного отдела.
        int SOTRUDNIKID= 0;
        int OTDELID=0;
        //Функция шифрования данных.
        public static string Encrypt(string str, string keyCrypt)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(str), keyCrypt));
        }

        public static string Decrypt(string str, string keyCrypt)
        {
            string Result;
            try
            {
                CryptoStream Cs = InternalDecrypt(Convert.FromBase64String(str), keyCrypt);
                StreamReader Sr = new StreamReader(Cs);

                Result = Sr.ReadToEnd();

                Cs.Close();
                Cs.Dispose();

                Sr.Close();
                Sr.Dispose();
            }
            catch (CryptographicException)
            {
                return null;
            }

            return Result;
        }

        private static byte[] Encrypt(byte[] key, string value)
        {
            SymmetricAlgorithm Sa = Rijndael.Create();
            ICryptoTransform Ct = Sa.CreateEncryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream Ms = new MemoryStream();
            CryptoStream Cs = new CryptoStream(Ms, Ct, CryptoStreamMode.Write);

            Cs.Write(key, 0, key.Length);
            Cs.FlushFinalBlock();

            byte[] Result = Ms.ToArray();

            Ms.Close();
            Ms.Dispose();

            Cs.Close();
            Cs.Dispose();

            Ct.Dispose();

            return Result;
        }

        private static CryptoStream InternalDecrypt(byte[] key, string value)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream ms = new MemoryStream(key);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }


        public void DecriptTable(DataGridView tabl)
        {
            for (int i=0;i< tabl.RowCount-1;i++)
            {
                tabl["nASVLOGPASSDataGridViewTextBoxColumn", i].Value = Decrypt(tabl["nASVLOGPASSDataGridViewTextBoxColumn", i].Value.ToString(), CRIPTPASS);
                tabl["lOGINLOGPASSDataGridViewTextBoxColumn", i].Value = Decrypt(tabl["lOGINLOGPASSDataGridViewTextBoxColumn", i].Value.ToString(), CRIPTPASS);
                tabl["pASSLOGPASSDataGridViewTextBoxColumn", i].Value = "************";
            }
        }


        //Класс описания устройства.
        public class Device 
        {
            public int idpc;
            public string typepc;
            public string namepc;
            public string devpc;
            public int nomerzakyp;
            public DateTime datepc;
            public string netnamepc;
            public string ippc;
            public string OS;
            public bool STATIK_IP_PC;
            public string DOPINFO_PC;
            public int ID_SOTRUD;
            public int colitms;
            public int conect;
            public string typeconct;
            public string dSN;
            public string OLDinv;
            //Массив комплектующих.
            public ITEM[] items;

            //Конструктор класса устройства поумолчанию.
            public Device()
            {

            }

            //Конструктор класса устройства с полным вводом данных. Не все входные параметры.
            public Device(string typ, string nam, string dev, int nzak, DateTime dat, string netname, string ip) 
            {
                typepc = typ;
                namepc = nam;
                devpc = dev;
                nomerzakyp = nzak;
                datepc = dat;
                netnamepc = netname;
                ippc = ip;
                colitms = 0;
                //Инициализация массива комплектующих, без этого будет невоможно с ним взаиодействовать (он будет null).
                items = new ITEM[128]; 
            }

            //Функция обновления набора запчастей.
            public void EditItems(DataGridView Itdg)
            {
                items = new ITEM[128];
                colitms = 0;
                for (int i = 0; i < Itdg.RowCount-1; i++)
                {
                    additems(1, Itdg[0, i].Value.ToString(), Itdg[1, i].Value.ToString(), Itdg[2, i].Value.ToString(), "работает", Itdg[3, i].Value.ToString(), Itdg[4, i].Value.ToString());
                }
            }

            //Функция актуализации информации о устройстве (ПК) и его запчастях в бд.
            public bool UpInfoInBase(INBASEDataSet1TableAdapters.DEVICETableAdapter DEVICEdapter, INBASEDataSet1TableAdapters.ITEMSTableAdapter ITadapter)
            {
                bool erorr = false;
                try
                {
                    idpc = Convert.ToInt32(DEVICEdapter.AddDevice(typepc, namepc, devpc, nomerzakyp, ID_SOTRUD, datepc, netnamepc, ippc, OS, STATIK_IP_PC, DOPINFO_PC, true, "работает",conect,typeconct,dSN,OLDinv));
                }
                catch
                {
                    erorr = true;
                    MessageBox.Show("Ошибка выполения запросов к базе! Неудалось добавить устройство!");
                }

                for (int i = 0; i < colitms; i++)
                {
                    try
                    {
                        ITadapter.AddItem(items[i].nomerzakyp, idpc, items[i].typeitem, items[i].nameitem, items[i].devitem, items[i].State, items[i].opisanie, items[i].SN);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка выполения запросов к базе! Неудалось добавить комплектующую!");
                        erorr = true;
                    }
                }
                return erorr;
            }

            //Конструктор класса устройства(ПК) с автоматическим сбором данных.
            public Device(bool AutoSearch, int idvladelsa)
            {
                if (AutoSearch)
                {
                    typepc = "ПК";
                    ID_SOTRUD = idvladelsa;
                    STATIK_IP_PC = false;
                    namepc = Environment.MachineName;
                    devpc = "No-Info";
                    nomerzakyp = 1;
                    datepc = System.DateTime.Now;
                    netnamepc = namepc;
                    conect = 0;
                    typeconct = "";

                    try
                    {
                        ippc = System.Net.Dns.GetHostByName(namepc).AddressList[0].ToString();
                    }
                    catch
                    { ippc = "error"; }
                    //Запрос названия ОС.
                    try
                    {
                        ManagementObjectSearcher OSInfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
                        foreach (ManagementObject OSObj in OSInfo.Get())
                        {
                            OS = OSObj["Caption"].ToString();
                        }
                    }
                    catch { OS = "Ошибка определения ОС"; }
                    colitms = 0;
                    //Создание временой записи о пк в базе и получение его ID.
                    //try
                    //{
                    //    idpc = Convert.ToInt32(DEVICEdapter.AddDevice(typepc, namepc, devpc, nomerzakyp, datepc, netnamepc, ippc, OS, STATIK_IP_PC, DOPINFO_PC, true, "работает"));
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Ошибка выполения запросов к базе!");
                    //}

                    //Инициализация массива комплектующих, без этого будет невоможно с ним взаиодействовать (он будет null).
                    items = new ITEM[128];

                    additems(1, "Монитор", "стандартный монитор", "Dev", "работает", "opisanie", "NO-SN");
                    additems(1, "Клавиатура", "стандартная клавиатура", "Dev", "работает", "opisanie", "NO-SN");
                    additems(1, "Мышь", "стандартная мышь", "Dev", "работает", "opisanie", "NO-SN");

                    //Сбор и добавление информации о процессорах.
                    try
                    {
                        ManagementObjectSearcher ProcInfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                        foreach (ManagementObject ProcObj in ProcInfo.Get())
                        {
                            additems(1, "Процессор", ProcObj["Name"].ToString(), ProcObj["Manufacturer"].ToString(), "работает", "opisanie", ProcObj["ProcessorId"].ToString());
                        }
                    }
                    catch { additems(1, "Процессор", "Ошибка определения процессора", "Dev", "работает", "opisanie", "NO-SN"); }

                    //Сбор и добавление информции о оперативноq памяти.
                    try
                    {
                        ManagementObjectSearcher RAMinfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
                        foreach (ManagementObject RAMObj in RAMinfo.Get())
                        {
                            additems(1, "ОЗУ", RAMObj["Manufacturer"].ToString() + " " +
                            Math.Round(System.Convert.ToDouble(RAMObj["Capacity"]) / 1024 / 1024 / 1024, 2).ToString() + "Gb " +
                            RAMObj["Speed"].ToString() + "МГц", RAMObj["Manufacturer"].ToString(), "работает", "opisanie", RAMObj["SerialNumber"].ToString());
                        }
                    }
                    catch
                    { additems(1, "ОЗУ", "Ошибка определения ОЗУ", "Dev", "работает", "opisanie", "NO-SN"); }

                    //Сбор и добавление информции о жестких дисках.
                    try
                    {
                        ManagementObjectSearcher DiskInfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                        foreach (ManagementObject DiskObj in DiskInfo.Get())
                        {
                            additems(1, "Жесткий диск", DiskObj["Model"].ToString() + " " +
                            Math.Round(System.Convert.ToDouble(DiskObj["Size"]) / 1024 / 1024 / 1024, 2).ToString() + "Gb",
                                                DiskObj["Manufacturer"].ToString(), "работает", "opisanie", DiskObj["SerialNumber"].ToString());
                        }
                    }
                    catch { additems(1, "Жесткий диск", "Ошибка определения жесткого диска", "Dev", "работает", "opisanie", "NO-SN"); }

                    //Сбор и добавление информции о видео картах.
                    try
                    {
                        ManagementObjectSearcher VideoInfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                        foreach (ManagementObject VideoObj in VideoInfo.Get())
                        {
                            // if (VideoObj["SerialNumber"] != null) sn = VideoObj["SerialNumber"].ToString();
                            additems(1, "Видеокарта", VideoObj["Caption"].ToString(), "Dev", "работает", "opisanie", "NO-SN");
                        }
                    }
                    catch { additems(1, "Видеокарта", "Ошибка определения видеокарты", "Dev", "работает", "opisanie", "NO-SN"); }
                    //В автоматическом сборое данных о сетевых карт пока нет необходимости.
                    //Сбор и добавление информации о сетевых адаптерах.
                    //ManagementObjectSearcher NetInfo = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");
                    //foreach (ManagementObject NetObj in NetInfo.Get())
                    //{
                    //    string NetName = NetObj["Caption"].ToString();

                    //    while (NetName[0] != ']') //Обрезаем лишнее из имени сетевого адаптера. (Например [00000001])
                    //    {
                    //        NetName = NetName.Substring(1);
                    //    }
                    //    NetName = NetName.Substring(2); //И удаляем саму скобку с пробелом.
                    //    additems(0, "Сетевой адаптер", NetName, "dev", "В работе", "opisanie");
                    //}
                }
            }

            //Процедура для вывода информации о устройстве(ПК) на форму.
            public void ShowInfo(TextBox PcName,ComboBox TypPC, TextBox devTX, TextBox ipTX,
            TextBox HostTX, DateTimePicker Dat,TextBox OSTX,DataGridView ITEMVIEW,CheckBox STIPch,TextBox DopINfoB)
            {
                PcName.Text = namepc;
                TypPC.Text = typepc;
                devTX.Text = devpc;
                ipTX.Text = ippc;
                HostTX.Text = namepc;
                Dat.Value = datepc;
                OSTX.Text = OS;
                STIPch.Checked = STATIK_IP_PC;

                ITEMVIEW.Rows.Clear();
                ITEMVIEW.Columns.Clear();
                ITEMVIEW.Columns.Add("typeritem", "Тип");
                ITEMVIEW.Columns["typeritem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ITEMVIEW.Columns.Add("nameitem", "Название");
                ITEMVIEW.Columns["nameitem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ITEMVIEW.Columns.Add("devitem", "Производитель");
                ITEMVIEW.Columns["devitem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ITEMVIEW.Columns.Add("opisitem", "Доп. инф.");
                ITEMVIEW.Columns["opisitem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ITEMVIEW.Columns.Add("opisitem", "Серийный номер");
                ITEMVIEW.Columns["opisitem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                for (int i=0;i<colitms;i++)
                {
                    ITEMVIEW.Rows.Add();
                    ITEMVIEW[0, i].Value = items[i].typeitem;
                    ITEMVIEW[1, i].Value = items[i].nameitem;
                    ITEMVIEW[2, i].Value = items[i].devitem;
                    ITEMVIEW[3, i].Value = items[i].opisanie;
                    ITEMVIEW[4, i].Value = items[i].SN;
                }
            }

            //Добавление новой комплектующей в ПК.
            public void additems(int nzak, string typ, string nam, string dev, string stateit, string opis, string SerNomer) 
            {
                if (colitms < 128)
                {
                    items[colitms] = new ITEM(nzak, typ, nam, dev, stateit, opis, SerNomer, idpc);
                    colitms++;
                }
                else MessageBox.Show("Ошибка! Превышен лимит доступных для ПК устройств!");
            }

            //Класс описания коплектующих копьютера.
            public class ITEM 
            {
                public int iditem;
                public int nomerzakyp;
                public int idpc;
                public string typeitem;
                public string nameitem;
                public string devitem;
                public string State;
                public string opisanie;
                public string SN;

                //Конструктор класса комплектующей по умолчанию.
                public ITEM() 
                {

                }

                //Конструктор класса коплектующей с вводом данных.
                public ITEM(int nzak, string typ, string nam, string dev, string stateit, string opis, string SerNomer, int idpk)
                {
                    nomerzakyp = nzak;
                    idpc = idpk;
                    typeitem = typ;
                    nameitem = nam;
                    devitem = dev;
                    State = stateit;
                    opisanie = opis;
                    SN = SerNomer;
                }
            }
        }

        //Создание объекта ПК.
        public Device MYPC;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FoneProc_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PkNameTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.namepc = PkNameTextBox.Text;
        }

        private void TypePCtextbox_TextChanged_1(object sender, EventArgs e)
        {
            MYPC.typepc = TypePCtextbox.Text;
        }

        private void DevTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.devpc = DevTextBox.Text;
        }

        private void OStextbox_TextChanged(object sender, EventArgs e)
        {
            MYPC.OS = OStextbox.Text;
        }

        private void DopInfoTB_TextChanged(object sender, EventArgs e)
        {
            MYPC.DOPINFO_PC = DopInfoTB.Text;
        }

        private void HostTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.netnamepc = HostTextBox.Text;
        }

        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.ippc = IpTextBox.Text;
        }

        private void DevDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MYPC.datepc = DevDateTimePicker.Value;
        }

        private void STIPcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MYPC.STATIK_IP_PC = STIPcheckBox.Checked;
        }

        private void SNTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.dSN = SNTextBox.Text;
        }

        private void OLDinvTextBox_TextChanged(object sender, EventArgs e)
        {
            MYPC.OLDinv = OLDinvTextBox.Text;
        }

        private void SendDataInBDbutton_Click(object sender, EventArgs e)
        {
            MYPC.ID_SOTRUD = SOTRUDNIKID;
            MYPC.EditItems(ItemsDataGridView);
            if (!MYPC.UpInfoInBase(deviceTableAdapter1, itemsTableAdapter1))
            {
                var result = MessageBox.Show("Данные об устройстве и его комплектующих успешно внесены в базу." + Environment.NewLine +"Устройство получило ID-"+MYPC.idpc + Environment.NewLine + "Вы хотите добавить дополнительные устройства?", "???", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    IpTextBox.ReadOnly = false;
                    HostTextBox.ReadOnly = false;
                    IpTextBox.Text = "";
                    HostTextBox.Text = "";
                    PkNameTextBox.Text = "";
                    TypePCtextbox.Text = "";
                    DevTextBox.Text = "";
                    OStextbox.Text = "";
                    DopInfoTB.Text = "";
                    MYPC.conect = 0;
                    MYPC.typeconct = "";
                    SNTextBox.Text = "";
                    OLDinvTextBox.Text = "";
                    ConectCheckBox.Checked = false;
                    DevDateTimePicker.Value = DateTime.Now;
                    STIPcheckBox.Checked = false;
                    ItemsDataGridView.Rows.Clear();
                }
                else
                {
                    ItemsPanel.Enabled = false;
                    SysInfoPanel.Enabled = false;
                    LogPasAddPanel.Enabled = true;
                    LogPasSePanel.Enabled = true;
                    tabControl.SelectedTab = LogPasTabPage;
                    this.logpassTableAdapter1.Fill(this.iNBASEDataSet1.LOGPASS);
                    DecriptTable(LogPasDataGridView);
                }
            }
            else MessageBox.Show("Проверте корректность типов данных или подключение к БД.");
        }


        private void OtedlSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            oTDELBindingSource.Filter = "NAME_OTDEL LIKE '*" + OtedlSearchTextBox.Text + "*'";
        }

        private void SotrudnikSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            fKSOTRUDOTDELBindingSource.Filter = "FAM_SOTRUD+' '+IMA_SOTRUD+' '+OTCH_SOTRUD LIKE '*" + SotrudnikSearchTextBox.Text + "*'";
            // fKSOTRUDOTDELBindingSource.Filter = "FAM_SOTRUD LIKE '*" + SotrudnikSearchTextBox.Text + "*' or IMA_SOTRUD LIKE '*" + SotrudnikSearchTextBox.Text + "*' or OTCH_SOTRUD LIKE '*" + SotrudnikSearchTextBox.Text + "*'";
        }

        private void AceptSotrudnikButton_Click(object sender, EventArgs e)
        {
            if (SOTRUDNIKID > 0)
            {
                //Создаем класс пк и автоматически собираем инфомрацию о нем.
                MYPC = new Device(true, SOTRUDNIKID);
                //Вывод информации о ПК на форму.
                MYPC.ShowInfo(PkNameTextBox, TypePCtextbox, DevTextBox, IpTextBox, HostTextBox, DevDateTimePicker, OStextbox, ItemsDataGridView, STIPcheckBox, DopInfoTB);
                SysInfoPanel.Enabled = true;
                ItemsPanel.Enabled = true;
                SotrudnikPanel.Enabled = false;
                OtdelPanel.Enabled = false;
                tabControl.SelectedTab = SystemTabPage;
            }
            else
            {
                MessageBox.Show("Ошибка выбора сотрудника");
            }

        }

        private void SotrudnikDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (SotrudnikDataGridView.Rows.Count > 1)
                SOTRUDNIKID = Convert.ToInt32(SotrudnikDataGridView[0, Convert.ToInt32(SotrudnikDataGridView.CurrentRow.Index.ToString())].Value);
            else
            SOTRUDNIKID = 0;
            ChousedSotrudnikLabel.Text = "Выбран сотрудник с ID:" + SOTRUDNIKID.ToString();
        }

        private void SotrudnikDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (SotrudnikDataGridView.Rows.Count > 1)
                SOTRUDNIKID = Convert.ToInt32(SotrudnikDataGridView[0, Convert.ToInt32(SotrudnikDataGridView.CurrentRow.Index.ToString())].Value);
            else
                SOTRUDNIKID = 0;
            ChousedSotrudnikLabel.Text = "Выбран сотрудник с ID:" + SOTRUDNIKID.ToString();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iNBASEDataSet1.SOTRUD". При необходимости она может быть перемещена или удалена.
            this.sOTRUDTableAdapter.Fill(this.iNBASEDataSet1.SOTRUD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iNBASEDataSet1.OTDEL". При необходимости она может быть перемещена или удалена.
            this.oTDELTableAdapter.Fill(this.iNBASEDataSet1.OTDEL);
            ProgressLabel.Text = "";
            progressBar1.Style = ProgressBarStyle.Blocks;
            TypePCtextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TypePCtextbox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CreateAddSotrudnikFormForm()
        {
            OTDELID = Convert.ToInt32(OtdeldataGridView[0, Convert.ToInt32(OtdeldataGridView.CurrentRow.Index.ToString())].Value);
            AddSotrudnikForm ADSORM = new AddSotrudnikForm(OTDELID);
            ADSORM.Owner = this;
            ADSORM.FormClosed += AddSotrudnikFormClosing;
            ADSORM.Show();
        }

        private void AddSotrudnikFormClosing(object sender, EventArgs e)
        {
            this.sOTRUDTableAdapter.Fill(this.iNBASEDataSet1.SOTRUD);
            OtedlSearchTextBox.Text = OtdeldataGridView[1, Convert.ToInt32(OtdeldataGridView.CurrentRow.Index.ToString())].Value.ToString();
            this.oTDELTableAdapter.Fill(this.iNBASEDataSet1.OTDEL);
            //bool fromSecondForm = (sender as AddSotrudnikForm).BoolProperty;
            //дальнейшая обработка полученного значения
        }

        private void AddSotrudnikButton_Click(object sender, EventArgs e)
        {
            CreateAddSotrudnikFormForm();
        }


        private void CreateAddOtdelFormForm()
        {
            AddOtdelForm ADSOTRM = new AddOtdelForm();
            ADSOTRM.Owner = this;
            ADSOTRM.FormClosed += CreateAddOtdelFormFormClosing;
            ADSOTRM.Show();
        }

        private void CreateAddOtdelFormFormClosing(object sender, EventArgs e)
        {
            this.oTDELTableAdapter.Fill(this.iNBASEDataSet1.OTDEL);
            //bool fromSecondForm = (sender as AddSotrudnikForm).BoolProperty;
            //дальнейшая обработка полученного значения
        }

        private void AddOtdelButton_Click(object sender, EventArgs e)
        {
            CreateAddOtdelFormForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                logpassTableAdapter1.NewLogPas(SOTRUDNIKID, LokalLPCheckBox.Checked, Encrypt(LPTextBox.Text, CRIPTPASS), LPDateTimePicker1.Value, Encrypt(LoginTextBox.Text, CRIPTPASS), Encrypt(PasTextBox.Text, CRIPTPASS));
                LokalLPCheckBox.Checked = false;
                LPTextBox.Text = "";
                LPDateTimePicker1.Value = DateTime.Now;
                LoginTextBox.Text = "";
                PasTextBox.Text = "";
                this.logpassTableAdapter1.Fill(this.iNBASEDataSet1.LOGPASS);
                DecriptTable(LogPasDataGridView);
                MessageBox.Show("Учетная запись успешно добавлена");
            }
            catch { MessageBox.Show("Ошибка выполениня запроса к БД"); }
        }

        private void NextDOPbutton_Click(object sender, EventArgs e)
        {

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IpTextBox_Click(object sender, EventArgs e)
        {
            if (IpTextBox.ReadOnly)
            {
                var result = MessageBox.Show("Вы уверены, что хотите разблокировать редактирование IP адреса?" + Environment.NewLine + "Редактирование этого поля не изменит реальный IP!!!", "???", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) IpTextBox.ReadOnly = false;
            }
        }

        private void HostTextBox_Click(object sender, EventArgs e)
        {
            if (HostTextBox.ReadOnly)
            {
                var result = MessageBox.Show("Вы уверены, что хотите разблокировать редактирование HostName" + Environment.NewLine + "Редактирование этого поля не изменит реальный HostName!!!", "???", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) HostTextBox.ReadOnly = false;
            }
        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            IpTextBox.ReadOnly = false;
            HostTextBox.ReadOnly = false;
            IpTextBox.Text = "";
            HostTextBox.Text = "";
            PkNameTextBox.Text = "";
            TypePCtextbox.Text = "";
            DevTextBox.Text = "";
            OStextbox.Text = "";
            DopInfoTB.Text = "";
            SNTextBox.Text = "";
            OLDinvTextBox.Text = "";
            ConectCheckBox.Checked = false;
            DevDateTimePicker.Value = DateTime.Now;
            STIPcheckBox.Checked = false;
            ItemsDataGridView.Rows.Clear();
            MYPC.conect = 0;
            MYPC.typeconct = "";
            MYPC.EditItems(ItemsDataGridView);
        }

        private void RefrshOtdel_Click(object sender, EventArgs e)
        {
            this.oTDELTableAdapter.Fill(this.iNBASEDataSet1.OTDEL);
        }

        private void RefreshSotrud_Click(object sender, EventArgs e)
        {
            this.sOTRUDTableAdapter.Fill(this.iNBASEDataSet1.SOTRUD);
        }

        private void ChengSotrud_Click(object sender, EventArgs e)
        {
            ItemsPanel.Enabled = false;
            SysInfoPanel.Enabled = false;
            SotrudnikPanel.Enabled = true;
            OtdelPanel.Enabled = true;
            tabControl.SelectedTab = UserTabPage;
        }

        private void SotrudnikDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChousedSotrudnikLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateConectForm()
        {
            ConectForm FCONECT = new ConectForm();
            FCONECT.Owner = this;
            FCONECT.FormClosed += CreateConectFormClosing;
            FCONECT.Show();
        }

        private void CreateConectFormClosing(object sender, EventArgs e)
        {
            if (MYPC.conect == 0 | MYPC.typeconct == "")
            {
                ConectCheckBox.Checked = false;
                MYPC.conect = 0;
                MYPC.typeconct = "";
                MessageBox.Show("Соединение не установлено!","Внимание!");
            }
            else MessageBox.Show("Соединение установлено!","Все ОК");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ConectCheckBox.Checked) CreateConectForm();
            else
            {
                MYPC.conect = 0;
                MYPC.typeconct = "";
            }
        }

        private void OtedlSearchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            OtedlSearchTextBox.Text = "";
        }

        private void SotrudnikSearchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            SotrudnikSearchTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PkNameTextBox.Text = "Терминал";
            TypePCtextbox.Text = "Терминал";
            DevTextBox.Text = "KraftWay";
            MYPC.additems(0, "Монитор", "ViewSonic VA2038wm-LED", "ViewSonic", "Работает", "", "");
            MYPC.additems(0, "Клавиатура", "Genius KB110", "Genius", "Работает", "", "");
            MYPC.additems(0, "Мышь", "Genius GM-110020", "Genius", "Работает", "", "");
            MYPC.ShowInfo(PkNameTextBox, TypePCtextbox, DevTextBox, IpTextBox, HostTextBox, DevDateTimePicker, OStextbox, ItemsDataGridView, STIPcheckBox, DopInfoTB);
        }
    }
 }

