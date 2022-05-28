using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.DAL.OfficeStaff;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.OfficeStaff
{
    public class CustomerBLL
    {
        CustomerDTO customerDTO = new CustomerDTO();
        internal void AddCustomerBLL(string id, string type , string fname , DateTime birthdate, string email, string gender, string phone)
        {
            // Thông tin phải được điền đầy đủ
            if(String.IsNullOrEmpty(id) == true || String.IsNullOrEmpty(fname) == true || String.IsNullOrEmpty(phone) == true || String.IsNullOrEmpty(email) == true)
            {
                MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            // Check ma toan so hay khong
            else if(IsNumber(id) == false)
            {
                MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
            // fullname toan ki tu
            else if(IsCharacter(fname) == false)
            {
                MessageBox.Show("Full name must be characters and has white space!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Phone Toàn số
            else if (IsNumber(phone) == false)
            {
                MessageBox.Show("Phone must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }        
            // Phone number Xử lí đúng chuẩn
            else if (IsValidPhone(phone) == false)
            {
                MessageBox.Show("Please enter 9 or 10 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Email Xử lí đúng chuẩn
            else if (IsValidEmail(email) == false)
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
                    MessageBox.Show("The Customer Age Must Be Between 15 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Regex isValidInput = new Regex(@"^[0-9]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;
        }
        // Ô nhập vào không được là số, kí hiệu
        public bool IsCharacter(string pValue)
        {
            Regex isValidInput = new Regex(@"^[a-zA-Z\s]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;
        }
        // Kiểm tra số nhập vào ko vượt quá 10 số
        public bool IsValidPhone(string phone)
        {
            Regex isValidInput = new Regex(@"^\d{9,10}$");
            if (!isValidInput.IsMatch(phone))
            {
                return false;

            }
            return true;
        }

        // Kiểm tra mail đúng chuẩn example123@gmail.com
        public bool IsValidEmail(string email)
        {
            Regex isValidInput = new Regex(@"^[a-zA-Z]*[0-9]*@gmail*\.com$");
            if (!isValidInput.IsMatch(email))
            {
                return false;

            }
            return true;
        }

        internal void UpdateCustomerBLL(string id, string type, string fname, DateTime birthdate, string email, string gender, string phone)
        {
            try
            {
                // Thông tin phải được điền đầy đủ
                if (String.IsNullOrEmpty(id) == true || String.IsNullOrEmpty(fname) == true || String.IsNullOrEmpty(phone) == true || String.IsNullOrEmpty(email) == true)
                {
                    MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                // Check ma toan so hay khong
                else if (IsNumber(id) == false)
                {
                    MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // fullname toan ki tu
                else if (IsCharacter(fname) == false)
                {
                    MessageBox.Show("Full name must be characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // Phone Toàn số
                else if (IsNumber(phone) == false)
                {
                    MessageBox.Show("Phone must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                // Phone number Xử lí đúng chuẩn
                else if (IsValidPhone(phone) == false)
                {
                    MessageBox.Show("Please enter 9 or 10 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Email Xử lí đúng chuẩn
                else if (IsValidEmail(email) == false)
                {
                    MessageBox.Show("Email format error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (true)
                {
                    int idCus = Convert.ToInt32(id);
                    int typeCus = Convert.ToInt32(type);
                    var checkChange = CustomerDTO.db.Customers.Where(test => test.Id == idCus && test.TypeID == typeCus && test.FullName == fname 
                                                                     && test.BirthDate == birthdate && test.Email == email && test.Gender==gender && test.Phone == phone);
                    int born_year = birthdate.Year;
                    int this_year = DateTime.Now.Year;
                    // Check tuổi
                    if (((this_year - born_year) < 15) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("The Customer Age Must Be Between 15 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkChange.Count() == 0)
                    {
                        getAllCustomer();
                        customerDTO.UpdateCustomer(idCus, typeCus, fname, birthdate, email, gender, phone);
                        MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nothing change!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not update. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        // Xử lý combobox
        internal object getAllCustomer()
        {
            var combox = customerDTO.getAllCustomer();
            if (combox != null)
            {
                return combox;
            }
            return null;
        }
        // Hiển thị thông tin khách hàng theo id
        internal Customer diplayCustomer(int id)
        {
            Customer cus = customerDTO.diplayCustomer(id);
            if (cus != null)
            {
                return cus;
            }
            return null;
        }

        // Xóa khách theo mã id
        internal void DeleteCus(int id)
        {
            customerDTO.DeleteCus(id);
        }

        //
        internal object diplayCustomerID(int search)
        {
            var cus = customerDTO.diplayCustomerID(search);
            if (cus != null)
            {
                return cus;
            }
            return null;
        }

    }
}
