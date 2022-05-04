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

namespace Vehicle_license_plate_recognition.Manager
{
    public partial class Decentralization : Form
    {
        ManagerTacVu mTacVu = new ManagerTacVu();
        int idStaff;
        int isCaretaker = 1;
        int isOfficer = 2;
        int isManager = 3;
        public Decentralization()
        {
            InitializeComponent();
            fillDVGDecentralization();
        }
        private void fillDVGDecentralization()
        {
            DVGDecentralization.DataSource = mTacVu.GetAllRequestDecen();
            
            DVGDecentralization.Columns[4].HeaderText = " Add Date";
            DVGDecentralization.Columns[4].DefaultCellStyle.Format = "yyyy-dd-MM";
            if(DVGDecentralization.Rows.Count == 0)
            {
                lbRequest.Text = "No authorization required";
            }
        }

        private void Decentralization_Load(object sender, EventArgs e)
        {
            panelXuLi.Visible = false;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            


            panelXuLi.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(getIdStaff() == true)
            {
                int typeStaff = getTypeStaff();
                if(typeStaff != 0)
                {
                    try
                    {
                        mTacVu.UpdateTypeStaff(idStaff, typeStaff);
                        panelXuLi.Visible = false;
                        fillDVGDecentralization();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error");
                    }
                    
                }
                else
                    lbRequest.Text = "Select employee type";
            }
            else
            {
                lbRequest.Text = "No authorization required";
                panelXuLi.Visible = false;
            }

            
        }

        private void DVGDecentralization_DoubleClick(object sender, EventArgs e)
        {   
            if(getIdStaff() == true)
            {
                panelXuLi.Visible = true;
            }
            else
                lbRequest.Text = "No authorization required";
        }
        private bool getIdStaff()
        {
            if (DVGDecentralization.Rows.Count > 0)
            {
                idStaff = Convert.ToInt32(DVGDecentralization.CurrentRow.Cells[0].Value);
                return true;
            }
            else
            {
                return false;
            }    
            
        }
        private int getTypeStaff()
        {
            int typeStaff = 0;
            typeStaff = radioBtnCaretaker.Checked ==true ? isCaretaker : 
                radioBtnOfficer.Checked == true ? isOfficer : radioBtnManager.Checked == true ? isManager : 0;
            return typeStaff;


        }
    }
}
