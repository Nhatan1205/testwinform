using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;
namespace WinFormsApp1
{ 
    class HocSinhDAO : ConNguoiDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dbconnection = new DBconnection();
        public HocSinhDAO()
        {
            tablename = "HocSinh";
        }
        //public void Them_Click(HocSinh hs)
        //{
        //    string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, CMND, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", hs.Ten, hs.Diachi, hs.Id, hs.Ngaysinh.ToString("yyyy-MM-dd"));
        //    dbconnection.Execute(sqlStr);
        //}

        //public void Xoa_Click(HocSinh hs)
        //{
        //     string SQL = string.Format("DELETE FROM HocSinh WHERE cmnd = '{0}'", hs.Id);
        //     dbconnection.Execute(SQL);
        //}

        //public void Sua_Click(HocSinh hs)
        //{
        //    string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{2}' WHERE Cmnd = '{3}'", hs.Ten, hs.Diachi, hs.Ngaysinh.ToString("yyyy-MM-dd"), hs.Id);
        //    dbconnection.Execute(SQL);   
        //}

        //public DataTable Load()
        //{
        //    string sqlStr = string.Format("SELECT *FROM HocSinh");
        //    return dbconnection.Load(sqlStr);
        //}

        
    }
}