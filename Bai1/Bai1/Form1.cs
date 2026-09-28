namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraHopLe()
        {
            bool isValid = true;

            // 1. Kiểm tra Họ tên
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen) || hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải có ít nhất 3 ký tự!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra Số điện thoại
            string sdt = txtSDT.Text.Trim();
            // Điều kiện: đúng 10 ký tự, bắt đầu bằng '0' và tất cả đều là chữ số
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng số 0!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra Email
            string email = txtEmail.Text.Trim();
            int indexAt = email.IndexOf('@');
            int indexDot = email.LastIndexOf('.');

            // Điều kiện: Có chứa '@', có chứa '.' sau vị trí '@'
            if (indexAt <= 0 || indexDot <= indexAt + 1 || indexDot == email.Length - 1)
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ (phải chứa '@' và dấu '.' phía sau '@')!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra Mật khẩu
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(matKhau) || matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra Xác nhận mật khẩu
            string xacNhanMK = txtXacNhanMK.Text;
            if (xacNhanMK != matKhau || string.IsNullOrEmpty(xacNhanMK))
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return isValid;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLe())
            {
                MessageBox.Show("Đăng ký thành công!Chúc mừng " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }
    }
}
