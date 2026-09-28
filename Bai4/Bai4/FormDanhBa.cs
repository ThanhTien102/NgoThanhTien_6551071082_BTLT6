using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FormDanhBa : Form
    {
        // Biến theo dõi index của liên hệ đang được sửa (-1: không ở chế độ sửa)
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý nút Thêm / Cập nhật liên hệ
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(ten))
                {
                    txtTen.Focus();
                }
                else
                {
                    txtSDT.Focus();
                }
                return;
            }

            string contactInfo = $"{ten} - {sdt}";

            if (_indexDangSua != -1)
            {
                // Cập nhật liên hệ đang sửa
                lstLienHe.Items[_indexDangSua] = contactInfo;
                _indexDangSua = -1; // Đặt lại trạng thái
                txtTen.Clear();
                txtSDT.Clear();
                txtTen.Focus();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới liên hệ
                lstLienHe.Items.Add(contactInfo);
                txtTen.Clear();
                txtSDT.Clear();
                txtTen.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Xử lý nút Sửa: Đổ dữ liệu item đã chọn lên 2 TextBox
        /// </summary>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string itemText = lstLienHe.SelectedItem?.ToString() ?? string.Empty;

            int sepIndex = itemText.IndexOf(" - ");
            if (sepIndex >= 0)
            {
                txtTen.Text = itemText.Substring(0, sepIndex).Trim();
                txtSDT.Text = itemText.Substring(sepIndex + 3).Trim();
            }
            else
            {
                txtTen.Text = itemText;
                txtSDT.Text = string.Empty;
            }

            txtTen.Focus();
        }

        /// <summary>
        /// Xử lý nút Xóa liên hệ
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemText = lstLienHe.SelectedItem?.ToString() ?? string.Empty;
            string ten = itemText.Contains(" - ")
                ? itemText.Split(new[] { " - " }, StringSplitOptions.None)[0].Trim()
                : itemText;

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                int selectedIndex = lstLienHe.SelectedIndex;
                lstLienHe.Items.RemoveAt(selectedIndex);

                if (_indexDangSua == selectedIndex)
                {
                    _indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Xử lý nút Thoát
        /// </summary>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Xử lý sự kiện đóng Form
        /// </summary>
        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Thoát bình thường
                }
                else if (result == DialogResult.No)
                {
                    // Xóa TextBox rồi thoát
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
