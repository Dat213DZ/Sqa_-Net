
namespace login2
{
    partial class Dichvu
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
            this.btn_lamoi = new System.Windows.Forms.Button();
            this.lb_DV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_idnv = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVDV = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.textBox_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.button_HT = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_lamoi
            // 
            this.btn_lamoi.Location = new System.Drawing.Point(192, 322);
            this.btn_lamoi.Name = "btn_lamoi";
            this.btn_lamoi.Size = new System.Drawing.Size(86, 23);
            this.btn_lamoi.TabIndex = 17;
            this.btn_lamoi.Text = "Làm mới";
            this.btn_lamoi.UseVisualStyleBackColor = true;
            this.btn_lamoi.Click += new System.EventHandler(this.txt_lamoi_Click);
            // 
            // lb_DV
            // 
            this.lb_DV.AutoSize = true;
            this.lb_DV.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DV.Location = new System.Drawing.Point(242, 18);
            this.lb_DV.Name = "lb_DV";
            this.lb_DV.Size = new System.Drawing.Size(300, 31);
            this.lb_DV.TabIndex = 16;
            this.lb_DV.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_idnv);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_mota);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_tendv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 251);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // cmb_idnv
            // 
            this.cmb_idnv.FormattingEnabled = true;
            this.cmb_idnv.Location = new System.Drawing.Point(117, 203);
            this.cmb_idnv.Name = "cmb_idnv";
            this.cmb_idnv.Size = new System.Drawing.Size(134, 21);
            this.cmb_idnv.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(117, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 6;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(23, 31);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Nhân viên";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(117, 159);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(134, 20);
            this.txt_gia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(117, 114);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(134, 20);
            this.txt_mota.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(117, 69);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(134, 20);
            this.txt_tendv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVDV);
            this.groupBox1.Location = new System.Drawing.Point(284, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 339);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dataGVDV
            // 
            this.dataGVDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGVDV.Location = new System.Drawing.Point(12, 19);
            this.dataGVDV.Name = "dataGVDV";
            this.dataGVDV.Size = new System.Drawing.Size(480, 313);
            this.dataGVDV.TabIndex = 0;
            this.dataGVDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDV_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tendv";
            this.Column1.HeaderText = "Tên Dịch Vụ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mota";
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gia";
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nv_id";
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
            this.groupBox3.TabIndex = 18;
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
            this.textBox_Tim.Location = new System.Drawing.Point(12, 18);
            this.textBox_Tim.Name = "textBox_Tim";
            this.textBox_Tim.Size = new System.Drawing.Size(135, 20);
            this.textBox_Tim.TabIndex = 19;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(153, 15);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 20;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // button_HT
            // 
            this.button_HT.Location = new System.Drawing.Point(617, 32);
            this.button_HT.Name = "button_HT";
            this.button_HT.Size = new System.Drawing.Size(159, 23);
            this.button_HT.TabIndex = 20;
            this.button_HT.Text = "Hiển thị tất cả";
            this.button_HT.UseVisualStyleBackColor = true;
            this.button_HT.Click += new System.EventHandler(this.button_HT_Click);
            // 
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_HT);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.textBox_Tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_lamoi);
            this.Controls.Add(this.lb_DV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dichvu";
            this.Text = "Dichvu";
            this.Load += new System.EventHandler(this.Dichvu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lamoi;
        private System.Windows.Forms.Label lb_DV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGVDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cmb_idnv;
        private System.Windows.Forms.TextBox textBox_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button button_HT;
    }
}