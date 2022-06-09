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
    internal class ContractBLL
    {
        ContractDTO conDTO = new ContractDTO();
        internal void AddContractBLL(int id, string name, string content, int staff, int idrenter, DateTime create, DateTime expiry, int type, decimal total)
        {
            try
            {
                // Thông tin phải được điền đầy đủ
                if (String.IsNullOrEmpty(name) == true || String.IsNullOrEmpty(content) == true)
                {
                    MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                // Name toan ki tu
                else if (IsCharacter(name) == false)
                {
                    MessageBox.Show("Full name must be characters and has white space!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (true)
                {
                    var checkRepeat = ContractDTO.db.Contracts.Where(test => test.Id == id);

                    // Check năm create phải expiry
                    if (create > expiry)
                    {
                        MessageBox.Show("The contract creation time must be less than the contract expiration time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Check trùng
                    else if (checkRepeat.Count() == 0)
                    {
                        ContractDTO.AddContract(id, name, content, staff, idrenter, create, expiry, type, total);
                        MessageBox.Show("Inserted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can not insert duplicate ID. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not add Contract. Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal bool DeleteContract(string idContract)
        {
            if (conDTO.DeleteContractDTO(idContract))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal object getAllContractExprire()
        {
            var contract = conDTO.getAllContractExprire();
            return contract;
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

        // Hiển thị thông tin khách hàng lên hợp đồng
        internal object getAllContract()
        {
            var cus = conDTO.getAllContract();
            if (cus != null)
            {
                return cus;
            }
            return null;
        }

        // Xử lý combobox
        internal object getAllCustomer(int type)
        {
            var combox = conDTO.checkID(type);
            if (combox != null)
            {
                return combox;
            }
            return null;
        }
        internal void EditContractBLL(int id, string name, string content, int staff, int idrenter, DateTime create, DateTime expiry, int type, decimal total)
        {
            try
            {
                // Thông tin phải được điền đầy đủ
                if (String.IsNullOrEmpty(name) == true || String.IsNullOrEmpty(content) == true)
                {
                    MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                // Name toan ki tu
                else if (IsCharacter(name) == false)
                {
                    MessageBox.Show("Full name must be characters and has white space!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (true)
                {
                    // Kiểm tra sự thay đổi
                    var checkRepeat = ContractDTO.db.Contracts.Where(test => test.NameContract == name || test.Information == content ||
                                                                     test.CreationTime == create || test.ExpiryDate == expiry || test.TypeConTract == type);

                    // Check năm create phải expiry
                    if (create > expiry)
                    {
                        MessageBox.Show("The contract creation time must be less than the contract expiration time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Check giống
                    else if (checkRepeat.Count() == 0)
                    {
                        getAllContract();
                        ContractDTO.EditContract(id, name, content, staff, idrenter, create, expiry, type, total);
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
                MessageBox.Show("Can not add Contract. Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hiển thị thông tin hợp đồng theo id
        internal Contract diplayCon(int id)
        {
            Contract cus = conDTO.diplayCon(id);
            if (cus != null)
            {
                return cus;
            }
            return null;
        }


    }
}
