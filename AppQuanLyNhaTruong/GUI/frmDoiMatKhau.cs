using BAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanTruongBAL tkBAL = new TaiKhoanTruongBAL();
        //TaiKhoanTruong MatKhau = new TaiKhoanTruong();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Nhap lai mat khau
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text != "")
            {
                if (txtMKMoi.Text == txtNhapLaiMK.Text)
                {
                    lblNhapLaiMK.Visible = false;
                }
                else
                {
                    lblNhapLaiMK.Visible = true;
                }
            }
            else
            {
                lblNhapLaiMK.Visible = false;
            }

            if (txtMKMoi.TextLength > 0 && txtNhapLaiMK.TextLength > 0 && !lblMKM.Visible && !lblNhapLaiMK.Visible && txtMKMoi.Text == txtNhapLaiMK.Text)
            {
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        // Thoat chuong trinh
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Thoát thành công!");
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        // Cap Nhat thong tin
        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            string text = txtMatKhau.Text;
            if ((await tkBAL.DangNhap(Program.TK.UserName, txtMatKha.Text)).Rows.Count == 1)// Neu ghi dung txtMatKhau thi loi nguyen 1 dong
            {
                Program.TK.Pass = txtNhapLaiMK.Text;
                if (await tkBAL.CapNhap(Program.TK) != -1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công.\n Vui lòng thử lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.\n Vui lòng thử lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Mat khau moi
        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtMKMoi.Text)
            {
                lblMKM.Visible = true;
            }
            else
            {
                lblMKM.Visible = false;
            }


            if (txtMKMoi.Text == txtNhapLaiMK.Text)
            {
                lblNhapLaiMK.Visible = false;
            }
            else
            {
                lblNhapLaiMK.Visible = true;
            }
            if (txtMKMoi.TextLength > 0 && txtNhapLaiMK.TextLength > 0 && !lblMKM.Visible && !lblNhapLaiMK.Visible && txtMKMoi.Text == txtNhapLaiMK.Text)
            {
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
