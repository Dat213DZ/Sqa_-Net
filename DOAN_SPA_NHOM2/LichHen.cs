using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
    public partial class LichHen : Form
    {
        DBConnect Sconn = new DBConnect();
        DataTable DT_LICHHEN = new DataTable();
        public LichHen()
        {
            InitializeComponent();
            string sql = "select * from LICHHEN";
            DT_LICHHEN = Sconn.getDatatable(sql, "LICHHEN").Tables["LICHHEN"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_LICHHEN.Columns[0];
            DT_LICHHEN.PrimaryKey = key;
        }
        public void Load_GV_LICHHEN()
        {
            datalh.DataSource = DT_LICHHEN;
        }
        public void Load_GV_LICHHEN_Tim()
        {
            string temp = maskedTextBox_tim.Text;
            DataTable DT_LICHHEN1 = new DataTable();
            string sql1 = "SET DATEFORMAT DMY select * from LICHHEN where ngaydat = '" + temp + "'";
            DT_LICHHEN1 = Sconn.getDatatable(sql1, "LICHHEN").Tables["LICHHEN"];
            datalh.DataSource = DT_LICHHEN1;
        }
        public void Load_cbnhanvien()
        {
            DataTable dt_khachhang = Sconn.getDatatable("select * from khachhang", "KHACHHANG").Tables["KHACHHANG"];
            cmb_idkh.DataSource = dt_khachhang;
            cmb_idkh.DisplayMember = "Id";
            cmb_idkh.ValueMember = "Id";
        }

        private void LichHen_Load(object sender, EventArgs e)
        {
            Load_GV_LICHHEN();
            Load_cbnhanvien();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_ngaydat.Clear();
            txt_ngayden.Clear();
            
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_LICHHEN.Rows)
            {
                string tmp1 = dr["id"].ToString();
                if (int.Parse(tmp1.Substring(2)) == temp)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = DT_LICHHEN.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["id"] = "LH0" + i.ToString();
                    break;
                }
            }
            row["kh_id"] = cmb_idkh.Text;
            row["NgayDat"] = txt_ngaydat.Text;
            row["NgayDen"] = txt_ngaydat.Text;
            DT_LICHHEN.Rows.Add(row);
            string sql = "select * from LICHHEN";
            int kq = Sconn.updateDatabase(DT_LICHHEN, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_id.Clear();
                txt_ngaydat.Clear();
                txt_ngayden.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from LICHHEN";
            DataRow dr = DT_LICHHEN.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(DT_LICHHEN, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from LICHHEN";
            DataRow dr = DT_LICHHEN.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr["kh_id"] = cmb_idkh.Text;
                dr["NgayDat"] = txt_ngaydat.Text;
                dr["NgayDen"] = txt_ngayden.Text;
            }
            int kq = Sconn.updateDatabase(DT_LICHHEN, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void DV_DSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = datalh.CurrentRow.Index;
            txt_id.Text = datalh.Rows[index].Cells[0].Value.ToString();
            cmb_idkh.Text = datalh.Rows[index].Cells[1].Value.ToString();
            txt_ngaydat.Text = datalh.Rows[index].Cells[2].Value.ToString();
            txt_ngayden.Text = datalh.Rows[index].Cells[3].Value.ToString();
        }


        private void button_Ht_Click(object sender, EventArgs e)
        {
            Load_GV_LICHHEN();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            Load_GV_LICHHEN_Tim();
        }

    }
}
