using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCNPM
{
    public partial class DangNhapAdmin : Form
    {
        FrmMain frm;
        CachTaoDe cdt;
        DangKyAdmin dkAmin;
        DoiThongTinAdmin dttAdmin;
        cla_crud crud = new cla_crud();

        public DangNhapAdmin()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đăng ký", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dkAmin = new DangKyAdmin();
                dkAmin.Show();
            }
        }

        private void CbShowPass_CheckedChanged_1(object sender, EventArgs e)
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

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            DataTable dt = crud.ReadData("SELECT * FROM Admin");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tenAdmin"].ToString() == txtAcc.Text && row["matKhauAdmin"].ToString() == txtPass.Text)
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.Hide();
                            cdt = new CachTaoDe();
                            cdt.Show();
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

        private void BtnDTT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đổi mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dttAdmin = new DoiThongTinAdmin();
                dttAdmin.Show();
            }
        }
    }
}
