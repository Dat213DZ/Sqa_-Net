
namespace login2
{
    partial class Goidichvu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_idnv = new System.Windows.Forms.ComboBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tengdv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGDV = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lamoi = new System.Windows.Forms.Button();
            this.button_tim = new System.Windows.Forms.Button();
            this.textBox_tim = new System.Windows.Forms.TextBox();
            this.button_HT = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH SÁCH GÓI DỊCH VỤ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.cmb_idnv);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_mota);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_tengdv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 251);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói dịch vụ";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(116, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 15;
            // 
            // cmb_idnv
            // 
            this.cmb_idnv.FormattingEnabled = true;
            this.cmb_idnv.Location = new System.Drawing.Point(116, 209);
            this.cmb_idnv.Name = "cmb_idnv";
            this.cmb_idnv.Size = new System.Drawing.Size(134, 21);
            this.cmb_idnv.TabIndex = 16;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(22, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 14;
            this.lb_id.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Nhân viên";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(116, 119);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(134, 20);
            this.txt_mota.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(116, 164);
            this.txt_gia.Multiline = true;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(134, 20);
            this.txt_gia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // txt_tengdv
            // 
            this.txt_tengdv.Location = new System.Drawing.Point(116, 74);
            this.txt_tengdv.Name = "txt_tengdv";
            this.txt_tengdv.Size = new System.Drawing.Size(134, 20);
            this.txt_tengdv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên gói dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGDV);
            this.groupBox1.Location = new System.Drawing.Point(284, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 339);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách gói dịch vụ";
            // 
            // dataGDV
            // 
            this.dataGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGDV.Location = new System.Drawing.Point(13, 20);
            this.dataGDV.Name = "dataGDV";
            this.dataGDV.Size = new System.Drawing.Size(480, 313);
            this.dataGDV.TabIndex = 0;
            this.dataGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGDV_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tengoidv";
            this.Column1.HeaderText = "Tên Gói Dịch Vụ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mota";
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gia";
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nv_id";
            this.Column4.HeaderText = "ID NV";
            this.Column4.Name = "Column4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 49);
            this.groupBox3.TabIndex = 20;
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
            // btn_lamoi
            // 
            this.btn_lamoi.Location = new System.Drawing.Point(192, 322);
            this.btn_lamoi.Name = "btn_lamoi";
            this.btn_lamoi.Size = new System.Drawing.Size(86, 23);
            this.btn_lamoi.TabIndex = 19;
            this.btn_lamoi.Text = "Làm mới";
            this.btn_lamoi.UseVisualStyleBackColor = true;
            this.btn_lamoi.Click += new System.EventHandler(this.btn_lamoi_Click);
            // 
            // button_tim
            // 
            this.button_tim.Location = new System.Drawing.Point(148, 17);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(75, 23);
            this.button_tim.TabIndex = 21;
            this.button_tim.Text = "Tìm";
            this.button_tim.UseVisualStyleBackColor = true;
            this.button_tim.Click += new System.EventHandler(this.button_tim_Click);
            // 
            // textBox_tim
            // 
            this.textBox_tim.Location = new System.Drawing.Point(13, 17);
            this.textBox_tim.Name = "textBox_tim";
            this.textBox_tim.Size = new System.Drawing.Size(129, 20);
            this.textBox_tim.TabIndex = 22;
            // 
            // button_HT
            // 
            this.button_HT.Location = new System.Drawing.Point(645, 32);
            this.button_HT.Name = "button_HT";
            this.button_HT.Size = new System.Drawing.Size(132, 23);
            this.button_HT.TabIndex = 21;
            this.button_HT.Text = "Hiển thị tất cả sản phẩm";
            this.button_HT.UseVisualStyleBackColor = true;
            this.button_HT.Click += new System.EventHandler(this.button_HT_Click);
            // 
            // Goidichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_tim);
            this.Controls.Add(this.button_HT);
            this.Controls.Add(this.button_tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_lamoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Goidichvu";
            this.Text = "Goidichvu";
            this.Load += new System.EventHandler(this.Goidichvu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tengdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_idnv;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lamoi;
        private System.Windows.Forms.Button button_tim;
        private System.Windows.Forms.TextBox textBox_tim;
        private System.Windows.Forms.Button button_HT;
    }
}