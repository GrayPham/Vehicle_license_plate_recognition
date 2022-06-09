using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;

namespace Vehicle_license_plate_recognition.Manager.Assignment
{
    public partial class NomalStaffAssig : Form
    {
        public NomalStaffAssig()
        {
            InitializeComponent();
        }
        AssignmentBLL assignment = new AssignmentBLL();

        private void NomalStaffAssig_Load(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            DVGStaff.Visible = false;
            fillDVGStaff();
        }

        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int count =assignment.CountNomalStaff();
            if(count < 3 )
            {
                MessageBox.Show("You currently have no employees");
                
                btnSveAssig.Enabled = false;
                EditAssig.Enabled = false;
            }
            else
            {
                tbCountStaff.Text = count.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnSveAssig_Click(object sender, EventArgs e)
        {

        }

        private void EditAssig_Click(object sender, EventArgs e)
        {

        }
        private void fillDVGStaff()
        {
            DVGStaff.DataSource = assignment.GetAllNomalStaff();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            int maxCus =Convert.ToInt32(tbCountStaff.Text);
            DVGAssigment.DataSource = assignment.findAssig(txbNumberStaff.Text, maxCus);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCountStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbNumberStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void DVGStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DVGAssigment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
