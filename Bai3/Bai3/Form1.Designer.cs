namespace Bai3
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
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(71, 62);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(88, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(198, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(88, 27);
            txtHoTen.TabIndex = 1;
            txtHoTen.Enter += TxtDiem_Enter;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(323, 62);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(88, 27);
            txtToan.TabIndex = 2;
            txtToan.Enter += TxtDiem_Enter;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(447, 62);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(88, 27);
            txtVan.TabIndex = 3;
            txtVan.Enter += TxtDiem_Enter;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(573, 62);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(88, 27);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += TxtDiem_Enter;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Green;
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Location = new Point(71, 95);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(88, 45);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ButtonShadow;
            btnXoaTrang.FlatStyle = FlatStyle.Popup;
            btnXoaTrang.Location = new Point(198, 95);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(98, 45);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xoá Trang";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 39);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 8;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 39);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 39);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 39);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Điểm Anh";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 304);
            listBox1.TabIndex = 12;
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
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Name = "Form1";
            Text = "FormNhapDiem";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ErrorProvider errorProvider1;
    }
}
