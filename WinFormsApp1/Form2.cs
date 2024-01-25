using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class FGiaoVien : Form
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDAO GiaoVienDAO = new GiaoVienDAO();
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            Form1 fgv = new Form1();
            fgv.Show();
            //this.Hide();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            gvGiaoVien.DataSource = GiaoVienDAO.Load(); /// gvHsinh = name cua data gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            if (Util.Ktra(gv) == false)
            {
                return;
            }
            GiaoVienDAO.Them_Click(gv);
            FGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            GiaoVienDAO.Xoa_Click(gv);
            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            if (Util.Ktra(gv) == false)
            {
                return;
            }
            GiaoVienDAO.Sua_Click(gv);
            FGiaoVien_Load(sender, e);
        }

        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvGiaoVien.Rows[e.RowIndex];
                txtName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtCmnd.Text = row.Cells[2].Value.ToString();
                DateTime dt = Convert.ToDateTime(row.Cells[3].Value.ToString());
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtSoDienThoai.Text = row.Cells[5].Value.ToString();

                string gender = row.Cells[6].Value.ToString();

                // Check the radio button based on the gender value
                if (gender == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gender == "Nu")
                {
                    rdoNu.Checked = true;
                }


                dtbBirthday.Value = dt;
            }
        }

        private string GetSelectedGender()
        {
            if (rdoNam.Checked)
            {
                return "Nam";
            }
            else if (rdoNu.Checked)
            {
                return "Nu";
            }
            else
            {
                return "";
            }
        }

        private void btnXoaText_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }
    }

}
