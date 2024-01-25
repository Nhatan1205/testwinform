using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class ConNguoiDAO
    {
        protected string tablename;
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        protected DBconnection dbconnection = new DBconnection();
        
        public ConNguoiDAO() { }

        public void Them_Click(ConNguoi conNguoi)
        {
            string SQL = string.Format("INSERT INTO " + tablename + "(Ten , Diachi, CMND, NgaySinh, Email, Phone, GioiTinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", conNguoi.Ten, conNguoi.Diachi, conNguoi.Id, conNguoi.Ngaysinh.ToString("yyyy-MM-dd"), conNguoi.Email, conNguoi.Phone, conNguoi.Gioitinh);
            dbconnection.Execute(SQL);
        }
        public void Xoa_Click(ConNguoi conNguoi)
        {
            string SQL = string.Format("DELETE FROM " + tablename + " WHERE cmnd = '{0}'", conNguoi.Id);
            dbconnection.Execute(SQL);
        }
        public void Sua_Click(ConNguoi conNguoi)
        {
            string SQL = string.Format("UPDATE " + tablename + " SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{2}', Email = '{3}', Phone = '{4}', GioiTinh = '{5}' WHERE Cmnd = '{6}'", conNguoi.Ten, conNguoi.Diachi, conNguoi.Ngaysinh.ToString("yyyy-MM-dd"),conNguoi.Email, conNguoi.Phone, conNguoi.Gioitinh ,conNguoi.Id);
            dbconnection.Execute(SQL);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM " + tablename);
            return dbconnection.Load(sqlStr);
        }
        ~ConNguoiDAO() { }
    }
}
