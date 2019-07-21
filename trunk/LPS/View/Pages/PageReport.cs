using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MonthCalendar;
using LPS.Model.DataAccessObject;
using LPS.Model.FileExport;
using LPS.View.Component;

namespace LPS.View.Pages
{
    public partial class PageReport : UserControl
    {
        private DaoMachine m_Machine = new DaoMachine();

        private enum eDateSearchType
        {
            eDATE_ALL = 0,  //搜尋全部日期;//
            eDATE_BEFORE,   //日期向前搜尋;//
            eDATE_AFTER,    //日期向後搜尋;//
            eDATE_BETWEEN,  //搜尋日期區間;//
        }

        /// <summary>
        /// 紀錄現在選擇的日期選擇TextBox
        /// </summary>
        private TextBox m_tbSelectSearchDate = null;

        /// <summary>
        /// 紀錄目前選擇的日期搜尋結束時間
        /// </summary>
        private string m_DateSearchFrom;

        /// <summary>
        /// 紀錄目前選擇的日期搜尋結束時間
        /// </summary>
        private string m_DateSearchTo;

        /// <summary>
        /// 紀錄年月日格式的字串長度
        /// </summary>
        private int m_MounthFormatLength = "yyyy/mm/dd".Length;

        /// <summary>
        /// 顯示資料的Data Gride View
        /// </summary>
        private DataGridView m_dgvTestHistory;

        public PageReport(DaoMachine Machine)
        {
            InitializeComponent();

            m_Machine = Machine;

            m_dgvTestHistory = pdgvHistory.DataList;
            pdgvHistory.SetTotalPage(0);

            m_dgvTestHistory.RowHeadersVisible = false;
            m_dgvTestHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            m_dgvTestHistory.AllowUserToAddRows = false;
            m_dgvTestHistory.AllowUserToDeleteRows = false;
            m_dgvTestHistory.MultiSelect = false;
            m_dgvTestHistory.ReadOnly = true;
            m_dgvTestHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            m_dgvTestHistory.TabStop = false;            
        }

        public void Setup()
        {
            SearchHistory();
        }

        private void PdgvHistory_ChangePage(int Page)
        {
            SearchHistory(Page);
        }

        private void SearchHistory(int Page = 1)
        {
            //檢查日期欄位設定狀態;//
            CheckDateSearchType();

            //暫停顯示Scroll BAR，待資料整理完再一次顯示;//
            m_dgvTestHistory.ScrollBars = ScrollBars.None;

            //取得測試資料的總筆數後計算總頁數;//
            int TestTimes = DaoSQL.Instance.GetTestHistoryTotalNum(m_DateSearchFrom, m_DateSearchTo);
            int TotalPage = TestTimes % pdgvHistory.DisplayDataNumPerPage == 0 ? TestTimes / pdgvHistory.DisplayDataNumPerPage : ((TestTimes / pdgvHistory.DisplayDataNumPerPage) + 1);
            TotalPage = TotalPage == 0 ? 1 : TotalPage;
            pdgvHistory.SetTotalPage(TotalPage);

            if (Page <= 0)
                Page = 1;
            else if (Page >= TotalPage)
                Page = TotalPage;

            //設定資料;//
            int FromNo = (pdgvHistory.DisplayDataNumPerPage * (Page - 1));
            int EndNo = pdgvHistory.DisplayDataNumPerPage * Page;
            pdgvHistory.BindingData(DaoSQL.Instance.GetTestHistory(m_DateSearchFrom, m_DateSearchTo), Page);

            m_dgvTestHistory.ScrollBars = ScrollBars.Both;
        }

        /// <summary>
        /// 檢查目前日期欄位的輸入狀態
        /// </summary>
        /// <returns></returns>
        private eDateSearchType CheckDateSearchType()
        {
            //檢查兩個日期欄位都沒輸入的話，表示要搜尋全部;//
            if (tbSearchDateFrom.Text.Length <= 0
                && tbSearchDateTo.Text.Length <= 0)
            {
                m_DateSearchFrom = "";
                m_DateSearchTo = "";
                return eDateSearchType.eDATE_ALL;
            }

            //檢查只有開始日期欄位有設定，表示搜尋這日期以後;//
            if (tbSearchDateFrom.Text.Length > 0
                && tbSearchDateTo.Text.Length <= 0)
            {
                m_DateSearchFrom = tbSearchDateFrom.Text.Substring(0, m_MounthFormatLength) + " 00:00:00";
                m_DateSearchTo = "";
                return eDateSearchType.eDATE_AFTER;
            }

            //檢查只有結束日期欄位有設定，表示搜尋這日期以前;//
            if (tbSearchDateFrom.Text.Length <= 0
                && tbSearchDateTo.Text.Length > 0)
            {
                m_DateSearchFrom = "";
                m_DateSearchTo = tbSearchDateTo.Text.Substring(0, m_MounthFormatLength) + " 23:59:59";
                return eDateSearchType.eDATE_BEFORE;
            }

            //表示兩個欄位都有設定搜尋區間;//
            m_DateSearchFrom = tbSearchDateFrom.Text.Substring(0, m_MounthFormatLength) + " 00:00:00";
            m_DateSearchTo = tbSearchDateTo.Text.Substring(0, m_MounthFormatLength) + " 23:59:59";
            return eDateSearchType.eDATE_BETWEEN;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //檢查時間日期的正確性;//
            if (tbSearchDateFrom.Text.Length > 0
                && tbSearchDateTo.Text.Length > 0)
            {
                //若結束時間大於起始時間調換換時間;//
                if (Convert.ToDateTime(tbSearchDateFrom.Text) > Convert.ToDateTime(tbSearchDateTo.Text))
                {
                    string Temp = string.Copy(tbSearchDateFrom.Text);
                    tbSearchDateFrom.Text = string.Copy(tbSearchDateTo.Text);
                    tbSearchDateTo.Text = string.Copy(Temp);
                }
            }

            //重新計算頁數等項目;//
            this.SearchHistory();
        }
        
        /// <summary>
        /// 匯出報表按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExport_Click(object sender, EventArgs e)
        {
            //先取得資料看有無資訊，沒有的話就不執行匯出動作;//
            if (m_dgvTestHistory.Rows.Count <= 0)
            {
                MessageBoxEx.Show(this, "沒有任何測試紀錄可供匯出檔案.", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //顯示除儲存檔案視窗;//
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.Title = "匯出檔案";
            Dialog.InitialDirectory = ".\\";
            Dialog.Filter = "xls files (*.*)|*.xls";

            //因為檔名不允許使用冒號 所以換成空白
            //因為Now一定是有資料 所以不用先判斷是否有資料才取值
            String TimeForFileName = DateTime.Now.ToString("yyyy-MM-dd");

            Dialog.FileName = string.Format("{0}-{1}_{2}.xls", m_Machine.機台代碼, m_Machine.描述, TimeForFileName );

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //先取得所有資料集;//
                DataSet Ds = new DataSet();
                Ds.Tables.Add(DaoSQL.Instance.GetTestHistory(m_DateSearchFrom, m_DateSearchTo));

                //輸出檔案成Excel檔;//
                try
                {
                    FileExport.ExportDataSetToExcel(Ds, Dialog.FileName);
                    MessageBoxEx.Show(this, string.Format("匯出檔案成功!\r\n檔名:{0}", Dialog.FileName), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, string.Format("匯出檔案失敗!\r\n資訊:{0}", ex.Message), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #region 月曆功能
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

            Calendar.Refresh();
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

        #endregion
    }
}
