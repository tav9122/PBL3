using System;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThongKeTheoBieuDo : Form
    {
        public FormThongKeTheoBieuDo()
        {
            InitializeComponent();

            comboBoxKieuThongKe.SelectedIndex = 0;
            comboBoxThongKeTheo.SelectedIndex = 0;

            ReloadDataGridView(null, null);
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            chart1.ResetAutoValues();
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);
            dateTimePicker2.Value = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);

            if (comboBoxKieuThongKe.Text == "Doanh thu")
            {
                comboBoxThongKeTheo.Visible = true;
                label4.Visible = true;

                chart1.Series.Add("Doanh thu");
                chart1.Series["Doanh thu"].Label = "#VALY{C0}";
                chart1.Series["Doanh thu"].IsValueShownAsLabel = true;
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                if (comboBoxThongKeTheo.Text == "Tháng")
                {
                    chart1.ChartAreas[0].AxisX.Title = "Tháng";
                    chart1.ChartAreas[0].AxisY.Title = "VNĐ";

                    foreach (string i in BLLButtonThongKeTheoBieuDo.Instance.SplitToMonths(dateTimePicker1.Value, dateTimePicker2.Value))
                    {
                        chart1.Series["Doanh thu"].Points.AddXY(i, BLLButtonThongKeTheoBieuDo.Instance.GetDoanhThuOfMonth(i));
                    }
                }
                if (comboBoxThongKeTheo.Text == "Năm")
                {
                    chart1.ChartAreas[0].AxisX.Title = "Năm";
                    chart1.ChartAreas[0].AxisY.Title = "VNĐ";

                    foreach (string i in BLLButtonThongKeTheoBieuDo.Instance.SplitToYears(dateTimePicker1.Value, dateTimePicker2.Value))
                    {
                        chart1.Series["Doanh thu"].Points.AddXY(i, BLLButtonThongKeTheoBieuDo.Instance.GetDoanhThuOfYear(i));
                    }
                }
            }

            if (comboBoxKieuThongKe.Text == "Sản phẩm bán chạy nhất")
            {
                comboBoxThongKeTheo.Visible = false;
                label4.Visible = false;

                chart1.Series.Add("Số lượng");
                chart1.Series["Số lượng"].IsValueShownAsLabel = true;

                chart1.ChartAreas[0].AxisX.Title = "Sản phẩm";
                chart1.ChartAreas[0].AxisY.Title = "Cái";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";
                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                foreach (var i in BLLButtonThongKeTheoBieuDo.Instance.GetSanPhamBanChayNhat(dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    chart1.Series["Số lượng"].Points.AddXY(i.Key, i.Value);
                }
            }
        }
    }
}