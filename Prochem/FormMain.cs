using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Prochem
{
    public partial class FormMain : Form
    {
        Domain domain = new Domain();
        public FormMain()
        {
            InitializeComponent();
            DisableLockedMode();
            Domain.DataReceived += new Domain.DataReceiveEvent(ShowReceivedData);
        }
        #region UI Events
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshComPortComboBox();
        }
        private void ComboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshComPortComboBox();
        }

        private void Btn_LockConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (domain.TestConnection(cb_ComPort.Text, Convert.ToInt32(cb_Bitrate.Text)))
                {
                    EnableLockedMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                DisableLockedMode();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            domain.Send("123");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            domain.Send("456");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            domain.Send("789");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            domain.Send("0123");
        }
        #endregion
        #region Methods
        /// <summary>
        /// 秀出取回的資料
        /// </summary>
        private void ShowReceivedData()
        {
            this.Invoke(
                       new Action(
                           () => this.textBox1.Text = domain.GetReceiveData()
                           )
                       );
        }
        /// <summary>
        /// 刷新UI ComPort下拉選擇清單
        /// </summary>
        public void RefreshComPortComboBox()
        {
            cb_ComPort.Items.Clear();
            foreach (string sp in SerialPort.GetPortNames()) //取得目前電腦所有的com port
            {
                cb_ComPort.Items.Add(sp);
            }
            cb_ComPort.Sorted = true;  //排序
            //comboBox1.SelectedIndex = 0; //第一個是預設選項     
        }
        /// <summary>
        /// 開啟 ComPort 鎖定模式
        /// </summary>
        private void EnableLockedMode()
        {
            cb_ComPort.Enabled = false;
            btn_LockConnection.Enabled = false;

            btn_UnlockConnection.Enabled = true;
            btn_Zero.Enabled = true;
            btn_White.Enabled = true;
            btn_Standard.Enabled = true;
            btn_Compare.Enabled = true;
        }
        /// <summary>
        /// 關閉 ComPort 鎖定模式
        /// </summary>
        private void DisableLockedMode()
        {
            cb_ComPort.Enabled = true;
            btn_LockConnection.Enabled = true;

            btn_UnlockConnection.Enabled = false;
            btn_Zero.Enabled = false;
            btn_White.Enabled = false;
            btn_Standard.Enabled = false;
            btn_Compare.Enabled = false;
        }

        private void Btn_UnlockConnection_Click(object sender, EventArgs e)
        {
            domain.Disconnect();
            DisableLockedMode();
        }
        #endregion
    }
}
