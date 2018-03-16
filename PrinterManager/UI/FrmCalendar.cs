using System;
using System.Windows.Forms;

namespace PrinterManager
{
    public partial class FrmCalendar : CCWin.CCSkinMain
    {
        public string SetYear, SetMonth, SetDay;

        public FrmCalendar()
        {
            InitializeComponent();
        }

        public FrmCalendar(string year,string month,string day)
        {
            SetYear = year;
            SetMonth = month;
            SetDay = day;
            InitializeComponent();
        }

        bool Isleapyear = false;
        int PlusOrMinus = 0;//0默认无单击，1增加，2 减少
        int YearMonthDay = 0;//0无，1年份，2月份,3日期

        private void IsOrNotleapyear(string str)
        {
            int year = Convert.ToInt32(Lbl_YearValue.Text);
            if (year % 100 != 0 && year % 4 == 0)
            {
                Isleapyear = true;
            }
            else
            {
                if (year % 400 == 0)
                    Isleapyear = true;
                else
                    Isleapyear = false;
            }
        }

        private bool Dayofleapyear()
        {
            if (Lbl_MonthValue.Text == "2")
                if (Isleapyear)
                {
                    if (Convert.ToInt32(Lbl_DayValue.Text) >= 29)
                    {
                        Lbl_DayValue.Text = "29";
                        return false;
                    }
                }
                else
                {
                    if (Convert.ToInt32(Lbl_DayValue.Text) >= 28)
                    {
                        Lbl_DayValue.Text = "28";
                        return false;
                    }  
                }

            if (Lbl_MonthValue.Text == "4" || Lbl_MonthValue.Text == "6" || Lbl_MonthValue.Text == "9" || Lbl_MonthValue.Text == "11")
            {
                if (Convert.ToInt32(Lbl_DayValue.Text) >= 30)
                {
                    Lbl_DayValue.Text = "30";
                    return false;
                }  
            }
            else
            {
                if (Convert.ToInt32(Lbl_DayValue.Text) >= 31)
                {
                    Lbl_DayValue.Text = "31";
                    return false;
                }  
            }
            return true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch(PlusOrMinus)
            {
                default:
                    break;
                case 1:
                    switch (YearMonthDay)
                    {
                        default:
                            break;
                        case 1:
                            Lbl_YearValue.Text = (Convert.ToInt32(Lbl_YearValue.Text) + 1).ToString();
                            IsOrNotleapyear(Lbl_YearValue.Text);
                            Dayofleapyear();
                            break;
                        case 2:
                            if (Convert.ToInt32(Lbl_MonthValue.Text) >= 12)
                            {
                                Lbl_MonthValue.Text = "12";
                                Timer.Enabled = false;
                            }
                            else
                            {
                                Lbl_MonthValue.Text = (Convert.ToInt32(Lbl_MonthValue.Text) + 1).ToString();
                                Dayofleapyear();
                            }  
                            break;
                        case 3:
                            if (!Dayofleapyear())
                                Timer.Enabled = false;
                            else
                                Lbl_DayValue.Text = (Convert.ToInt32(Lbl_DayValue.Text) + 1).ToString();
                            break;
                    }
                    break;
                case 2:
                    switch (YearMonthDay)
                    {
                        default:
                            break;
                        case 1:
                            if (Convert.ToInt32(Lbl_YearValue.Text) <= 0)
                            {
                                Lbl_YearValue.Text = "0";
                                Timer.Enabled = false;
                            }
                            else
                            {
                                Lbl_YearValue.Text = (Convert.ToInt32(Lbl_YearValue.Text) - 1).ToString();
                                IsOrNotleapyear(Lbl_YearValue.Text);
                                Dayofleapyear();
                            }
                            break;
                        case 2:
                            if (Convert.ToInt32(Lbl_MonthValue.Text) <= 0)
                            {
                                Lbl_MonthValue.Text = "0";
                                Timer.Enabled = false;
                            }
                            else
                            {
                                Lbl_MonthValue.Text = (Convert.ToInt32(Lbl_MonthValue.Text) - 1).ToString();
                                Dayofleapyear();
                            }
                            break;
                        case 3:
                            if (Convert.ToInt32(Lbl_DayValue.Text) <= 0)
                            {
                                Lbl_DayValue.Text = "0";
                                Timer.Enabled = false;
                            }
                            else
                                Lbl_DayValue.Text = (Convert.ToInt32(Lbl_DayValue.Text) - 1).ToString();
                            break;
                    }
                    break;
            }
        }
        //======================================减

