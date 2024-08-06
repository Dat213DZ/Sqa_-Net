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
    public partial class QuenMatKhau : Form
    {
        DBConnect Sconn = new DBConnect();
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";       
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Sconn = new SqlConnection("Data Source=LAPTOP-VFRTLELB;Initial Catalog=QUANLI_TH_SPA;Integrated Security=True");
            SqlDataAdapter reader = new SqlDataAdapter("select password from NHANVIEN where email = '" + txt_email.Text+"'", Sconn);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            string email = txt_email.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký");
            }
            else
            {
                if (dt.Rows.Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + dt.Rows[0][0].ToString();
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa đủ đăng ký";
                }
            }
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
