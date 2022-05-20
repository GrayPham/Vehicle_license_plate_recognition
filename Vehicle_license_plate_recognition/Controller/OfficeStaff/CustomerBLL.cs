using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.DAL.OfficeStaff;

namespace Vehicle_license_plate_recognition.Controller.OfficeStaff
{
    public class CustomerBLL
    {
        CustomerDTO customerDTO = new CustomerDTO();
        internal void AddCustomerBLL(string id, string type , string fname , DateTime birthdate, string email, string gender, string phone)
        {
            // Check ma toan so hay khong
            if(IsNumber(id) == false)
            {
                MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
            // fullname toan ki tu
            else if(IsCharacter(fname) == false)
            {
                MessageBox.Show("Full name must be characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Phone Toàn số
            else if (IsNumber(phone) == false)
            {
                MessageBox.Show("Phone must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
         
            // Email Xử lí đúng chuẩn
            else if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email format error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (true)
            {
                int idCus = Convert.ToInt32(id);
                int typeCus = Convert.ToInt32(type);
                var checkRepeat = CustomerDTO.db.Customers.Where(test => test.Id == idCus || test.Email == email);
                int born_year = birthdate.Year;
                int this_year = DateTime.Now.Year;
                // Check tuổi
                if (((this_year - born_year) < 15) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Customer Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
                // Check trùng
                else if (checkRepeat.Count() == 0)
                {
                    customerDTO.AddCustomer(idCus, typeCus, fname, birthdate, email, gender, phone);
                    MessageBox.Show("Inserted successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not insert duplicate ID and Email. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    

            }
            
        }

        // Ô nhập vào không được là kí tự, kí hiệu và khoảng trắng 
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c) && !(Char.IsSymbol(c)))
                    return false;
            }
            return true;
        }
        // Ô nhập vào không được là số, kí hiệu và khoảng trắng 
        public bool IsCharacter(string pValue)
        {
            foreach (Char a in pValue)
            {
                if (!Char.IsLetter(a) && !(Char.IsWhiteSpace(a))&&!(Char.IsSymbol(a)))
                    return false;
            }
            return true;
        }
    }
}
