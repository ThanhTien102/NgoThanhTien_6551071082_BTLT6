using System.ComponentModel;
using System.Globalization;

namespace Bai2
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }
        // 1. Kiểm tra Họ tên: không để trống
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
        }

        // 2. Kiểm tra CCCD: đúng 12 chữ số
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !cccd.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "CCCD phải gồm đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
        }

        // 3. Kiểm tra Ngày nhận: parse được dạng "dd/MM/yyyy" và >= hôm nay
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool isValidDate = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!isValidDate || ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải đúng định dạng dd/MM/yyyy và >= ngày hiện tại!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
        }

        // 4. Kiểm tra Ngày trả: parse được dạng "dd/MM/yyyy" và lớn hơn Ngày nhận
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra, ngayNhan;

            bool isNgayNhanValid = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            bool isNgayTraValid = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra
            );

            if (!isNgayTraValid || !isNgayNhanValid || ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải đúng định dạng dd/MM/yyyy và phải lớn hơn Ngày nhận!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
        }

        // 5. Kiểm tra Số người lớn: số nguyên từ 1 đến 4
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;
            bool isInt = int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon);

            if (!isInt || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
        }

        // 6. Kiểm tra Số trẻ em: số nguyên từ 0 đến 3
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;
            bool isInt = int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm);

            if (!isInt || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
        }

        // ==========================================
        // MỤC 3: XỬ LÝ SỰ KIỆN VALIDATED CHUNG
        // ==========================================
        private void TextBox_Validated(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                errorProvider1.SetError(txt, ""); // Xóa icon lỗi
                txt.BackColor = Color.Honeydew;  // Đặt nền màu xanh lá nhạt
            }
        }

        // ==========================================
        // MỤC 4: SỰ KIỆN BTNDATPHONG_CLICK
        // ==========================================
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra ValidateChildren để đảm bảo tất cả các ô đều hợp lệ trước khi tính toán
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Tính số đêm lưu trú
            int soDem = (ngayTra - ngayNhan).Days;

            string thongBao = $"Đặt phòng thành công!\n" +
                              $"Khách hàng: {txtHoTen.Text.Trim()}\n" +
                              $"Số đêm lưu trú: {soDem} đêm\n" +
                              $"Số lượng: {txtSoNguoiLon.Text.Trim()} người lớn, {txtSoTreEm.Text.Trim()} trẻ em.";

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
