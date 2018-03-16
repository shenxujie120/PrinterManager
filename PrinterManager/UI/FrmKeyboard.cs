using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace PrinterManager
{
    public partial class FrmKeyboard : CCWin.Skin_DevExpress
    {
        private bool IsShiftClick = false;
        private bool IsCapsLockClick = false;
        string[] sign = new string[]{")","!","@","#","$","%","^","&","*","(",};

        public FrmKeyboard(string userInfo, bool flag)//false为密码模式，true为显示模式
        {
            this.TopMost = true;
            InitializeComponent();
            SetStyles();
            lbl_inputTip.Text = "请输入你的" + userInfo.ToString();
            SendKeys.Send("{TAB} ");
            if (!flag)
                text_userInfo.PasswordChar = Convert.ToChar("*");
        }

        #region 减少闪烁方法
        private void SetStyles()
        {
            //设置自定义控件Style
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.
            this.SetStyle(ControlStyles.UserPaint, true);//自行绘制
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }
        #endregion

        public string GetUserInfo()
        {
            return text_userInfo.Text;
        }

        private void Frm_Keyboard_Load(object sender, EventArgs e)
        {
            buttonNum1.Click += new EventHandler(ButtonNo_Click);
            buttonNum2.Click += new EventHandler(ButtonNo_Click);
            buttonNum3.Click += new EventHandler(ButtonNo_Click);
            buttonNum4.Click += new EventHandler(ButtonNo_Click);
            buttonNum5.Click += new EventHandler(ButtonNo_Click);
            buttonNum6.Click += new EventHandler(ButtonNo_Click);
            buttonNum7.Click += new EventHandler(ButtonNo_Click);
            buttonNum8.Click += new EventHandler(ButtonNo_Click);
            buttonNum9.Click += new EventHandler(ButtonNo_Click);
            buttonNum0.Click += new EventHandler(ButtonNo_Click);
            buttonBack.Click += new EventHandler(ButtonBack_Click);
            buttonQ.Click += new EventHandler(ButtonLetter_Click);
            buttonW.Click += new EventHandler(ButtonLetter_Click);
            buttonE.Click += new EventHandler(ButtonLetter_Click);
            buttonR.Click += new EventHandler(ButtonLetter_Click);
            buttonT.Click += new EventHandler(ButtonLetter_Click);
            buttonY.Click += new EventHandler(ButtonLetter_Click);
            buttonU.Click += new EventHandler(ButtonLetter_Click);
            buttonI.Click += new EventHandler(ButtonLetter_Click);
            buttonO.Click += new EventHandler(ButtonLetter_Click);
            buttonP.Click += new EventHandler(ButtonLetter_Click);
            buttonCapsLock.Click += new EventHandler(ButtonCaps_Click);
            buttonA.Click += new EventHandler(ButtonLetter_Click);
            buttonS.Click += new EventHandler(ButtonLetter_Click);
            buttonD.Click += new EventHandler(ButtonLetter_Click);
            buttonF.Click += new EventHandler(ButtonLetter_Click);
            buttonG.Click += new EventHandler(ButtonLetter_Click);
            buttonH.Click += new EventHandler(ButtonLetter_Click);
            buttonJ.Click += new EventHandler(ButtonLetter_Click);
            buttonK.Click += new EventHandler(ButtonLetter_Click);
            buttonL.Click += new EventHandler(ButtonLetter_Click);
            buttonEnter.Click += new EventHandler(Btn_submituser_Click);
            buttonLShift.Click += new EventHandler(ButtonShift_Click);
            buttonZ.Click += new EventHandler(ButtonLetter_Click);
            buttonX.Click += new EventHandler(ButtonLetter_Click);
            buttonC.Click += new EventHandler(ButtonLetter_Click);
            buttonV.Click += new EventHandler(ButtonLetter_Click);
            buttonB.Click += new EventHandler(ButtonLetter_Click);
            buttonN.Click += new EventHandler(ButtonLetter_Click);
            buttonM.Click += new EventHandler(ButtonLetter_Click);
            text_userInfo.Focus();
            text_userInfo.Text = "";
        }

        private void ButtonLetter_Click(object sender, EventArgs e)
        {
            Button Temp = (Button)sender;
            text_userInfo.Text += Temp.Text;
            text_userInfo.SelectionStart = text_userInfo.Text.Length;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (text_userInfo.Text == String.Empty)
            {
                text_userInfo.Focus();
                return;
            }
            Button Temp = (Button)sender;
            text_userInfo.Text = text_userInfo.Text.Substring(0, text_userInfo.Text.Length-1);
            text_userInfo.SelectionStart = text_userInfo.Text.Length;
        }
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Button Temp = (Button)sender;
            if (IsShiftClick)
            {
                int i= Convert.ToInt32(Temp.Name.Substring(9, 1));
                text_userInfo.Text += sign[i];
            }
            else
                text_userInfo.Text += Temp.Name.Substring(9, 1);
            text_userInfo.SelectionStart = text_userInfo.Text.Length;
        }

        private void ButtonCaps_Click(object sender, EventArgs e)
        {
            IsCapsLockClick = !IsCapsLockClick;
            if (IsCapsLockClick == false)
            {
                buttonCapsLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                buttonQ.Text = "q";
                buttonW.Text = "w";
                buttonE.Text = "e";
                buttonR.Text = "r";
                buttonT.Text = "t";
                buttonY.Text = "y";
                buttonU.Text = "u";
                buttonI.Text = "i";
                buttonO.Text = "o";
                buttonP.Text = "p";
                buttonA.Text = "a";
                buttonS.Text = "s";
                buttonD.Text = "d";
                buttonF.Text = "f";
                buttonG.Text = "g";
                buttonH.Text = "h";
                buttonJ.Text = "j";
                buttonK.Text = "k";
                buttonL.Text = "l";
                buttonZ.Text = "z";
                buttonX.Text = "x";
                buttonC.Text = "c";
                buttonV.Text = "v";
                buttonB.Text = "b";
                buttonN.Text = "n";
                buttonM.Text = "m";
                return;
            }
            if (IsCapsLockClick == true)
            {
                buttonCapsLock.BackColor = Color.Gray;
                buttonQ.Text = "Q";
                buttonW.Text = "W";
                buttonE.Text = "E";
                buttonR.Text = "R";
                buttonT.Text = "T";
                buttonY.Text = "Y";
                buttonU.Text = "U";
                buttonI.Text = "I";
                buttonO.Text = "O";
                buttonP.Text = "P";
                buttonA.Text = "A";
                buttonS.Text = "S";
                buttonD.Text = "D";
                buttonF.Text = "F";
                buttonG.Text = "G";
                buttonH.Text = "H";
                buttonJ.Text = "J";
                buttonK.Text = "K";
                buttonL.Text = "L";
                buttonZ.Text = "Z";
                buttonX.Text = "X";
                buttonC.Text = "C";
                buttonV.Text = "V";
                buttonB.Text = "B";
                buttonN.Text = "N";
                buttonM.Text = "M";
            }
        }

        private void ButtonShift_Click(object sender, EventArgs e)
        {
            IsShiftClick = !IsShiftClick;
            if (IsShiftClick == false)
            {
                buttonLShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                buttonQ.Text="q";
                buttonW.Text = "w";
                buttonE.Text = "e";
                buttonR.Text = "r";
                buttonT.Text = "t";
                buttonY.Text = "y";
                buttonU.Text = "u";
                buttonI.Text = "i";
                buttonO.Text = "o";
                buttonP.Text = "p";
                buttonA.Text = "a";
                buttonS.Text = "s";
                buttonD.Text = "d";
                buttonF.Text = "f";
                buttonG.Text = "g";
                buttonH.Text = "h";
                buttonJ.Text = "j";
                buttonK.Text = "k";
                buttonL.Text = "l";
                buttonZ.Text = "z";
                buttonX.Text = "x";
                buttonC.Text = "c";
                buttonV.Text = "v";
                buttonB.Text = "b";
                buttonN.Text = "n";
                buttonM.Text = "m";
                return;
            }
            if (IsShiftClick == true)
            {
                buttonLShift.BackColor = Color.Gray;
                buttonQ.Text = "Q";
                buttonW.Text = "W";
                buttonE.Text = "E";
                buttonR.Text = "R";
                buttonT.Text = "T";
                buttonY.Text = "Y";
                buttonU.Text = "U";
                buttonI.Text = "I";
                buttonO.Text = "O";
                buttonP.Text = "P";
                buttonA.Text = "A";
                buttonS.Text = "S";
                buttonD.Text = "D";
                buttonF.Text = "F";
                buttonG.Text = "G";
                buttonH.Text = "H";
                buttonJ.Text = "J";
                buttonK.Text = "K";
                buttonL.Text = "L";
                buttonZ.Text = "Z";
                buttonX.Text = "X";
                buttonC.Text = "C";
                buttonV.Text = "V";
                buttonB.Text = "B";
                buttonN.Text = "N";
                buttonM.Text = "M";
            }
        }

        private void ButtonShift_MouseEnter(object sender, EventArgs e)
        {
            buttonLShift.BackColor = Color.Snow;
        }

        private void ButtonShift_MouseLeave(object sender, EventArgs e)
        {
            if (IsShiftClick == true) return;
            buttonLShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); ;
        }

        private void ButtonCapsLock_MouseEnter(object sender, EventArgs e)
        {
            buttonCapsLock.BackColor = Color.Aqua;
        }

        private void ButtonCapsLock_MouseLeave(object sender, EventArgs e)
        {
            if (IsCapsLockClick == true) return;
            buttonCapsLock.BackColor = Color.White;
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Aqua;
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.White;
        }

        private void Btn_submituser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_canceluser_Click(object sender, EventArgs e)
        {
            text_userInfo.Text = "";
            this.Close();
        }

        private void Lbl_KeyTips_Click(object sender, EventArgs e)
        {

        }
    }
}
