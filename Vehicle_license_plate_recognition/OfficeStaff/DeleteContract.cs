using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.OfficeStaff;

namespace Vehicle_license_plate_recognition.OfficeStaff
{
    public partial class DeleteContract : Form
    {
        public DeleteContract()
        {
            InitializeComponent();
        }
        ContractBLL contract = new ContractBLL();


        private void DeleteContract_Load(object sender, EventArgs e)
        {
            fillDVGDelete();
        }
        private void fillDVGDelete()
        {
            DVGContract.DataSource = contract.getAllContractExprire();
        }

        private void DVGContract_DoubleClick(object sender, EventArgs e)
        {
            if(DVGContract.DataSource != null)
            {
                txbID.Text = DVGContract.CurrentRow.Cells["ID"].Value.ToString();
                txbNameContract.Text = DVGContract.CurrentRow.Cells["NAME"].Value.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contract.DeleteContract(txbID.Text))
            {
                MessageBox.Show("Delete successfully!", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deletion failed!", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select contract code in DVG!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
