
namespace login2
{
    partial class LichHen
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
            this.cmb_idkh = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.txt_ngayden = new System.Windows.Forms.MaskedTextBox();
            this.txt_ngaydat = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datalh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lamoi = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.button_Ht = new System.Windows.Forms.Button();
            this.maskedTextBox_tim = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH SÁCH LỊCH HẸN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_idkh);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.txt_ngayden);
            this.groupBox2.Controls.Add(this.txt_ngaydat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 251);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông lịch hẹn";
            // 
            // cmb_idkh
            // 
            this.cmb_idkh.FormattingEnabled = true;
            this.cmb_idkh.Location = new System.Drawing.Point(114, 90);
            this.cmb_idkh.Name = "cmb_idkh";
            this.cmb_idkh.Size = new System.Drawing.Size(134, 21);
            this.cmb_idkh.TabIndex = 23;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(114, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 22;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(17, 37);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 21;
            this.lb_id.Text = "Id";
            // 
            // txt_ngayden
            // 
            this.txt_ngayden.Location = new System.Drawing.Point(114, 195);
            this.txt_ngayden.Mask = "00/00/0000";
            this.txt_ngayden.Name = "txt_ngayden";
            this.txt_ngayden.Size = new System.Drawing.Size(134, 20);
            this.txt_ngayden.TabIndex = 6;
            this.txt_ngayden.ValidatingType = typeof(System.DateTime);
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Location = new System.Drawing.Point(114, 142);
            this.txt_ngaydat.Mask = "00/00/0000";
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(134, 20);
            this.txt_ngaydat.TabIndex = 5;
            this.txt_ngaydat.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datalh);
            this.groupBox1.Location = new System.Drawing.Point(284, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 339);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lịch hẹn";
            // 
            // datalh
            // 
            this.datalh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datalh.Location = new System.Drawing.Point(13, 20);
            this.datalh.Name = "datalh";
            this.datalh.Size = new System.Drawing.Size(480, 313);
            this.datalh.TabIndex = 0;
            this.datalh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DV_DSLH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "KH_ID";
            this.Column2.HeaderText = "ID Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaydat";
            this.Column3.HeaderText = "Ngày Đặt";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayDen";
            this.Column4.HeaderText = "Ngày Đến";
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
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(185, 12);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 22;
            this.btn_tim.Text = "tim";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // button_Ht
            // 
            this.button_Ht.Location = new System.Drawing.Point(652, 33);
            this.button_Ht.Name = "button_Ht";
            this.button_Ht.Size = new System.Drawing.Size(125, 23);
            this.button_Ht.TabIndex = 22;
            this.button_Ht.Text = "Hiển thị  tất cả";
            this.button_Ht.UseVisualStyleBackColor = true;
            this.button_Ht.Click += new System.EventHandler(this.button_Ht_Click);
            // 
            // maskedTextBox_tim
            // 
            this.maskedTextBox_tim.Location = new System.Drawing.Point(13, 14);
            this.maskedTextBox_tim.Mask = "00/00/0000";
            this.maskedTextBox_tim.Name = "maskedTextBox_tim";
            this.maskedTextBox_tim.Size = new System.Drawing.Size(166, 20);
            this.maskedTextBox_tim.TabIndex = 23;
            this.maskedTextBox_tim.ValidatingType = typeof(System.DateTime);
            // 
            // LichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox_tim);
            this.Controls.Add(this.button_Ht);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_lamoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LichHen";
            this.Text = "LichHen";
            this.Load += new System.EventHandler(this.LichHen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_ngayden;
        private System.Windows.Forms.MaskedTextBox txt_ngaydat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datalh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lamoi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cmb_idkh;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button button_Ht;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tim;
    }
}