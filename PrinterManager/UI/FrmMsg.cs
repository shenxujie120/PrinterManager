

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrinterManager
{
    public partial class FrmMsg : CCWin.CCSkinMain
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        static public Color _Red = Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(104)))), ((int)(((byte)(93)))));
        static public Color _Green = Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(208)))), ((int)(((byte)(198)))));
        static public Color _Blue = Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(208)))));
        static public Color _Gray = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
        
        public FrmMsg()
        {
            InitializeComponent();
        }

        private static Button btnOK;
        private static Button btnSkip;
        private static Button btnReturn;

        public enum CYIcon
        {
            Information,
            Print
        }

        public  enum CYButtons
        {
            OK,
            OKSkipReturn
        }

        public enum CYException
        {
            PrintSuccess,
            PrintMessage
        }
        private static DialogResult ReturnButton;
        public  DialogResult Show(string Msg, CYException MException, CYButtons MButtons, CYIcon MIcon)
        {
            this.TopMost = true;
            ButtonStatements(MButtons,MException);
            InfoStatements(Msg, MException);
            IconStatements(MIcon);
            this.ShowDialog();
            return ReturnButton;
        }//非打印

        public void ShowOKButton(int LeftPos, Color m_color)
        {
            btnOK = new Button()
            {
                BackColor = m_color,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK,
                Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                ForeColor = Color.White,
                Location = new Point(LeftPos, 210),
                Margin = new Padding(0),
                Name = "btnOK",
                Size = new Size(70, 40),
                TabIndex = 6,
                Text = "确认",
        };
            btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += new EventHandler(BtnOK_Click);
            this.Controls.Add(btnOK);
        }
        public  void ShowSkipButton(int LeftPos, Color m_color)
        {
            btnSkip = new Button()
            {
                BackColor = m_color,
                Cursor = Cursors.Hand,
                Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                ForeColor = Color.White,
                Location = new Point(LeftPos, 210),
                Margin = new Padding(0),
                Name = "btnSkip",
                Size = new Size(70, 40),
                TabIndex = 6,
                Text = "跳过"
            };
            btnSkip.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += new EventHandler(BtnSkip_Click);
            this.Controls.Add(btnSkip);
        }
        public  void ShowReturnButton(int LeftPos, Color m_color)
        {
            btnReturn = new Button()
            {
                BackColor = m_color,
                Cursor = Cursors.Hand,
                Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                ForeColor = Color.White,
                Location = new Point(LeftPos, 210),
                Margin = new Padding(0),
                Name = "btnReturn",
                Size = new Size(70, 40),
                TabIndex = 6,
                Text = "返回"
            };
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(177)))));
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += new EventHandler(BtnReturn_Click);
            //btnReturn.DialogResult = DialogResult.Abort;
            this.Controls.Add(btnReturn);
        }

        public  void BtnOK_Click(object sender, EventArgs e)
        {
            ReturnButton = DialogResult.OK;
            this.Dispose();
        }
        public  void BtnSkip_Click(object sender, EventArgs e)
        {
            ReturnButton = DialogResult.Ignore;
            this.Dispose();
        }
        public  void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnButton = DialogResult.Abort;
            this.Dispose();
        }

        public  void ButtonStatements(CYButtons MButtons,CYException Mex)
        {
            if (MButtons == CYButtons.OK)
            {
                if (Mex == CYException.PrintSuccess)
                {
                    ShowOKButton((this.Width - 70) / 2, _Green);
                    //rectangleShape1.BackColor = _Green;
                }
                else
                    ShowOKButton((this.Width - 70) / 2, _Red);
                    //rectangleShape1.BackColor = _Green;
            }

            if (MButtons == CYButtons.OKSkipReturn)
            {
                //rectangleShape1.BackColor = _Green;
                ShowOKButton(92, _Green);
                ShowSkipButton(this.Width / 2 - 9, _Red);
                ShowReturnButton(this.Width - 110, _Blue);
            }

        }

        public  void IconStatements(CYIcon MIcon)
        {
            if (MIcon == CYIcon.Information)
            {
                MessageBeep(0);
                label5.Visible = false;
                pictureBox1.BackgroundImage = Properties.Resources.Info;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (MIcon == CYIcon.Print)
            {
                MessageBeep(0);
                pictureBox1.BackgroundImage = Properties.Resources.Print;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void InfoStatements(string _msg1,CYException ex)
        {
            if (ex == CYException.PrintSuccess)
            {
                PrintSuccess();
            }

            if (ex == CYException.PrintMessage)
            {
                PrintMessage(_msg1);
            }
        }

        public void PrintMessage(string _order)
        {
            label5.Text = "打印确认";
            //label2.Text = "总份数：" + MyInfo.MyUserInfo.UserNo + "  姓名：" + MyInfo.MyUserInfo.UserName;
            label1.Text = "成绩单：" + Data.resultInfo.data.resultno;
            label3.Text = "份数：" + Data.resultInfo.data.printnum;
            label4.Text = "属性： A4黑白单面";
        }

        public void PrintSuccess()
        {
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            label4.Text = "";
            label4.Anchor = AnchorStyles.None;
            label3.Text = "";
            label2.Text = "打印机成功，请及时取走！";
            label2.Anchor = AnchorStyles.None;
            label1.Text = "";
        }

    }
}
