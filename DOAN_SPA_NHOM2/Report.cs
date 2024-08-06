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
    public partial class Report : Form
    {
        string ID = "", PASSWORD = "", CHUCVU = "";

        
        public Report(string ID, string PASSWORD, string CHUCVU)
        {
            InitializeComponent();
            this.ID = ID;
            this.PASSWORD = PASSWORD;
            this.CHUCVU = CHUCVU;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();

        }

        //private void hide()
        //{
        //    throw new NotImplementedException();
        //}

        private void Show_RP_Click(object sender, EventArgs e)
        {
            if (CHUCVU == "Quản lí")
            {
                CrystalReport3 rpt = new CrystalReport3();
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            else
                MessageBox.Show("Bạn không được cấp quyền này");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
