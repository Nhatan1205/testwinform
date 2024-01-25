using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Util
    {
        public static bool KtrEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                string pattern = @"^[a-zA-Z0-9_.+-]+@(?!.*\d{2,})([a-zA-Z0-9-]+\.)+[a-zA-Z0-9-.]+$";
                return Regex.IsMatch(email, pattern);
            }
            return false;
        }
        public static bool KtrSdt(string sdt)
        {
            if (!string.IsNullOrEmpty(sdt))
            {
                string cleanedPhone = new string(sdt.Where(char.IsDigit).ToArray());
                return cleanedPhone.Length == 10 && cleanedPhone.Equals(sdt);
            }
            return false;
        }
        public static bool KtrTren18Tuoi(string ngaySinhStr)
        {
            DateTime ngaySinh;
            if (DateTime.TryParse(ngaySinhStr, out ngaySinh))
            {
                DateTime ngayHienTai = DateTime.Now;
                int tuoi = ngayHienTai.Year - ngaySinh.Year;
                if (ngayHienTai.Month < ngaySinh.Month || (ngayHienTai.Month == ngaySinh.Month && ngayHienTai.Day < ngaySinh.Day))
                {
                    tuoi--;
                }
                return tuoi >= 18;
            }
            else
            {
                Console.WriteLine("Ngày sinh không hợp lệ.");
                return false;
            }
        }
        public static bool Ktra(ConNguoi conguoi)
        {
            if (KtrEmail(conguoi.Email) == false)
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (KtrSdt(conguoi.Phone) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(KtrTren18Tuoi(conguoi.Ngaysinh.ToString()) == false)
            {
                MessageBox.Show("Tuoi không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(conguoi.Ten))
            {
                MessageBox.Show("Chua dien Ten", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(conguoi.Diachi))
            {
                MessageBox.Show("Chua dien DiaChi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(conguoi.Id))
            {
                MessageBox.Show("Chua dien Cmnd", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(conguoi.Gioitinh))
            {
                MessageBox.Show("Chua dien Gioitinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
