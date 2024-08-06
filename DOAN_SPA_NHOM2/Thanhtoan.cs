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
    public partial class Thanhtoan : Form
    {
        string ID = "", PASSWORD = "", CHUCVU = "";
        DBConnect Sconn = new DBConnect();
        DataTable dt_HOADON = new DataTable();
        DataTable dt_CTHoaDon = new DataTable();
        public Thanhtoan()
        {
            InitializeComponent();

            this.ID = ID;
            this.PASSWORD = PASSWORD;
            this.CHUCVU = CHUCVU;

            string sql = "select * from HOADON";
            dt_HOADON = Sconn.getDatatable(sql, "HOADON").Tables["HOADON"];
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_HOADON.Columns[0];
            dt_HOADON.PrimaryKey = key;

            string sql1 = "select * from CT_HOADON ORDER BY HD_ID";
            dt_CTHoaDon = Sconn.getDatatable(sql1, "CT_HOADON").Tables["CT_HOADON"];
            DataColumn[] key1 = new DataColumn[1];
            key1[0] = dt_CTHoaDon.Columns[0];
            dt_CTHoaDon.PrimaryKey = key1;
        }
        public void LoadDVcthd()
        {
            DVCTHD.DataSource = dt_CTHoaDon;
        }
        public void loadCB_IDHoaDon()
        {
            DataTable dt_IDHoaDon = Sconn.getDatatable("select * from hoadon", "hoadon").Tables["HoaDon"];
            CB_HoaDonID.DataSource = dt_IDHoaDon;
            CB_HoaDonID.DisplayMember = "Id";
            CB_HoaDonID.ValueMember = "Id";

        }
        public void loadCB_IDSanPham()
        {
            DataTable dt_ID = Sconn.getDatatable("select * from sanpham", "sanpham").Tables["sanpham"];
            CB_IDSP.DataSource = dt_ID;
            CB_IDSP.DisplayMember = "TENSP";
            CB_IDSP.ValueMember = "Id";
        }
        public void loadCB_IDDichVu()
        {
            DataTable dt_ID = Sconn.getDatatable("select * from dichvu", "dichvu").Tables["dichvu"];
            cb_IDDV.DataSource = dt_ID;
            cb_IDDV.DisplayMember = "TENDV";
            cb_IDDV.ValueMember = "Id";
        }
        public void loadCB_IDGoiDichVu()
        {
            DataTable dt_ID = Sconn.getDatatable("select * from goidv", "goidv").Tables["goidv"];
            CB_IDGDV.DataSource = dt_ID;
            CB_IDGDV.DisplayMember = "TENGOIDV";
            CB_IDGDV.ValueMember = "Id";
        }
        public void loadCB_IDLieuTrinh()
        {
            DataTable dt_ID = Sconn.getDatatable("select * from LIEUTRINH", "LIEUTRINH").Tables["LIEUTRINH"];
            CB_IDLT.DataSource = dt_ID;
            CB_IDLT.DisplayMember = "TENLT";
            CB_IDLT.ValueMember = "Id";
        }
        public void LoadDataGrid()
        {
            DV_HOADON.DataSource = dt_HOADON;
        }
        public void Load_cbnhanvien()
        {
            DataTable dt_nhanvien = Sconn.getDatatable("select * from nhanvien", "NHANVIEN").Tables["NHANVIEN"];
            cmb_idnv.DataSource = dt_nhanvien;
            cmb_idnv.DisplayMember = "Id";
            cmb_idnv.ValueMember = "Id";
        }
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            txt_ngaytao.Text = today.ToString("dd/MM/yyyy");
            LoadDataGrid();
            Load_cbnhanvien();
            LoadDVcthd();
            loadCB_IDDichVu();
            loadCB_IDGoiDichVu();
            loadCB_IDHoaDon();
            loadCB_IDLieuTrinh();
            loadCB_IDSanPham();
        }

        private void DV_HOADON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idhd.Enabled = true;
            int index = DV_HOADON.CurrentRow.Index;
            txt_idhd.Text = DV_HOADON.Rows[index].Cells[0].Value.ToString();
            cmb_idnv.Text = DV_HOADON.Rows[index].Cells[1].Value.ToString();
            txt_ngaytao.Text = DV_HOADON.Rows[index].Cells[2].Value.ToString();

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_ngaytao.Clear();
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in dt_HOADON.Rows)
            {
                string tmp1 = dr["id"].ToString();
                if (int.Parse(tmp1.Substring(3)) == temp)
                {
                    return true;
                }
            }
            return false;
        }
        public bool KiemTra1(int temp)
        {
            foreach (DataRow dr in dt_CTHoaDon.Rows)
            {
                string tmp1 = dr["id"].ToString();
                if (int.Parse(tmp1.Substring(4)) == temp)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = dt_HOADON.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    if(i<10)
                    {
                        row["id"] = "HD" + "0" + i.ToString();
                        break;
                    }
                    else
                    {
                        row["id"] = "HD" + i.ToString();
                        break;
                    }
                }
            }
            row["NV_ID"] = cmb_idnv.Text;
            row["ngaytao"] = txt_ngaytao.Text;
            dt_HOADON.Rows.Add(row);
            string sql = "select * from HOADON";
            int kq = Sconn.updateDatabase(dt_HOADON, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_idhd.Clear();
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
                string sql = "select * from HOADON";
            DataRow dr = dt_HOADON.Rows.Find(txt_idhd.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(dt_HOADON, sql);
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
            string sql = "select * from HOADON";
            DataRow dr = dt_HOADON.Rows.Find(txt_idhd.Text);
            if (dr != null)
            {
                dr["NV_ID"] = cmb_idnv.Text;
                dr["ngaytao"] = txt_ngaytao.Text;
            }
            int kq = Sconn.updateDatabase(dt_HOADON, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        public string TimID(string tentruyenvao, string tenbang, string tencot) //(Chăm sóc da mặt, dichvu, tendv)
        {
            DataTable dt_timid = new DataTable();
            string sql = "select * from " + tenbang;
            dt_timid = Sconn.getDatatable(sql, tenbang).Tables[tenbang];
            foreach (DataRow dr in dt_timid.Rows)
            {
                string tmp1 = dr[tencot].ToString();//tencot: tendv
                if (tmp1 == tentruyenvao)//int.Parse(tmp1.Substring(4)) == temp
                {
                    string id;
                    id = dr["id"].ToString();
                    return id;
                }
            }
            return "NO";
        }

        public int TimGiaTien(string tentruyenvao, string tenbang, string tencot) //(Chăm sóc da mặt, dichvu, tendv)
        {
            DataTable dt_timid = new DataTable();
            string sql = "select * from " + tenbang;
            dt_timid = Sconn.getDatatable(sql, tenbang).Tables[tenbang];
            foreach (DataRow dr in dt_timid.Rows)
            {
                string tmp1 = dr[tencot].ToString();//tencot: tendv
                if (tmp1 == tentruyenvao)//int.Parse(tmp1.Substring(4)) == temp
                {
                    int id;
                    id = int.Parse(dr["GIA"].ToString());
                    return id;
                }
            }
            return -1;
        }
        public int TinhTongTien(string id) //(Chăm sóc da mặt, dichvu, tendv)
        {
            int sum = 0;
            DataTable dt_timid = new DataTable();
            string sql = "select * from  CT_HOADON";
            dt_timid = Sconn.getDatatable(sql, "CT_HOADON").Tables["CT_HOADON"];
            foreach (DataRow dr in dt_timid.Rows)
            {
                int temp2 = int.Parse(dr["Tongtien"].ToString());
                if (dr["id"] == id)//int.Parse(tmp1.Substring(4)) == temp
                {
                    sum = sum + temp2;
                }
                else
                {
                    sum = sum + 0;
                }
            }
            return sum;
        }
        private void button_them1_Click(object sender, EventArgs e)
        {
            DataRow row = dt_CTHoaDon.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra1(i) == false)
                {
                    if (i < 10)
                    {
                        row["id"] = "CTHD" + "0" + i.ToString();
                        break;
                    }
                    else
                    {
                        row["id"] = "CTHD" + i.ToString();
                        break;
                    }
                }
            }
            row["HD_ID"] = CB_HoaDonID.Text;
            row["SP_ID"] = TimID(CB_IDSP.Text,"SANPHAM", "TENSP");
            row["soluong"] =  int.Parse(textBox_SlSP.Text) +  int.Parse(textBox_SLDV.Text) +  int.Parse(textBox_SLGDV.Text) +  int.Parse(textBox_SLLT.Text); ;
            row["DV_ID"] = TimID(cb_IDDV.Text,"DICHVU","TENDV");
            row["GOIDV_ID"] = TimID(CB_IDGDV.Text,"GOIDV","TENGOIDV");
            row["LT_ID"] = TimID(CB_IDLT.Text,"LIEUTRINH","TENLT");
            row["tongtien"] = (TimGiaTien(CB_IDSP.Text, "SANPHAM", "TENSP") * int.Parse(textBox_SlSP.Text) + TimGiaTien(cb_IDDV.Text, "DICHVU", "TENDV") * int.Parse(textBox_SLDV.Text) + TimGiaTien(CB_IDGDV.Text, "GOIDV", "TENGOIDV") * int.Parse(textBox_SLGDV.Text) + TimGiaTien(CB_IDLT.Text, "LIEUTRINH", "TENLT") * int.Parse(textBox_SLLT.Text)) * 1;
            dt_CTHoaDon.Rows.Add(row);
            string sql = "select * from CT_HOADON";
            int kq = Sconn.updateDatabase(dt_CTHoaDon, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void button_xoa1_Click(object sender, EventArgs e)
        {
            string sql = "select * from CT_HOADON";
            DataRow dr = dt_CTHoaDon.Rows.Find(txt_idct.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(dt_CTHoaDon, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void button_sua1_Click(object sender, EventArgs e)
        {
            string sql = "select * from CT_HOADON";
            DataRow dr = dt_CTHoaDon.Rows.Find(txt_idct.Text);
            if (dr != null)
            {
                dr["HD_ID"] = CB_HoaDonID.Text;
                dr["SP_ID"] = CB_IDSP.Text;
                dr["soluong"] = tb_SoLuong.Text;
                dr["DV_ID"] = cb_IDDV.Text;
                dr["GOIDV_ID"] = CB_IDGDV.Text;
                dr["LT_ID"] = CB_IDLT.Text;
                dr["tongtien"] = tb_TongTien.Text;
            }
            int kq = Sconn.updateDatabase(dt_CTHoaDon, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void DVCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idct.Enabled = true;
            int index = DVCTHD.CurrentRow.Index;
            txt_idct.Text = DVCTHD.Rows[index].Cells[0].Value.ToString();
            CB_HoaDonID.Text = DVCTHD.Rows[index].Cells[1].Value.ToString();
            CB_IDSP.Text = DVCTHD.Rows[index].Cells[2].Value.ToString();
            tb_SoLuong.Text = DVCTHD.Rows[index].Cells[3].Value.ToString();
            cb_IDDV.Text = DVCTHD.Rows[index].Cells[4].Value.ToString();
            CB_IDGDV.Text = DVCTHD.Rows[index].Cells[5].Value.ToString();
            CB_IDLT.Text = DVCTHD.Rows[index].Cells[6].Value.ToString();
            tb_TongTien.Text = DVCTHD.Rows[index].Cells[7].Value.ToString();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadCB_IDHoaDon();
        }

        private void button_RS_Click(object sender, EventArgs e)
        {
            string sql = "select * from HOADON";
            dt_HOADON = Sconn.getDatatable(sql, "HOADON").Tables["HOADON"];
            LoadDataGrid();
        }

    }
}
