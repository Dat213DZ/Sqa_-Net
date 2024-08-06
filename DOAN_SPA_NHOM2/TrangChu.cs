using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
    public partial class TrangChu : Form
    {
        string Id = "", password = "", Chucvu = "";
        public TrangChu()
        {
            InitializeComponent();
        }


        private Form currentFormChild;
        private void OpenChildFrom(Form childFrom)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            pan_body.Controls.Add(childFrom);
            pan_body.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        public TrangChu(string ID, string PASSWORD, string CHUCVU)
        {
            InitializeComponent();
            this.Id = ID;
            this.password = PASSWORD;
            this.Chucvu = CHUCVU;
        }
        private void btn_kh_Click(object sender, EventArgs e)
        {
            SqlConnection Sconn = new SqlConnection("Data Source=LAPTOP-AUIVJ6IL;Initial Catalog=QUANLI_TH_SPA;Integrated Security=True");
            SqlDataAdapter reader = new SqlDataAdapter("select Id, password, chucvu from NHANVIEN where Id ='" + Id + "' and password = N'" + password + "'", Sconn);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            OpenChildFrom(new Khachhang(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString()));
            lb_tieude.Text = btn_kh.Text;
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Dichvu());
            lb_tieude.Text = btn_dv.Text;
        }

        private void btn_goidv_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Goidichvu());
            lb_tieude.Text = btn_goidv.Text;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new SanPham());
            lb_tieude.Text = btn_sp.Text;
        }

        private void btn_lt_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new LieuTrinh());
            lb_tieude.Text = btn_lt.Text;
        }

        private void btn_lh_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new LichHen());
            lb_tieude.Text = btn_lh.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lb_tieude.Text = "Home";
        }

        private void btn_tt_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(new Thanhtoan());
            lb_tieude.Text = btn_tt.Text;
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn muốn đăng xuất ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ketqua == DialogResult.OK)
            {
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }
        }

        private void btn_dx_Click(object sender, EventArgs e)
        {
            DialogResult ketqua1 = MessageBox.Show("Bạn muốn đăng xuất ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ketqua1 == DialogResult.OK)
            {
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }

        }

        private void lb_tieude_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            Report rp = new Report(Id, password, Chucvu);
            rp.Show();
            this.Hide();
        }

    }
}
