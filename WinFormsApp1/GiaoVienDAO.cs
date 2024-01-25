using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using WinFormsApp1;
namespace WinFormsApp1
{
    class GiaoVienDAO : ConNguoiDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dbconnection = new DBconnection();
        public GiaoVienDAO()
        {
            tablename = "GiaoVien";
        }
        //public void Them_Click(GiaoVien gv)
        //{
        //     string SQL = string.Format("INSERT INTO GiaoVien(Ten , Diachi, CMND, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", gv.Ten, gv.Diachi, gv.Id, gv.Ngaysinh.ToString("yyyy-MM-dd"));
        //     dbconnection.Execute(SQL);
        //}

        //public void Xoa_Click(GiaoVien gv)
        //{
        //      string SQL = string.Format("DELETE FROM GiaoVien WHERE cmnd = '{0}'", gv.Id);
        //      dbconnection.Execute(SQL);
        //}

        //public void Sua_Click(GiaoVien gv)
        //{
        //    string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{2}' WHERE Cmnd = '{3}'", gv.Ten, gv.Diachi, gv.Ngaysinh.ToString("yyyy-MM-dd"), gv.Id);
        //    dbconnection.Execute(SQL);
        //}
        //public DataTable Load()
        //{
        //    string sqlStr = string.Format("SELECT *FROM GiaoVien");
        //    return dbconnection.Load(sqlStr);
        //} 
    }
}