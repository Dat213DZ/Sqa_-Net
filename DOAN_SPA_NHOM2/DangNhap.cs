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



namespace login2
{
    public partial class DangNhap : Form
    {
        public static string TenDN;
        string Id = "", password = "", Chucvu = "";
        DBConnect Sconn = new DBConnect();
        TrangChu tc = new TrangChu();
        public DangNhap()
        {
            InitializeComponent();
        }

        public DangNhap(string ID, string PASSWORD, string CHUCVU)
        {
            InitializeComponent();
            this.Id = ID;
            this.password = PASSWORD;
            this.Chucvu = CHUCVU;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            TenDN = txtuser.Text;
            SqlConnection Sconn = new SqlConnection("Data Source=LAPTOP-AUIVJ6IL;Initial Catalog=QUANLI_TH_SPA;Integrated Security=True");
            SqlDataAdapter reader = new SqlDataAdapter("select Id, password, chucvu from NHANVIEN where Id ='" + txtuser.Text + "' and password = N'" + txtPassword.Text + "'", Sconn);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            string tk = txtuser.Text;
            string mk = txtPassword.Text;
            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mât khẩu");
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    TrangChu f = new TrangChu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());                   
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau mk = new QuenMatKhau();
            mk.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
    }
}
