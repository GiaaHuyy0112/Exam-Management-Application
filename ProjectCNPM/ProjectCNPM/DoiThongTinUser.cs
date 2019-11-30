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
    public partial class DoiThongTinUser : Form
    {
        DangNhapUser dnUser;
        cla_crud crud = new cla_crud();

        public DoiThongTinUser()
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
            Boolean check = crud.ExceData("UPDATE Sinhvien SET matKhauSV=N'" + txtPass.Text + "', hoTenSV=N'" + txtHoTen.Text + "', gioiTinh=N'" + txtGioiTinh.Text + "' WHERE tenSV='" + txtAcc.Text + "'");
            if (check == true)
            {
                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Không Đúng");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ trở lại trang đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dnUser = new DangNhapUser();
                dnUser.Show();
            }
        }

        private void TxtAcc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
