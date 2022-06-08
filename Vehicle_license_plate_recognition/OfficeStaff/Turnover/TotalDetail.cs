using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Vehicle_license_plate_recognition.Controller.OfficeStaff;

namespace Vehicle_license_plate_recognition.OfficeStaff.Turnover
{
    public partial class TotalDetail : Form
    {
        public TotalDetail()
        {
            InitializeComponent();
        }
        turnover turnover = new turnover();
        private void TotalDetail_Load(object sender, EventArgs e)
        {
            txtIDStaff.Text = GlobalData.idStaff.ToString();
            fillDVGRevenu(2);
            fillchart(DVGTurnOrver);

        }
        private void fillchart(DataGridView dataGridView)
        {
            chart1.Series["Price"].Points.Clear();
            chart2.Series["Price"].Points.Clear();
            chart3.Series["Price"].Points.Clear();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                chart2.Series["Price"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells["Price"].Value);
                chart1.Series["Price"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells["Price"].Value);
                chart3.Series["Price"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells["Price"].Value);

                chart1.Series[0].ChartType = SeriesChartType.Pie;
                chart2.Series[0].ChartType = SeriesChartType.Line;
            }
        }

        private void DVGTurnOrver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillDVGRevenu(int type)
        {
            if(type == 2)
            {
                DVGTurnOrver.DataSource = turnover.GetRevenuByYear();
                // By Year
            }
            else if(type == 1) {
                //By Mouth
                DVGTurnOrver.DataSource = turnover.GetRevenuByMouth();
            }
            
        }
        

        private void rBtnYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnYear.Checked)
            {
                fillDVGRevenu(2);
                fillchart(DVGTurnOrver);
            }
        }

        private void rBtnMouth_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMouth.Checked)
            {
                fillDVGRevenu(1);
                fillchart(DVGTurnOrver);
            }
        }
    }
}
