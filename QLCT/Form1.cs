using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "select * from login where TenDangNhap='" + txtTenDangNhap.Text.Trim() + "'and MatKhau='" + txtMatKhau.Text.Trim() + "'";
            dt = KN.GetTable(sql);

            if(dt.Rows.Count==1)    
            {
                Form MENU = new Form_MeNu();
                MENU.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked = true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
