
namespace login2
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVSP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.cmb_idnv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.lb_SP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.textBox_Tim = new System.Windows.Forms.TextBox();
            this.button_Tim = new System.Windows.Forms.Button();
            this.button_HT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVSP);
            this.groupBox1.Location = new System.Drawing.Point(284, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dataGVSP
            // 
            this.dataGVSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSP.Location = new System.Drawing.Point(12, 19);
            this.dataGVSP.Name = "dataGVSP";
            this.dataGVSP.Size = new System.Drawing.Size(482, 313);
            this.dataGVSP.TabIndex = 0;
            this.dataGVSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVSP_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mota);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.txt_sl);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.cmb_idnv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(117, 176);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(134, 20);
            this.txt_mota.TabIndex = 2;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(117, 138);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(134, 20);
            this.txt_gia.TabIndex = 2;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(117, 100);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(134, 20);
            this.txt_sl.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(117, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 2;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(117, 62);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(134, 20);
            this.txt_tensp.TabIndex = 2;
            // 
            // cmb_idnv
            // 
            this.cmb_idnv.FormattingEnabled = true;
            this.cmb_idnv.Location = new System.Drawing.Point(117, 214);
            this.cmb_idnv.Name = "cmb_idnv";
            this.cmb_idnv.Size = new System.Drawing.Size(134, 21);
            this.cmb_idnv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô Tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(16, 24);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Lượng";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(197, 322);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 0;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // lb_SP
            // 
            this.lb_SP.AutoSize = true;
            this.lb_SP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SP.Location = new System.Drawing.Point(264, 9);
            this.lb_SP.Name = "lb_SP";
            this.lb_SP.Size = new System.Drawing.Size(267, 31);
            this.lb_SP.TabIndex = 0;
            this.lb_SP.Text = "Danh Sách Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(185, 17);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(96, 17);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(7, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // textBox_Tim
            // 
            this.textBox_Tim.Location = new System.Drawing.Point(12, 20);
            this.textBox_Tim.Name = "textBox_Tim";
            this.textBox_Tim.Size = new System.Drawing.Size(152, 20);
            this.textBox_Tim.TabIndex = 3;
            // 
            // button_Tim
            // 
            this.button_Tim.Location = new System.Drawing.Point(170, 18);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 23);
            this.button_Tim.TabIndex = 4;
            this.button_Tim.Text = "Tìm";
            this.button_Tim.UseVisualStyleBackColor = true;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // button_HT
            // 
            this.button_HT.Location = new System.Drawing.Point(611, 32);
            this.button_HT.Name = "button_HT";
            this.button_HT.Size = new System.Drawing.Size(167, 23);
            this.button_HT.TabIndex = 4;
            this.button_HT.Text = "Hiển thị tất cả sản phẩm";
            this.button_HT.UseVisualStyleBackColor = true;
            this.button_HT.Click += new System.EventHandler(this.button_HT_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_HT);
            this.Controls.Add(this.button_Tim);
            this.Controls.Add(this.textBox_Tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_SP);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.ComboBox cmb_idnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_SP;
        private System.Windows.Forms.DataGridView dataGVSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox textBox_Tim;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.Button button_HT;
    }
}