        private void Btn_YearMinus_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(Lbl_YearValue.Text) <= 1)
            {
                Lbl_YearValue.Text = "1";
                Timer.Enabled = false;
            }
            else
            {
                Lbl_YearValue.Text = (Convert.ToInt32(Lbl_YearValue.Text) - 1).ToString();
                PlusOrMinus = 2;
                YearMonthDay = 1;
                IsOrNotleapyear(Lbl_YearValue.Text);
                Dayofleapyear();
                Timer.Enabled = true;
            } 
        }

        private void Btn_MonthMinus_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(Lbl_MonthValue.Text) <= 1)
            {
                Lbl_MonthValue.Text = "1";
                Timer.Enabled = false;
            }
            else
            {
                Lbl_MonthValue.Text = (Convert.ToInt32(Lbl_MonthValue.Text) - 1).ToString();
                PlusOrMinus = 2;
                YearMonthDay = 2;
                Dayofleapyear();
                Timer.Enabled = true;
            }
        }

        private void Btn_DayMinus_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(Lbl_DayValue.Text) <= 1)
            {
                Lbl_DayValue.Text = "1";
                Timer.Enabled = false;
            }
            else
            {
                Lbl_DayValue.Text = (Convert.ToInt32(Lbl_DayValue.Text) - 1).ToString();
                PlusOrMinus = 2;
                YearMonthDay = 3;
                Timer.Enabled = true;
            }
        
        }

        //======================================加

        private void Btn_YearPlus_MouseDown(object sender, MouseEventArgs e)
        {
            Lbl_YearValue.Text = (Convert.ToInt32(Lbl_YearValue.Text) + 1).ToString();
            PlusOrMinus = 1;
            YearMonthDay = 1;
            IsOrNotleapyear(Lbl_YearValue.Text);
            Dayofleapyear();
            Timer.Enabled = true;
        }

        private void Btn_MonthPlus_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(Lbl_MonthValue.Text) >= 12)
            {
                Lbl_MonthValue.Text = "12";
                Timer.Enabled = false;
            }
            else
            {
                Lbl_MonthValue.Text = (Convert.ToInt32(Lbl_MonthValue.Text) + 1).ToString();
                PlusOrMinus = 1;
                YearMonthDay = 2;
                Dayofleapyear();
                Timer.Enabled = true;
            }
        }

        private void Btn_DayPlus_MouseDown(object sender, MouseEventArgs e)
        {
            if(!Dayofleapyear())
            {
                Timer.Enabled = false;
            }
            else
            {
                Lbl_DayValue.Text = (Convert.ToInt32(Lbl_DayValue.Text) + 1).ToString();
                PlusOrMinus = 1;
                YearMonthDay = 3;
                Timer.Enabled = true;
            }
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            Lbl_YearValue.Text = SetYear;
            Lbl_MonthValue.Text = SetMonth;
            Lbl_DayValue.Text = SetDay;
        }

        //=======================================

        private void Btn_YearMonDayPlusOrMinus_MouseUp(object sender, MouseEventArgs e)
        {
            YearMonthDay = 0;
            PlusOrMinus = 0;
            Timer.Enabled = false;
        }

        private void Btn_TimeConfirm_Click(object sender, EventArgs e)
        {
            SetYear = Lbl_YearValue.Text;
            SetMonth = Lbl_MonthValue.Text;
            SetDay = Lbl_DayValue.Text;
            this.Close();
        }
    }
}
