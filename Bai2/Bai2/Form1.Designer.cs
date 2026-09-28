namespace Bai2
{
    partial class FormDatPhong
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
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(126, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(558, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(126, 85);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(558, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(126, 138);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(558, 27);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(126, 205);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(558, 27);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(126, 274);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(558, 27);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(126, 342);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(558, 27);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 62);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 7;
            label2.Text = "CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 115);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Ngày Nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 182);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày Trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 251);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Số Người Lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 319);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Số Trẻ em";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.RoyalBlue;
            btnDatPhong.FlatStyle = FlatStyle.Popup;
            btnDatPhong.ForeColor = SystemColors.ButtonHighlight;
            btnDatPhong.Location = new Point(126, 392);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(558, 29);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Name = "FormDatPhong";
            Text = "FormDatPhong";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
