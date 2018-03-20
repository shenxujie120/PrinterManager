using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PrinterManager
{
    public partial class FrmAdminPwd : Form
    {
        public FrmAdminPwd()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        public bool flag;
        public bool Confirmpwd()
        {
            string temppwd = Txt_adminpwd.Text;
            //DES加密管理员输入密码
            if (temppwd==Data.AppConfig.AdminPwd)
            {
                flag = true;
            }
            else
            {
                flag = false;
                Function.ExceptionOut("40002", FrmErro.CYIcon.Warning);
                //FrmErro adminmsg = new FrmErro();
                //adminmsg.Show("管理员密码输入错误", FrmErro.CYException.UserError, FrmErro.CYIcon.Warning);
            }
            return flag;
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            if (Confirmpwd())
            {
                FrmSetting sysInfo = new FrmSetting();
                sysInfo.ShowDialog();
            }
            this.Dispose();
        }

        private void Txt_adminpwd_Click(object sender, EventArgs e)
        {
            FrmKeyboard key_pwd = new FrmKeyboard("密码", true);
            key_pwd.ShowDialog();
            Txt_adminpwd.Text = key_pwd.GetUserInfo();
            key_pwd.Focus();
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
