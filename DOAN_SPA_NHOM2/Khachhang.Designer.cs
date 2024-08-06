
namespace login2
{
    partial class Khachhang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGVKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.rab_nu = new System.Windows.Forms.RadioButton();
            this.rab_Nam = new System.Windows.Forms.RadioButton();
            this.txt_namsinh = new System.Windows.Forms.MaskedTextBox();
            this.cmb_idnv = new System.Windows.Forms.ComboBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lamoi = new System.Windows.Forms.Button();
            this.textBox_tim = new System.Windows.Forms.TextBox();
            this.button_tim = new System.Windows.Forms.Button();
            this.button_ht = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGVKH);
            this.groupBox3.Location = new System.Drawing.Point(286, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dataGVKH
            // 
            this.dataGVKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGVKH.Location = new System.Drawing.Point(7, 20);
            this.dataGVKH.Name = "dataGVKH";
            this.dataGVKH.Size = new System.Drawing.Size(491, 340);
            this.dataGVKH.TabIndex = 0;
            this.dataGVKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenkh";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sdt";
            this.Column3.HeaderText = "SDT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "email";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "diachi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sinhnam";
            this.Column6.HeaderText = "Năm sinh";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gioitinh";
            this.Column7.HeaderText = "Giới tính";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "nv_id";
            this.Column8.HeaderText = "ID nhân viên";
            this.Column8.Name = "Column8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.rab_nu);
            this.groupBox1.Controls.Add(this.rab_Nam);
            this.groupBox1.Controls.Add(this.txt_namsinh);
            this.groupBox1.Controls.Add(this.cmb_idnv);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(118, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 24;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(17, 26);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 23;
            this.lb_id.Text = "Id";
            // 
            // rab_nu
            // 
            this.rab_nu.AutoSize = true;
            this.rab_nu.Location = new System.Drawing.Point(181, 200);
            this.rab_nu.Name = "rab_nu";
            this.rab_nu.Size = new System.Drawing.Size(39, 17);
            this.rab_nu.TabIndex = 7;
            this.rab_nu.TabStop = true;
            this.rab_nu.Text = "Nữ";
            this.rab_nu.UseVisualStyleBackColor = true;
            // 
            // rab_Nam
            // 
            this.rab_Nam.AutoSize = true;
            this.rab_Nam.Location = new System.Drawing.Point(128, 200);
            this.rab_Nam.Name = "rab_Nam";
            this.rab_Nam.Size = new System.Drawing.Size(47, 17);
            this.rab_Nam.TabIndex = 7;
            this.rab_Nam.Text = "Nam";
            this.rab_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_namsinh
            // 
            this.txt_namsinh.Location = new System.Drawing.Point(118, 172);
            this.txt_namsinh.Mask = "00/00/0000";
            this.txt_namsinh.Name = "txt_namsinh";
            this.txt_namsinh.Size = new System.Drawing.Size(134, 20);
            this.txt_namsinh.TabIndex = 6;
            this.txt_namsinh.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_idnv
            // 
            this.cmb_idnv.FormattingEnabled = true;
            this.cmb_idnv.Location = new System.Drawing.Point(118, 232);
            this.cmb_idnv.Name = "cmb_idnv";
            this.cmb_idnv.Size = new System.Drawing.Size(134, 21);
            this.cmb_idnv.TabIndex = 4;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(118, 141);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(134, 20);
            this.txt_diachi.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(118, 111);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(134, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(118, 81);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(134, 20);
            this.txt_sdt.TabIndex = 2;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(118, 51);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(134, 20);
            this.txt_tenkh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 49);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
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
            // btn_lamoi
            // 
            this.btn_lamoi.Location = new System.Drawing.Point(192, 343);
            this.btn_lamoi.Name = "btn_lamoi";
            this.btn_lamoi.Size = new System.Drawing.Size(86, 23);
            this.btn_lamoi.TabIndex = 21;
            this.btn_lamoi.Text = "Làm mới";
            this.btn_lamoi.UseVisualStyleBackColor = true;
            this.btn_lamoi.Click += new System.EventHandler(this.btn_lamoi_Click);
            // 
            // textBox_tim
            // 
            this.textBox_tim.Location = new System.Drawing.Point(19, 14);
            this.textBox_tim.Name = "textBox_tim";
            this.textBox_tim.Size = new System.Drawing.Size(168, 20);
            this.textBox_tim.TabIndex = 23;
            // 
            // button_tim
            // 
            this.button_tim.Location = new System.Drawing.Point(197, 14);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(75, 23);
            this.button_tim.TabIndex = 24;
            this.button_tim.Text = "Tìm";
            this.button_tim.UseVisualStyleBackColor = true;
            this.button_tim.Click += new System.EventHandler(this.button_tim_Click);
            // 
            // button_ht
            // 
            this.button_ht.Location = new System.Drawing.Point(637, 32);
            this.button_ht.Name = "button_ht";
            this.button_ht.Size = new System.Drawing.Size(147, 23);
            this.button_ht.TabIndex = 24;
            this.button_ht.Text = "Hiển thị tất cả";
            this.button_ht.UseVisualStyleBackColor = true;
            this.button_ht.Click += new System.EventHandler(this.button_ht_Click);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ht);
            this.Controls.Add(this.button_tim);
            this.Controls.Add(this.textBox_tim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_lamoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khachhang";
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGVKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rab_nu;
        private System.Windows.Forms.RadioButton rab_Nam;
        private System.Windows.Forms.MaskedTextBox txt_namsinh;
        private System.Windows.Forms.ComboBox cmb_idnv;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lamoi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox textBox_tim;
        private System.Windows.Forms.Button button_tim;
        private System.Windows.Forms.Button button_ht;
    }
}