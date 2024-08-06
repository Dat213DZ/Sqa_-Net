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
    public partial class Goidichvu : Form
    {
        DBConnect Sconn = new DBConnect();
        DataTable DT_GoiDichVu = new DataTable();
        public Goidichvu()
        {
            InitializeComponent();
            string sql = "select * from GOIDV";
            DT_GoiDichVu = Sconn.getDatatable(sql, "GOIDV").Tables["GOIDV"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_GoiDichVu.Columns[0];
            DT_GoiDichVu.PrimaryKey = key;
        }
        public void Load_GV_GDICHVU()
        {

            dataGDV.DataSource = DT_GoiDichVu;
        }
        public void Load_Tim()
        {
            DataTable DT_GoiDichVu1 = new DataTable();
            string sql1 = "select * from GOIDV where TenGOIDV like N'%" + textBox_tim.Text + "%'";
            DT_GoiDichVu1 = Sconn.getDatatable(sql1, "GOIDV").Tables["GOIDV"];
            dataGDV.DataSource = DT_GoiDichVu1;
        }
        public void Load_cbnhanvien()
        {
            DataTable dt_nhanvien = Sconn.getDatatable("select * from nhanvien", "NHANVIEN").Tables["NHANVIEN"];
            cmb_idnv.DataSource = dt_nhanvien;
            cmb_idnv.DisplayMember = "Id";
            cmb_idnv.ValueMember = "Id";
        }        
        private void Goidichvu_Load(object sender, EventArgs e)
        {
            Load_GV_GDICHVU();
            Load_cbnhanvien();
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_GoiDichVu.Rows)
            {
                string tmp1 = dr["id"].ToString();
                if (int.Parse(tmp1.Substring(3)) == temp)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_tengdv.Clear();
            txt_mota.Clear();
            txt_gia.Clear();
            txt_id.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = DT_GoiDichVu.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["id"] = "GDV" + i.ToString();
                    break;
                }
            }
            row["tengoidv"] = txt_tengdv.Text;
            row["mota"] = txt_mota.Text;
            row["gia"] = txt_gia.Text;
            row["nv_id"] = cmb_idnv.Text;
            DT_GoiDichVu.Rows.Add(row);
            string sql = "select * from GOIDV";
            int kq = Sconn.updateDatabase(DT_GoiDichVu, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_id.Clear();
                txt_gia.Clear();
                txt_mota.Clear();
                txt_tengdv.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from GOIDV";
            DataRow dr = DT_GoiDichVu.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(DT_GoiDichVu, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from GOIDV";
            DataRow dr = DT_GoiDichVu.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr["tengoidv"] = txt_tengdv.Text;
                dr["mota"] = txt_mota.Text;
                dr["gia"] = txt_gia.Text;
                dr["nv_id"] = cmb_idnv.Text;
            }
            int kq = Sconn.updateDatabase(DT_GoiDichVu, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void dataGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = dataGDV.CurrentRow.Index;
            txt_id.Text = dataGDV.Rows[index].Cells[0].Value.ToString();
            txt_tengdv.Text = dataGDV.Rows[index].Cells[1].Value.ToString();
            txt_gia.Text = dataGDV.Rows[index].Cells[2].Value.ToString();
            txt_mota.Text = dataGDV.Rows[index].Cells[3].Value.ToString();
            cmb_idnv.Text = dataGDV.Rows[index].Cells[4].Value.ToString();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            Load_Tim();
        }

        private void button_HT_Click(object sender, EventArgs e)
        {
            Load_GV_GDICHVU();
        }
    }
}
