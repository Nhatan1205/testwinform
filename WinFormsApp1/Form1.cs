using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO HocSinhDAO = new HocSinhDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvHocSinh.DataSource = HocSinhDAO.Load(); /// gvHsinh = name cua data gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            if (Util.Ktra(hs) == false)
            {
                return;
            }
            HocSinhDAO.Them_Click(hs);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            HocSinhDAO.Xoa_Click(hs);
            Form1_Load(sender, e);
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtCmnd.Text, txtName.Text, dtbBirthday.Value, txtAddress.Text, txtEmail.Text, txtSoDienThoai.Text, GetSelectedGender());
            if (Util.Ktra(hs) == false)
            {
                return;
            }
            HocSinhDAO.Sua_Click(hs);
            Form1_Load(sender, e);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            FGiaoVien fsv = new FGiaoVien();
            fsv.Show();
            //this.Hide();
        }

        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvHocSinh.Rows[e.RowIndex];
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

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

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