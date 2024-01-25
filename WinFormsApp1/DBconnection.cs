using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    class DBconnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
         public void Execute(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                //HocSinh hs = new HocSinh(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text);
                //string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, CMND, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", hs.Ten, hs.Diachi, hs.Id, hs.Ngaysinh.ToString("yyyy-MM-dd"));
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return new DataTable();
        }
    }
    
}
