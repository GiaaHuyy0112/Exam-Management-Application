using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class DangNhapUser : Form
    {
        ThiTracNghiem ttn;
        FrmMain frm;
        DangKyUser dkUser;
        DoiThongTinUser dttUser;
        cla_crud crud = new cla_crud();

        public DangNhapUser()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            DataTable dt = crud.ReadData("SELECT * FROM Sinhvien");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tenSV"].ToString() == txtAcc.Text && row["matKhauSV"].ToString() == txtPass.Text)
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.Hide();
                            ttn = new ThiTracNghiem();
                            DataTable dt2 = crud.ReadData("SELECT * FROM Sinhvien");
                            foreach (DataRow row2 in dt2.Rows)
                            {
                                if (txtAcc.Text == row["tenSV"].ToString())
                                {
                                    ttn.hoTen = row["hoTenSV"].ToString();
                                    ttn.gioiTinh = row["gioiTinh"].ToString();
                                }
                            }
                            ttn.Show();
                        }
                        count++;
                    }
                }
                if (count == 0)
                {
                    lbShowError.Text = "Tài khoản hoặc Mật khẩu không đúng";
                    txtAcc.Text = "";
                    txtPass.Text = "";
                    txtAcc.Focus();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đăng ký", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dkUser = new DangKyUser();
                dkUser.Show();
            }
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

        private void BtnDTT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đổi thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dttUser = new DoiThongTinUser();
                dttUser.Show();
            }
        }
    }
}
