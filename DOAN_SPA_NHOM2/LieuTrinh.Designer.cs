
namespace login2
{
    partial class LieuTrinh
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grb_nhaplt = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_motalt = new System.Windows.Forms.TextBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_tenlt = new System.Windows.Forms.TextBox();
            this.cmb_idnv = new System.Windows.Forms.ComboBox();
            this.lb_idnv = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_tenlt = new System.Windows.Forms.Label();
            this.grb_lt = new System.Windows.Forms.GroupBox();
            this.dataGVLT = new System.Windows.Forms.DataGridView();
            this.lb_lt = new System.Windows.Forms.Label();
            this.textBox_Tim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ht = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.grb_nhaplt.SuspendLayout();
            this.grb_lt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.btn_xoa);
            this.groupBox4.Controls.Add(this.btn_them);
            this.groupBox4.Location = new System.Drawing.Point(12, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 49);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tác vụ";
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
            // grb_nhaplt
            // 
            this.grb_nhaplt.Controls.Add(this.txt_id);
            this.grb_nhaplt.Controls.Add(this.lb_id);
            this.grb_nhaplt.Controls.Add(this.txt_gia);
            this.grb_nhaplt.Controls.Add(this.txt_motalt);
            this.grb_nhaplt.Controls.Add(this.btn_lammoi);
            this.grb_nhaplt.Controls.Add(this.txt_tenlt);
            this.grb_nhaplt.Controls.Add(this.cmb_idnv);
            this.grb_nhaplt.Controls.Add(this.lb_idnv);
            this.grb_nhaplt.Controls.Add(this.lb_gia);
            this.grb_nhaplt.Controls.Add(this.lb_mota);
            this.grb_nhaplt.Controls.Add(this.lb_tenlt);
            this.grb_nhaplt.Location = new System.Drawing.Point(12, 83);
            this.grb_nhaplt.Name = "grb_nhaplt";
            this.grb_nhaplt.Size = new System.Drawing.Size(266, 262);
            this.grb_nhaplt.TabIndex = 13;
            this.grb_nhaplt.TabStop = false;
            this.grb_nhaplt.Text = "Thông tin liệu trình";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(121, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 17;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(20, 28);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 16;
            this.lb_id.Text = "Id";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(121, 148);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(134, 20);
            this.txt_gia.TabIndex = 2;
            // 
            // txt_motalt
            // 
            this.txt_motalt.Location = new System.Drawing.Point(121, 108);
            this.txt_motalt.Name = "txt_motalt";
            this.txt_motalt.Size = new System.Drawing.Size(134, 20);
            this.txt_motalt.TabIndex = 2;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(180, 225);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_tenlt
            // 
            this.txt_tenlt.Location = new System.Drawing.Point(121, 68);
            this.txt_tenlt.Name = "txt_tenlt";
            this.txt_tenlt.Size = new System.Drawing.Size(134, 20);
            this.txt_tenlt.TabIndex = 2;
            // 
            // cmb_idnv
            // 
            this.cmb_idnv.FormattingEnabled = true;
            this.cmb_idnv.Location = new System.Drawing.Point(121, 188);
            this.cmb_idnv.Name = "cmb_idnv";
            this.cmb_idnv.Size = new System.Drawing.Size(134, 21);
            this.cmb_idnv.TabIndex = 1;
            // 
            // lb_idnv
            // 
            this.lb_idnv.AutoSize = true;
            this.lb_idnv.Location = new System.Drawing.Point(20, 196);
            this.lb_idnv.Name = "lb_idnv";
            this.lb_idnv.Size = new System.Drawing.Size(71, 13);
            this.lb_idnv.TabIndex = 0;
            this.lb_idnv.Text = "ID Nhân Viên";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(20, 154);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(23, 13);
            this.lb_gia.TabIndex = 0;
            this.lb_gia.Text = "Giá";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Location = new System.Drawing.Point(20, 112);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(38, 13);
            this.lb_mota.TabIndex = 0;
            this.lb_mota.Text = "Mô Tả";
            // 
            // lb_tenlt
            // 
            this.lb_tenlt.AutoSize = true;
            this.lb_tenlt.Location = new System.Drawing.Point(20, 70);
            this.lb_tenlt.Name = "lb_tenlt";
            this.lb_tenlt.Size = new System.Drawing.Size(76, 13);
            this.lb_tenlt.TabIndex = 0;
            this.lb_tenlt.Text = "Tên Liệu Trình";
            // 
            // grb_lt
            // 
            this.grb_lt.Controls.Add(this.dataGVLT);
            this.grb_lt.Location = new System.Drawing.Point(284, 81);
            this.grb_lt.Name = "grb_lt";
            this.grb_lt.Size = new System.Drawing.Size(504, 339);
            this.grb_lt.TabIndex = 14;
            this.grb_lt.TabStop = false;
            this.grb_lt.Text = "Liệu trình";
            // 
            // dataGVLT
            // 
            this.dataGVLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVLT.Location = new System.Drawing.Point(14, 19);
            this.dataGVLT.Name = "dataGVLT";
            this.dataGVLT.Size = new System.Drawing.Size(478, 313);
            this.dataGVLT.TabIndex = 0;
            this.dataGVLT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVLT_CellContentClick);
            // 
            // lb_lt
            // 
            this.lb_lt.AutoSize = true;
            this.lb_lt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lt.Location = new System.Drawing.Point(256, 29);
            this.lb_lt.Name = "lb_lt";
            this.lb_lt.Size = new System.Drawing.Size(274, 31);
            this.lb_lt.TabIndex = 12;
            this.lb_lt.Text = "Danh Sách Liệu Trình";
            // 
            // textBox_Tim
            // 
            this.textBox_Tim.Location = new System.Drawing.Point(12, 29);
            this.textBox_Tim.Name = "textBox_Tim";
            this.textBox_Tim.Size = new System.Drawing.Size(157, 20);
            this.textBox_Tim.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ht
            // 
            this.button_ht.Location = new System.Drawing.Point(656, 61);
            this.button_ht.Name = "button_ht";
            this.button_ht.Size = new System.Drawing.Size(120, 23);
            this.button_ht.TabIndex = 17;
            this.button_ht.Text = "Hiển thị tất cả";
            this.button_ht.UseVisualStyleBackColor = true;
            this.button_ht.Click += new System.EventHandler(this.button_ht_Click);
            // 
            // LieuTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ht);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Tim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grb_nhaplt);
            this.Controls.Add(this.grb_lt);
            this.Controls.Add(this.lb_lt);
            this.Name = "LieuTrinh";
            this.Text = "LieuTrinh";
            this.Load += new System.EventHandler(this.LieuTrinh_Load);
            this.groupBox4.ResumeLayout(false);
            this.grb_nhaplt.ResumeLayout(false);
            this.grb_nhaplt.PerformLayout();
            this.grb_lt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox grb_nhaplt;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_motalt;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox txt_tenlt;
        private System.Windows.Forms.ComboBox cmb_idnv;
        private System.Windows.Forms.Label lb_idnv;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_tenlt;
        private System.Windows.Forms.GroupBox grb_lt;
        private System.Windows.Forms.DataGridView dataGVLT;
        private System.Windows.Forms.Label lb_lt;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox textBox_Tim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ht;
    }
}