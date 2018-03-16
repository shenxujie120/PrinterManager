using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PrinterManager
{
    public partial class FrmSetting : CCWin.Skin_DevExpress
    {
        enum BtnStatus
        {
            确定 = 0,
            设置 = 1,
            默认打印机=2
            //成员的值可以设置成一样的，但是成员不行
        }

        public FrmSetting()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                Pnl_settingsuccess1.Visible = false;
                Pnl_settingsuccess2.Visible = false;
                Pnl_settingsuccess3.Visible = false;
                Txt_deviceno.Text = Data.AppConfig.Deviceno.ToString();
                Lbl_version.Text = Data.AppConfig.curVersion;
                LblDirectory.Text = Data.AppConfig.DownloadPath;
                CheckBoxInit(CBox_printlimit, Data.AppConfig.Limit);
                CheckBoxInit(CBox_autorun, Data.AppConfig.IsAutoRun);
                if (Data.AppConfig.IsAutoUpdate)
                {
                    RadioBtn_Autoupdate1.Checked = true;
                }
                else
                    RadioBtn_Autoupdate2.Checked = true;
                if(Function.Readadmin(Data.AppConfig.Deviceno))
                    ShowAdminInfo();
            }
            catch
            { }
        }

        private void ShowAdminInfo()
        {
            Lbl_adminname.Text = Data.deviceInfo.data.adminname;
            Lbl_adminphone.Text = Data.deviceInfo.data.phone;
            Lbl_adminaddress.Text = Data.deviceInfo.data.address;
            Data.AppConfig.AdminPwd=Data.deviceInfo.data.password;
            Lbl_pinterstatus.Text = LocalPrinter.GetStatus(LocalPrinter.DefaultPrinter(),out Data.AppConfig.PrinterStatus);
        }

        #region 设置初始化
        private void CheckBoxInit(CheckBox CB, bool value)
        {
            CB.Checked = value;
        }
        #endregion

        private void Btn_SetDevice_Click(object sender, EventArgs e)
        {
            FrmKeyboard SetDevice = new FrmKeyboard("设备码", true);
            SetDevice.ShowDialog();
            if(SetDevice.DialogResult==DialogResult.OK)
                SettingSuccess(Pnl_settingsuccess2);
            //打印机状态
            if (Function.Readadmin(SetDevice.GetUserInfo()))
            {
                Data.AppConfig.Deviceno = SetDevice.GetUserInfo();
                ShowAdminInfo();
            }
            Txt_deviceno.Text = Data.AppConfig.Deviceno.ToString();
        }

        private void RadioBtn_Autoupdate1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn_Autoupdate1.Checked == true)
            {
                SettingSuccess(Pnl_settingsuccess3);
                Data.AppConfig.IsAutoUpdate = true;
            }
        }

        private void RadioBtn_Autoupdate2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn_Autoupdate2.Checked == true)
            {
                SettingSuccess(Pnl_settingsuccess3);
                Data.AppConfig.IsAutoUpdate = false;
            }
        }

        private void CBox_autorun_CheckedChanged(object sender, EventArgs e)
        {
            SettingSuccess(Pnl_settingsuccess1);
            Data.AppConfig.IsAutoRun = CBox_autorun.Checked;
        }

        private void CBox_printlimit_CheckedChanged(object sender, EventArgs e)
        {
            SettingSuccess(Pnl_settingsuccess1);
            Data.AppConfig.Limit = CBox_printlimit.Checked;
        }

        private void SettingSuccess(CCWin.SkinControl.SkinPanel panel)
        {
            panel.Visible = true;
            Timersetting.Enabled = true;
        }

        private void Timersetting_Tick(object sender, EventArgs e)
        {
            Pnl_settingsuccess1.Visible = false;
            Pnl_settingsuccess2.Visible = false;
            Pnl_settingsuccess3.Visible = false;
            Timersetting.Enabled = false;
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Function.ShowWindow();
            Application.Exit();
        }

        private void Btn_testupdate_Click(object sender, EventArgs e)
        {
            Function.Update_RunOrNot();
            this.Focus();
        }

        private void Btn_changeDir_Click(object sender, EventArgs e)
        {
            CacheDialog.Description = "选择所有文件缓存目录";
            if (CacheDialog.ShowDialog() == DialogResult.OK)
            {
                Data.AppConfig.DownloadPath = CacheDialog.SelectedPath;
            }
            LblDirectory.Text = Data.AppConfig.DownloadPath;
        }

        private void InitprinterComboBox()
        {
            printerComboBox.Visible = true;
            printerComboBox.Items.Clear();
            List<String> list = LocalPrinter.GetLocalPrinters(); //获得系统中的打印机列表
            foreach (String s in list)
            {
                printerComboBox.Items.Add(s); //将打印机名称添加到下拉框中
            }
        }

        private void Btn_localPrinter_Click(object sender, EventArgs e)
        {
            if (Btn_localPrinter.Text == Enum.GetName(typeof(BtnStatus), 2))//默认打印机
            {
                Btn_localPrinter.Text = Enum.GetName(typeof(BtnStatus), 0);
                printerComboBox.Visible = true;
                InitprinterComboBox();
                printerComboBox.DroppedDown = true;
            }
            else//确定
            {
                Btn_localPrinter.Focus();
                Btn_localPrinter.Text = Enum.GetName(typeof(BtnStatus), 2).ToString();
                if (printerComboBox.SelectedItem != null) //判断是否有选中值
                {
                    if (LocalPrinter.SetDefaultPrinter(printerComboBox.SelectedItem.ToString())) //设置默认打印机
                    {
                        MessageBox.Show(printerComboBox.SelectedItem.ToString() + "设置为默认打印机成功！");
                        Data.AppConfig.PrinterName = printerComboBox.SelectedItem.ToString();
                        ConfigurationManager.ModifySetting("printer", Data.AppConfig.PrinterName);
                        Lbl_pinterstatus.Text = LocalPrinter.GetStatus(Data.AppConfig.PrinterName, out Data.AppConfig.PrinterStatus);
                    }
                    else
                    {
                        MessageBox.Show(printerComboBox.SelectedItem.ToString() + "设置为默认打印机失败！");
                    }
                }
                printerComboBox.Visible = false;
            }
        }

    }
}
