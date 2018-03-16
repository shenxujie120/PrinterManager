using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;


namespace PrinterManager
{
    class resizeForm : Form
    {
        public resizeForm()
        {
        }
        public void firstDemo(Form it)
        {
            int count = it.Controls.Count * 5 + 2;
            float[] dimen = new float[count];
            int i = 0;
            dimen[i++] = (float)it.Size.Width;
            dimen[i++] = (float)it.Size.Height;
            foreach (Control ctrl in it.Controls)
            {
                dimen[i++] = ctrl.Size.Width;//原有宽
                dimen[i++] = ctrl.Size.Height;//原有高
                dimen[i++] = ctrl.Location.X;//原有左
                dimen[i++] = ctrl.Location.Y;//原有高
                dimen[i++] = ctrl.Font.Size;//原有字体大小
            }
            it.Tag = dimen;
            //it.Visible = false;
        }
        public void resizeStatus(Form it)
        {
            float[] newDimen = (float[])it.Tag;
            int i = 2;
            float xPercent = it.Size.Width / newDimen[0];//当前的宽度比原有宽度
            float yPercent = it.Size.Height / newDimen[1];//当前高度比原有高度
            foreach (Control ctrl in it.Controls)
            {
                ctrl.Width = (int)(newDimen[i++] * xPercent);
                ctrl.Height = (int)(newDimen[i++] * yPercent);
                ctrl.Left = (int)(newDimen[i++] * xPercent);
                ctrl.Top = (int)(newDimen[i++] * yPercent);
                ctrl.Font = new Font(ctrl.Font.FontFamily, newDimen[i++] * xPercent);
            }
            //it.Visible = true;
        }

    }
}
