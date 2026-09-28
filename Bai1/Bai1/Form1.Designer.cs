namespace Bai1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(276, 88);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(330, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(276, 141);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(330, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(276, 238);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(330, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(276, 303);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(330, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.CornflowerBlue;
            btnDangKy.FlatStyle = FlatStyle.Popup;
            btnDangKy.Location = new Point(276, 367);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(110, 43);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 91);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 141);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 189);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 245);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 303);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 10;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 9);
            label6.Name = "label6";
            label6.Size = new Size(292, 32);
            label6.TabIndex = 11;
            label6.Text = "Đăng ký tài khoản mới";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 50);
            label7.Name = "label7";
            label7.Size = new Size(214, 20);
            label7.TabIndex = 12;
            label7.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ControlLight;
            btnHuy.CausesValidation = false;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(392, 367);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 43);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
