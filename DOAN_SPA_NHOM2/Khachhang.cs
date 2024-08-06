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
    public partial class Khachhang : Form
    {
        string ID = "", PASSWORD = "", CHUCVU = "";
        DBConnect Sconn = new DBConnect();
        DataTable DT_KH = new DataTable();
        public Khachhang(string ID, string PASSWORD, string CHUCVU)
        {
            InitializeComponent();

            this.ID = ID;
            this.PASSWORD = PASSWORD;
            this.CHUCVU = CHUCVU;

            string sql = "select * from KHACHHANG";
            DT_KH = Sconn.getDatatable(sql,"KHACHHANG").Tables["KHACHHANG"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_KH.Columns[0];
            DT_KH.PrimaryKey = key;
        }
        //public Khachhang(string ID, string PASSWORD, string CHUCVU)
        //{
        //    InitializeComponent();
        //    this.ID = ID;
        //    this.PASSWORD = PASSWORD;
        //    this.CHUCVU = CHUCVU;
        //}
        public void Load_dataGVKH()
        {
            dataGVKH.DataSource = DT_KH;
        }
        public void Load_dataGVKH_Tim()
        {
            DataTable DT_KH1 = new DataTable();
            string sql1 = "select * from KHACHHANG where TenKH like N'%"+textBox_tim.Text+"%'";
            DT_KH1 = Sconn.getDatatable(sql1, "KHACHHANG").Tables["KHACHHANG"];
            dataGVKH.DataSource = DT_KH1;
        }
        public void Load_cb()
        {
            DataTable dt_nhanvien = Sconn.getDatatable("select * from NHANVIEN", "NHANVIEN").Tables["NHANVIEN"];
            cmb_idnv.DataSource = dt_nhanvien;
            cmb_idnv.DisplayMember = "ID";
            cmb_idnv.ValueMember = "ID";
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            Load_cb();
            Load_dataGVKH();
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_KH.Rows)
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
            string temp1 = "";
            if (rab_Nam.Checked)
                temp1 = "Nam";
            else if (rab_nu.Checked)
                temp1 = "Nữ";
            DataRow row = DT_KH.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["id"] = "KH" + i.ToString();
                    break;
                }
            }
            row["Tenkh"] = txt_tenkh.Text;
            row["sdt"] = txt_sdt.Text;
            row["email"] = txt_email.Text;
            row["diachi"] = txt_diachi.Text;
            row["sinhnam"] = txt_namsinh.Text;
            row["gioitinh"] = temp1;
            row["nv_id"] = cmb_idnv.SelectedValue.ToString();
            DT_KH.Rows.Add(row);
            string sql = "select * from khachhang";
            int kq = Sconn.updateDatabase(DT_KH, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_diachi.Clear();
                txt_email.Clear();
                txt_tenkh.Clear();
                txt_namsinh.Clear();
                txt_sdt.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (CHUCVU == "Quản lí")
            {
                string sql = "select * from khachhang";
                DataRow dr = DT_KH.Rows.Find(txt_id.Text);
                if (dr != null)
                {
                    dr.Delete();
                }
                int kq = Sconn.updateDatabase(DT_KH, sql);
                if (kq > 0)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Bạn không được cấp quyền này");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string temp1 = "";
            if (rab_Nam.Checked)
                temp1 = "Nam";
            else if (rab_nu.Checked)
                temp1 = "Nữ";
            string sql = "select * from khachhang";
            DataRow dr = DT_KH.Rows.Find(txt_id.Text);
            if (dr != null)
            {
                dr["Tenkh"] = txt_tenkh.Text;
                dr["sdt"] = txt_sdt.Text;
                dr["email"] = txt_email.Text;
                dr["diachi"] = txt_diachi.Text;
                dr["sinhnam"] = txt_namsinh.Text;
                dr["gioitinh"] = temp1;
                dr["nv_id"] = cmb_idnv.SelectedValue.ToString();
            }
            int kq = Sconn.updateDatabase(DT_KH, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_diachi.Clear();
            txt_email.Clear();
            txt_tenkh.Clear();
            txt_namsinh.Clear();
            txt_sdt.Clear();
            rab_Nam.Checked = false;
            rab_nu.Checked = false;
        }

        private void dataGVKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = dataGVKH.CurrentRow.Index;
            txt_id.Text = dataGVKH.Rows[index].Cells[0].Value.ToString();
            txt_tenkh.Text = dataGVKH.Rows[index].Cells[1].Value.ToString();
            txt_sdt.Text = dataGVKH.Rows[index].Cells[2].Value.ToString();
            txt_email.Text = dataGVKH.Rows[index].Cells[3].Value.ToString();
            txt_diachi.Text = dataGVKH.Rows[index].Cells[4].Value.ToString();
            txt_namsinh.Text = dataGVKH.Rows[index].Cells[5].Value.ToString();
            //cb_gt.Text = dataGVKH.Rows[index].Cells[6].Value.ToString();
            if (dataGVKH.Rows[index].Cells[6].Value.ToString() == "Nam")
                rab_Nam.Checked = true;
            else if (dataGVKH.Rows[index].Cells[6].Value.ToString() == "Nữ")
                rab_nu.Checked = true;
            cmb_idnv.Text = dataGVKH.Rows[index].Cells[7].Value.ToString();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            Load_dataGVKH_Tim();
        }

        private void button_ht_Click(object sender, EventArgs e)
        {
            Load_dataGVKH();
        }
    }
}
