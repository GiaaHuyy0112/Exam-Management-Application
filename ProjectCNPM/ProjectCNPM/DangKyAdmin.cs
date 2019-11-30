using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class DangKyAdmin : Form
    {
        cla_crud crud = new cla_crud();
        DangNhapAdmin system;

        public DangKyAdmin()
        {
            InitializeComponent();
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("INSERT INTO Admin(tenAdmin, matKhauAdmin) VALUES (N'" + txtAcc.Text + "', N'" + txtPass.Text + "')");
            if (check == true)
            {
                MessageBox.Show("Đăng Ký Thành Công");
                lbShowError.Text = "";
                txtAcc.Text = "";
                txtPass.Text = "";
            }
            else
            {
                lbShowError.Text = "Tài Khoản Bị Trùng. Hãy Đặt Tên Tài Khoản Mới";
                txtAcc.Text = "";
                txtPass.Text = "";
                txtAcc.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ trở lại trang đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                system = new DangNhapAdmin();
                system.Show();
            }
        }

        private void DangKyAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
