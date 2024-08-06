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
    public partial class Dichvu : Form
    {
        DBConnect Sconn = new DBConnect();// kết nối đến class DBConnect để kết nối csdl
        DataTable DT_DichVu = new DataTable();  // tạo bảng có tên là DT_DichVu      
        public Dichvu()
        {
            InitializeComponent();
            string sql = "select * from DICHVU";
            DT_DichVu = Sconn.getDatatable(sql, "DICHVU").Tables["DICHVU"]; //đọc bảng DichVu đưa vào bảng DT_DichVu được tạo ở trên
            DataColumn[] key = new DataColumn[1];//3 dòng tiếp theo là gán primary cho cột đầu tiên trong bảng
            key[0] = DT_DichVu.Columns[0];
            DT_DichVu.PrimaryKey = key;
        }
        public void Load_GV_DICHVU()//load DatagridView 
        {

            dataGVDV.DataSource = DT_DichVu;// đưa các cột hàng của bảng lên DataGrid để hiện danh sách các dịch vụ
        }
        public void Load_cbnhanvien()//Load combobox nhân viên
        {
            DataTable dt_nhanvien = Sconn.getDatatable("select * from nhanvien", "NHANVIEN").Tables["NHANVIEN"];//đọc dữ liệu ở bản nhân viên
            cmb_idnv.DataSource = dt_nhanvien;//đưa dữ liệu từ bản lên
            cmb_idnv.DisplayMember = "Id";//hiển thị cột id lên
            cmb_idnv.ValueMember = "Id";//giá trị thực hiện cũng là id
        }
        public void Load_Tim()//hàm này dùng để tìm kiếm
        {
            DataTable DT_DichVu1 = new DataTable();//tạo bảng có tên DT_DICHVU1
            string sql1 = "select * from DICHVU where TenDV like N'%" + textBox_Tim.Text + "%'"; // đây là biến string dùng để truy vấn
            DT_DichVu1 = Sconn.getDatatable(sql1, "DICHVU").Tables["DICHVU"];// đưa biến string sql1 ở trên vào để đưa ra bảng theo câu truy vấn
            dataGVDV.DataSource = DT_DichVu1;// Đưa dữ liệu đã đọc vào bảng vào cho dataGrid
        }
        private void Dichvu_Load(object sender, EventArgs e)// form load dùng để load datagrid và combobox nhân viên khi mở form lên
        {
            Load_cbnhanvien();
            Load_GV_DICHVU();
        }
        public bool KiemTra(int temp)// hàm này kiểm tra khóa trùng trả về giá trị true nếu trùng và ngược lại
        {
            foreach (DataRow dr in DT_DichVu.Rows)
            {
                string tmp1 = dr["id"].ToString();
                if (int.Parse(tmp1.Substring(2)) == temp)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)//hàm thêm dữ dư liệu vào bảng dựa vào các text box, combobox và nút
        {
            DataRow row = DT_DichVu.NewRow();// đọc từng dòng 
            for (int i = 1; i <= 1000; i++)// vòng for lặp từng dòng để thêm dữ liệu vào
            {
                if (KiemTra(i) == false)// thực hiện kiểm tra để thêm id tự động tăng
                {
                    row["id"] = "DV" + i.ToString();
                    break;
                }
            }
            row["tendv"] = txt_tendv.Text;
            row["mota"] = txt_mota.Text;
            row["gia"] = txt_gia.Text;
            row["nv_id"] = cmb_idnv.Text;
            DT_DichVu.Rows.Add(row);// add các dư liệu trên vào dòng
            string sql = "select * from DICHVU";
            int kq = Sconn.updateDatabase(DT_DichVu, sql); //thực hiện update vào và đưa ra giá trị để kiểm tra add được hay chưa
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_id.Clear();
                txt_gia.Clear();
                txt_mota.Clear();
                txt_tendv.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)//xóa dữ liệu trên bảng
        {
            string sql = "select * from DICHVU";
            DataRow dr = DT_DichVu.Rows.Find(txt_id.Text);//tìm dòng đó theo mã đó xem có tồn tại không
            if (dr != null) // nếu mà dòng đó ko null thì xóa
            {
                dr.Delete();//xóa
            }
            int kq = Sconn.updateDatabase(DT_DichVu, sql);// tiến hành update lại dữ liệu và đưa ra giá trị xem có lỗi ko
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from DICHVU";
            DataRow dr = DT_DichVu.Rows.Find(txt_id.Text); // tương tự như xóa thì đây cũng tìm dòng đó theo mã đó xem có tồn tại không
            if (dr != null)// nếu mà dòng đó ko null thì sửa
            {
                dr["tendv"] = txt_tendv.Text;
                dr["mota"] = txt_mota.Text;
                dr["gia"] = txt_gia.Text;
                dr["nv_id"] = cmb_idnv.Text;// các dòng này sửa các dữ liệu
            }
            int kq = Sconn.updateDatabase(DT_DichVu, sql);//tiến hành update lại dữ liệu và đưa ra giá trị xem có lỗi ko
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void dataGVDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = true;
            int index = dataGVDV.CurrentRow.Index;
            txt_id.Text = dataGVDV.Rows[index].Cells[0].Value.ToString();
            txt_tendv.Text = dataGVDV.Rows[index].Cells[1].Value.ToString();
            txt_mota.Text = dataGVDV.Rows[index].Cells[2].Value.ToString();
            txt_gia.Text = dataGVDV.Rows[index].Cells[3].Value.ToString();
            cmb_idnv.Text = dataGVDV.Rows[index].Cells[4].Value.ToString();// đây là khối lệnh nhằm thực hiện gán các dòng chọn trong Datagrid đưa lên cho các textbox
        }

        private void txt_lamoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_tendv.Clear();
            txt_gia.Clear();
            txt_mota.Clear();// đây là nút làm mới nên chỉ là clear 
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            Load_Tim(); // đây là nút tìm nhằm load lại datagrid dựa vào điều kiện trong hàm Load_Tim
        }

        private void button_HT_Click(object sender, EventArgs e)
        {
            Load_GV_DICHVU(); //nút này hiện lại tất cả các dữ liệu đọc lên datagrid
        }
    }
}
