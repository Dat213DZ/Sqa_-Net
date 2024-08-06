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
    public partial class SanPham : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_sanpham = new DataTable();
        string sql = "select * from SANPHAM";
        public SanPham()
        {
            InitializeComponent();
            dt_sanpham = db.getDatatable(sql, "SANPHAM").Tables["SANPHAM"];
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_sanpham.Columns[0];
            dt_sanpham.PrimaryKey = key;           
        }
        public void Load_cbnhanvien()
        {
            DataTable dt_nhanvien = db.getDatatable("select * from nhanvien","NHANVIEN").Tables["NHANVIEN"];
            cmb_idnv.DataSource = dt_nhanvien;
            cmb_idnv.DisplayMember = "Id";
            cmb_idnv.ValueMember = "Id";
        }
        public void load_datagridviewSanpham()
        {
            dataGVSP.DataSource = dt_sanpham;
        }
        public void load_datagridviewSanpham_TimKiem()
        {
            string sql1 = "select * from SANPHAM where TenSP like N'%"+textBox_Tim.Text+"%'";
            DataTable dt_sanpham1 = new DataTable();
            dt_sanpham1 = db.getDatatable(sql1, "SANPHAM").Tables["SANPHAM"];
            dataGVSP.DataSource = dt_sanpham1;
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            Load_cbnhanvien();
            load_datagridviewSanpham();
        }
        public void clear()
        {
            txt_id.Clear();
            txt_tensp.Clear();
            txt_sl.Clear();
            txt_gia.Clear();
            txt_mota.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {  
            DataRow row = dt_sanpham.NewRow();
            int count = 0;
            count = dataGVSP.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGVSP.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                row["Id"] = "SP0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 10 >= 10)
            {
                row["Id"] = "SP" + (chuoi2 + 1).ToString();
            }
            row["Tensp"] = txt_tensp.Text;
            row["Soluong"] = txt_sl.Text;
            row["Gia"] = txt_gia.Text;
            row["Mota"] = txt_mota.Text;
            row["Nv_Id"] = cmb_idnv.SelectedValue.ToString();
            dt_sanpham.Rows.Add(row);
            int kq = db.updateDatabase(dt_sanpham, sql);
            if (kq > 0)
                MessageBox.Show("thêm thành công");
            else
                MessageBox.Show("thêm ko thành công");
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            DataRow dr = dt_sanpham.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = db.updateDatabase(dt_sanpham, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_sanpham.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr["Tensp"] = txt_sl.Text;
                dr["Soluong"] = txt_sl.Text;
                dr["Gia"] = txt_gia.Text;
                dr["mota"] = txt_mota.Text;
                dr["Nv_Id"] = cmb_idnv.SelectedValue.ToString();
            }
            
            int kq = db.updateDatabase(dt_sanpham, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_tensp.Clear();
            txt_sl.Clear();
            txt_gia.Clear();
            txt_mota.Clear();
            txt_tensp.Focus();
        }

        private void dataGVSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = dataGVSP.CurrentRow.Index;
            txt_id.Text = dataGVSP.Rows[index].Cells[0].Value.ToString();
            txt_tensp.Text = dataGVSP.Rows[index].Cells[1].Value.ToString();
            txt_sl.Text = dataGVSP.Rows[index].Cells[2].Value.ToString();
            txt_gia.Text = dataGVSP.Rows[index].Cells[3].Value.ToString();
            txt_mota.Text = dataGVSP.Rows[index].Cells[4].Value.ToString();
            cmb_idnv.Text = dataGVSP.Rows[index].Cells[5].Value.ToString();
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            load_datagridviewSanpham_TimKiem();
        }

        private void button_HT_Click(object sender, EventArgs e)
        {
            load_datagridviewSanpham();
        }
    }
}
