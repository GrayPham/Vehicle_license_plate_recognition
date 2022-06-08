using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller;
using Vehicle_license_plate_recognition.Controller.OfficeStaff;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.OfficeStaff.Status
{
    public partial class SearchContract : Form
    {
        public SearchContract()
        {
            InitializeComponent();
        }
        SearchContractC searchContract = new SearchContractC();
        PrintWord printWord = new PrintWord();

        private void btnPrintWord_Click(object sender, EventArgs e)
        {
            string idStaff = DVGContract.CurrentRow.Cells["Staff"].Value.ToString();
            int idContact = Convert.ToInt32(DVGContract.CurrentRow.Cells["ID"].Value.ToString());
            DateTime createTime = (DateTime)DVGContract.CurrentRow.Cells["CREATIME"].Value;
            DateTime experTime = (DateTime)DVGContract.CurrentRow.Cells["EXPIRYDATE"].Value;
            string price = DVGContract.CurrentRow.Cells["PRICE"].Value.ToString();
            int idCustomer =Convert.ToInt32( DVGContract.CurrentRow.Cells["CUSTOMER"].Value);
            var customer = searchContract.GetCustomerByID(idCustomer);
            var staff = searchContract.GetStaffByID(idStaff);
            string nameCus = customer.FullName;
            string nameStaff = staff.HoVaTenNV;
            string phone = customer.Phone;
            string email = customer.Email;
            if (printWord.ExportWord(idContact,nameStaff,nameCus,phone,email,price,createTime,experTime))
            {
                MessageBox.Show("File export successful", "Export Word");
            }
            else
            {
                MessageBox.Show("File export error", "Export Word");
            }
        }

        
        

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillDVG(int index =0)
        {
            
            DVGContract.DataSource = searchContract.getAllContact(index);
        }

        private void SearchContract_Load(object sender, EventArgs e)
        {
            fillDVG();
        }

        private void rBtnOverdue_CheckedChanged(object sender, EventArgs e)
        {
            fillDVG(2);
        }

        private void rBtStillUse_CheckedChanged(object sender, EventArgs e)
        {
            fillDVG(1);
        }

        private void rBtnAllUse_CheckedChanged(object sender, EventArgs e)
        {
            fillDVG();
        }

        private void DVGContract_DoubleClick(object sender, EventArgs e)
        {
            btnPrintWord.Enabled = true;
        }
    }
}
