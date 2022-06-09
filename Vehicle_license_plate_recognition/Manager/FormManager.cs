using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Manager;
using Vehicle_license_plate_recognition.Manager.Staff;
using Vehicle_license_plate_recognition.Manager.TasksManager;

namespace Vehicle_license_plate_recognition
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            customizeDesing();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void customizeDesing()
        {
            panelQlNhanSuThoSubmenu.Visible= false;
            panelSubNVVP.Visible=false;
            panelSubTacVu.Visible=false;
            panelSubPhanCong.Visible=false;
        }
        private void hideSubMenu()
        {
            if(panelQlNhanSuThoSubmenu.Visible == true)
            {
                panelQlNhanSuThoSubmenu.Visible = false;
            }
            if (panelSubNVVP.Visible == true)
            {
                panelSubNVVP.Visible = false;
            }
            if (panelSubTacVu.Visible == true)
            {
                panelSubTacVu.Visible = false;
            }
            if (panelSubPhanCong.Visible == true)
            {
                panelSubPhanCong.Visible = false;
            }
        }
        //Một phương pháp hay có thể học hỏi cách thao tác điểu khiển
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Quan Li Tho
        private void btnQLNhanSuTho_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQlNhanSuThoSubmenu);
        }

        
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AddStaffManager addStaff =new AddStaffManager();
            addStaff.ShowDialog();

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            UpdateStaffManager updateStaff =new UpdateStaffManager();
            updateStaff.ShowDialog();
        }
        private void btnFired_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FiredEmployeeManager());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DeleteStaffManager deleteStaff =new DeleteStaffManager();
            deleteStaff.ShowDialog();
        }
        #endregion
        #region Quan Lí NV Văn phòng
        private void btnNVVP_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubNVVP);
        }

        private void btnAddOfficer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AddStaffManager addStaff = new AddStaffManager();
            addStaff.ShowDialog();
        }
        private void btnUpdateOfficer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            UpdateStaffManager updateStaff = new UpdateStaffManager();
            updateStaff.ShowDialog();
        }
        
        private void btnFiredOfficer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FiredEmployeeManager());
        }
        
        private void btnDeleteOfficer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DeleteStaffManager deleteStaff = new DeleteStaffManager();
            deleteStaff.ShowDialog();
        }
        #endregion
        #region Quản lí tác vụ
        private void btnQLTacVu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubTacVu);
        }
        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            openChildForm(new Decentralization());
            hideSubMenu();
        }

        private void btnAddPark_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPark());
            hideSubMenu();
        }

        private void btnEditPark_Click(object sender, EventArgs e)
        {
            openChildForm(new EditPark());
            hideSubMenu();
        }

        private void btnDeletePark_Click(object sender, EventArgs e)
        {
            openChildForm(new DeletePark());
            hideSubMenu();
        }
        private void btnClosePark_Click(object sender, EventArgs e)
        {
            openChildForm(new ClosePark());
            hideSubMenu();
        }
        private void btnOpenPark_Click(object sender, EventArgs e)
        {
            openChildForm(new OpenPark());
            hideSubMenu();
        }
        #endregion
        #region Phân Công Công Việc
        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubPhanCong);
        }
        private void btnAssignmentStaff_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAssignmentOfficer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRequestingAbsence_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }



        #endregion
        #region Sự kiện Click
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnFiredManager_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateManager_Click(object sender, EventArgs e)
        {

        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            FormFaceRecognition faceRecognition = new FormFaceRecognition();
            faceRecognition.ShowDialog();
        }

        private void DVGManager_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}
