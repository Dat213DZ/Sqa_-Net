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
    public partial class LieuTrinh : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_lieutrinh = new DataTable();
        string sql = "select * from LieuTrinh";
        public LieuTrinh()
        {
            InitializeComponent();
            dt_lieutrinh = db.getDatatable(sql, "LieuTrinh").Tables["LieuTrinh"];
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_lieutrinh.Columns[0];
            dt_lieutrinh.PrimaryKey = key;
        }
        public void Load_cbLieutrinh()
        {
            DataTable dt_nhanvien = db.getDatatable("select * from nhanvien", "NHANVIEN").Tables["NHANVIEN"];
            cmb_idnv.DataSource = dt_nhanvien;
            cmb_idnv.DisplayMember = "Id";
            cmb_idnv.ValueMember = "Id";
        }
        public void load_datagridviewLieutrinh()
        {
            dataGVLT.DataSource = dt_lieutrinh;
        }
        public void load_datagridviewLieutrinh_Tim()
        {
            DataTable dt_lieutrinh1 = new DataTable();
            string sql1 = "select * from LieuTrinh where TenLT like N'%"+textBox_Tim.Text+"%'";
            dt_lieutrinh1 = db.getDatatable(sql1, "LieuTrinh").Tables["LieuTrinh"];
            dataGVLT.DataSource = dt_lieutrinh1;
        }
        private void LieuTrinh_Load(object sender, EventArgs e)
        {
            Load_cbLieutrinh();
            load_datagridviewLieutrinh();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_tenlt.Clear();
            txt_gia.Clear();
            txt_motalt.Clear();
            txt_tenlt.Focus();
        }
        public void clear()
        {
            txt_id.Clear();
            txt_tenlt.Clear();
            txt_gia.Clear();
            txt_motalt.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = dt_lieutrinh.NewRow();
            int count = 0;
            count = dataGVLT.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGVLT.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                row["Id"] = "LT0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 10 >= 10)
            {
                row["Id"] = "LT" + (chuoi2 + 1).ToString();
            }
            row["Tenlt"] = txt_tenlt.Text;
            row["Gia"] = txt_gia.Text;
            row["Mota"] = txt_motalt.Text;
            row["Nv_Id"] = cmb_idnv.SelectedValue.ToString();
            dt_lieutrinh.Rows.Add(row);
            int kq = db.updateDatabase(dt_lieutrinh , sql);
            if (kq > 0)
                MessageBox.Show("thêm thành công");
            else
                MessageBox.Show("thêm ko thành công");
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_lieutrinh.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = db.updateDatabase(dt_lieutrinh, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_lieutrinh.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr["Tenlt"] = txt_tenlt.Text;
                dr["Gia"] = txt_gia.Text;
                dr["Mota"] = txt_motalt.Text;
                dr["Nv_Id"] = cmb_idnv.SelectedValue.ToString();
            }
            int kq = db.updateDatabase(dt_lieutrinh, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void dataGVLT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = dataGVLT.CurrentRow.Index;
            txt_id.Text = dataGVLT.Rows[index].Cells[0].Value.ToString();
            txt_tenlt.Text = dataGVLT.Rows[index].Cells[1].Value.ToString();
            txt_gia.Text = dataGVLT.Rows[index].Cells[2].Value.ToString();
            txt_motalt.Text = dataGVLT.Rows[index].Cells[3].Value.ToString();
            cmb_idnv.Text = dataGVLT.Rows[index].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_datagridviewLieutrinh_Tim();
        }

        private void button_ht_Click(object sender, EventArgs e)
        {
            load_datagridviewLieutrinh();
        }
    }
}
