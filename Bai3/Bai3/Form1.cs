namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.TabStop = false; // Mã HS
            label2.TabStop = false; // Họ tên
            label3.TabStop = false; // Điểm Toán
            label4.TabStop = false; // Điểm Văn
            label5.TabStop = false; // Điểm Anh
            DangKyEnterChuyenField();

            // 2. Gán sự kiện Enter (bôi xanh chữ) cho 3 ô điểm (Mục 3)
            txtToan.Enter += TxtDiem_Enter;
            txtVan.Enter += TxtDiem_Enter;
            txtAnh.Enter += TxtDiem_Enter;

            // 3. Gán sự kiện Click cho nút Lưu (Mục 4)
            btnLuu.Click += btnLuu_Click;
            btnXoaTrang.Click += btnXoaTrang_Click;
        }
        private void DangKyEnterChuyenField()
        {
            // Duyệt tất cả các Control trên Form
            foreach (Control ctrl in this.Controls)
            {
                // Nếu là TextBox thì đăng ký sự kiện KeyPress
                if (ctrl is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        // Kiểm tra nếu phím bấm là Enter (mã '\r' hoặc 13)
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true; // Ngăn tiếng kêu 'bíp' của Windows khi ấn Enter

                            // Riêng txtAnh khi ấn Enter thì gọi btnLuu.PerformClick()
                            if (sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                // Chuyển focus sang control tiếp theo theo thứ tự TabIndex
                                this.SelectNextControl((Control)sender, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        // ==========================================
        // MỤC 3: XỬ LÝ SỰ KIỆN ENTER (NHẬN FOCUS) CHO TXTTOAN, TXTVAN, TXTANH
        // ==========================================
        private void TxtDiem_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll(); // Bôi xanh toàn bộ chữ/số cũ để gõ đè trực tiếp
            }
        }

        // ==========================================
        // MỤC 4: XỬ LÝ SỰ KIỆN BTNLUU_CLICK
        // ==========================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các thông báo lỗi cũ
            errorProvider1.Clear();
            bool isValid = true;

            // Kiểm tra Mã học sinh
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã HS không được để trống!");
                isValid = false;
            }

            // Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                isValid = false;
            }

            // Kiểm tra Điểm Toán (0.0 - 10.0)
            decimal diemToan;
            if (!decimal.TryParse(txtToan.Text.Trim(), out diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải là số hợp lệ từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Kiểm tra Điểm Văn (0.0 - 10.0)
            decimal diemVan;
            if (!decimal.TryParse(txtVan.Text.Trim(), out diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải là số hợp lệ từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Kiểm tra Điểm Anh (0.0 - 10.0)
            decimal diemAnh;
            if (!decimal.TryParse(txtAnh.Text.Trim(), out diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải là số hợp lệ từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Nếu tất cả dữ liệu hợp lệ
            if (isValid)
            {
                // Định dạng hiển thị chuỗi kết quả
                string item = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{diemToan} V:{diemVan} A:{diemAnh}";

                // Thêm dòng mới vào ListBox
                listBox1.Items.Add(item);

                // Xóa trắng form (reset các ô nhập liệu)
                txtMaHS.Clear();
                txtHoTen.Clear();
                txtToan.Clear();
                txtVan.Clear();
                txtAnh.Clear();

                // Đặt focus về ô Mã HS để tiếp tục nhập học sinh mới
                txtMaHS.Focus();
            }
        }

        // Bổ sung: Nút Xóa Trang (nếu giao diện của bạn có btnXoaTrang)
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            txtMaHS.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
        