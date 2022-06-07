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

namespace Vehicle_license_plate_recognition.Manager.Staff
{
    public partial class DeleteStaffManager : Form
    {
        ManagerStaff mStaff = new ManagerStaff();
        public DeleteStaffManager()
        {
            InitializeComponent();
        }

        private void DeleteStaffManager_Load(object sender, EventArgs e)
        {
            fillDVGStaff(1);
        }

        private void DVGEmployMoreYear_DoubleClick(object sender, EventArgs e)
        {
            txtStaff.Text = DVGEmployMoreYear.CurrentRow.Cells["ID"].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStaff.Text.Trim() != "")
            {
                if (IsNumber(txtStaff.Text))
                {
                    int idStaff = Convert.ToInt32(txtStaff.Text);
                    if (mStaff.DeleteStaff(idStaff))
                    {
                        MessageBox.Show("Successful dismissal", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int type = checkTypeStaff();
                        fillDVGStaff(type);
                    }
                    else
                    {
                        MessageBox.Show("Staff does not exist", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Employee code must be number", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter employee id or select employee in Datagridview", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fillDVGStaff(int typeStaff)
        {
            DVGEmployMoreYear.DataSource = mStaff.getAllStaffFireByType(typeStaff);
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private int checkTypeStaff()
        {
            int type = 1;
            if (radioBtnOfficer.Checked)
                type = 2;
            else if (radioBtnManager.Checked)
            {
                type = 3;
            }
            return type;
        }

        private void radioBtnCaretaker_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCaretaker.Checked)
            {
                fillDVGStaff(1);
            }
        }

        private void radioBtnOfficer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnOfficer.Checked)
            {
                fillDVGStaff(2);
            }
        }

        private void radioBtnManager_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnManager.Checked)
            {
                fillDVGStaff(3);
            }
        }
    }
}
