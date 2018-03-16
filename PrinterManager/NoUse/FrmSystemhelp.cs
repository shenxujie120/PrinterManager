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
    public partial class Frm_Systemhelp : Form
    {
        public Frm_Systemhelp()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FormPaint.SetWindowRegion(this);
        }

        private void Frm_Systemhelp_Load(object sender, EventArgs e)
        {
            label1.Location = new System.Drawing.Point(this.Width / 2, 13);
        }


    }
}
