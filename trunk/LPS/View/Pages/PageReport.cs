using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MonthCalendar;

namespace LPS.View.Pages
{
    public partial class PageReport : UserControl
    {
        /// <summary>
        /// 紀錄現在選擇的日期選擇TextBox
        /// </summary>
        private TextBox m_tbSelectSearchDate = null;

        //private MonthCalendar.Calendar Calendar = new MonthCalendar.Calendar();

        public PageReport()
        {
            InitializeComponent();
        }

        public void Setup()
        {

        }

        private void PbDateFromClear_MouseDown(object sender, MouseEventArgs e)
        {
            pbDateFromClear.Image = LPS.Properties.Resources.ModifyIconCross_;
        }

        private void PbDateFromClear_MouseUp(object sender, MouseEventArgs e)
        {
            tbSearchDateFrom.Text = "";

            pbDateFromClear.Image = LPS.Properties.Resources.ModifyIconCross;
        }

        private void PbDateToClear_MouseDown(object sender, MouseEventArgs e)
        {
            pbDateToClear.Image = LPS.Properties.Resources.ModifyIconCross_;
        }

        private void PbDateToClear_MouseUp(object sender, MouseEventArgs e)
        {
            tbSearchDateTo.Text = "";

            pbDateToClear.Image = LPS.Properties.Resources.ModifyIconCross;
        }

        /// <summary>
        /// 顯示日曆選擇物件
        /// </summary>
        /// <param name="Sender"></param>
        private void ShowCalender(Control Sender)
        {
            Point ScreenPoint = Sender.Parent.PointToScreen(Sender.Location);
            Point ClientPoint = this.PointToClient(ScreenPoint);
            ClientPoint.Y += Sender.Height;
            Calendar.Location = ClientPoint;

            if (Sender.Text.Length > 0)
                Calendar.SelectedDate = Convert.ToDateTime(Sender.Text);
            else
                Calendar.SelectedDate = DateTime.Today;

            Calendar.Visible = true;

            Calendar.Focus();
        }

        private void TbSearchDateFrom_Click(object sender, EventArgs e)
        {
            m_tbSelectSearchDate = tbSearchDateFrom;

            ShowCalender(tbSearchDateFrom);
        }

        private void TbSearchDateTo_Click(object sender, EventArgs e)
        {
            m_tbSelectSearchDate = tbSearchDateTo;

            ShowCalender(tbSearchDateTo);
        }

        private void Calendar_SelectDay(object sender, SelectDayEventArgs e)
        {
            if (Calendar.Visible)
                m_tbSelectSearchDate.Text = e.Date.ToString("yyyy-MM-dd");
        }
    }
}
