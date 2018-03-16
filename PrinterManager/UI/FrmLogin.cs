using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PrinterManager;

namespace PrinterManager
{
    public partial class FrmLogin : CCWin.CCSkinMain
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtphone.Text = "";
            txtRandcode.Text = "";
        }

        private void BtnDl_Click(object sender, EventArgs e)
        {
            if (Function.CheckRandomCode(txtphone.Text, txtRandcode.Text))
            {
                if (Data.resultInfo.data.printstatus == "0")
                {
                    FrmResultInfo m_result = new FrmResultInfo();
                    m_result.Show();
                }
                else
                {
                    Function.ExceptionOut("40010", FrmErro.CYIcon.Warning);
                }
            }
            this.Dispose();
        }

        #region 选择输入选项
        private void FrmLogin_Load(object sender, EventArgs e)
        { }
        #endregion

        private void TxtId_Click(object sender, EventArgs e)
        {
            FrmKeyboard key_name = new FrmKeyboard("手机号", true)
            {
                TopMost = true
            };
            key_name.ShowDialog();
            txtphone.Text = key_name.GetUserInfo();
            txtRandcode.Focus();
        }

        private void TxtPwd_Click(object sender, EventArgs e)
        {
            FrmKeyboard key_pwd = new FrmKeyboard("随机码", true)
            {
                TopMost = true
            };
            key_pwd.ShowDialog();
            txtRandcode.Text = key_pwd.GetUserInfo();
        }

        private void btnSw_Click(object sender, EventArgs e)
        {

            Function.ExceptionOut("40000", FrmErro.CYIcon.Information);
            //FrmErro ing = new FrmErro() ;
            //ing.Show("该功能尚未开发", FrmErro.CYException.Normal, FrmErro.CYIcon.Information);
        }
    }
}
