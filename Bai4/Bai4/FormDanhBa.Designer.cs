namespace Bai4
{
    partial class FormDanhBa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTen = new Label();
            lblSDT = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lstLienHe = new ListBox();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 9.75F);
            lblTen.Location = new Point(403, 50);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(88, 23);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9.75F);
            lblSDT.Location = new Point(403, 130);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 23);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9.75F);
            txtTen.Location = new Point(403, 77);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(415, 29);
            txtTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9.75F);
            txtSDT.Location = new Point(403, 157);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(415, 29);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThem.Location = new Point(709, 215);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 43);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSua.Location = new Point(709, 276);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 43);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoa.Location = new Point(709, 327);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 43);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThoat.Location = new Point(709, 452);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 43);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstLienHe
            // 
            lstLienHe.Font = new Font("Segoe UI", 9.75F);
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(-2, 2);
            lstLienHe.Margin = new Padding(3, 4, 3, 4);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(344, 508);
            lstLienHe.TabIndex = 10;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 508);
            Controls.Add(lstLienHe);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lblSDT);
            Controls.Add(lblTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDanhBa";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTen;
        private Label lblSDT;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private ListBox lstLienHe;
    }
}
