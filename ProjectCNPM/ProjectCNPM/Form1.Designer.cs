namespace ProjectCNPM
{
    partial class FrmMain
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.grbSysLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTTin = new System.Windows.Forms.Button();
            this.btnHDan = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.grbSysLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(77, 47);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(84, 34);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(77, 106);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(84, 32);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // grbSysLogin
            // 
            this.grbSysLogin.Controls.Add(this.label2);
            this.grbSysLogin.Controls.Add(this.label1);
            this.grbSysLogin.Controls.Add(this.btnUser);
            this.grbSysLogin.Controls.Add(this.btnAdmin);
            this.grbSysLogin.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSysLogin.Location = new System.Drawing.Point(54, 107);
            this.grbSysLogin.Name = "grbSysLogin";
            this.grbSysLogin.Size = new System.Drawing.Size(681, 163);
            this.grbSysLogin.TabIndex = 3;
            this.grbSysLogin.TabStop = false;
            this.grbSysLogin.Text = "Hệ Thống Đăng Nhập";
            this.grbSysLogin.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đăng nhập với quyền User (Sinh Viên)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng nhập với quyền Admin (Giáo Viên)";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTTin);
            this.groupBox2.Controls.Add(this.btnHDan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hỗ trợ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(518, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnTTin
            // 
            this.btnTTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTin.Location = new System.Drawing.Point(302, 38);
            this.btnTTin.Name = "btnTTin";
            this.btnTTin.Size = new System.Drawing.Size(104, 38);
            this.btnTTin.TabIndex = 1;
            this.btnTTin.Text = "Thông tin";
            this.btnTTin.UseVisualStyleBackColor = true;
            this.btnTTin.Click += new System.EventHandler(this.BtnTTin_Click);
            // 
            // btnHDan
            // 
            this.btnHDan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDan.Location = new System.Drawing.Point(77, 38);
            this.btnHDan.Name = "btnHDan";
            this.btnHDan.Size = new System.Drawing.Size(106, 38);
            this.btnHDan.TabIndex = 0;
            this.btnHDan.Text = "Hướng dẫn";
            this.btnHDan.UseVisualStyleBackColor = true;
            this.btnHDan.Click += new System.EventHandler(this.BtnHDan_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(124, 31);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(542, 38);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Phần Mềm Quản Lý Thi Trắc Nghiệm";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 455);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbSysLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Phần mềm quản lý thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grbSysLogin.ResumeLayout(false);
            this.grbSysLogin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.GroupBox grbSysLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTTin;
        private System.Windows.Forms.Button btnHDan;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

