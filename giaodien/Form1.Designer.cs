namespace quanlykhachsan
{
    partial class Form1
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
            this.Taikhoan = new System.Windows.Forms.TextBox();
            this.Matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Taikhoan
            // 
            this.Taikhoan.Location = new System.Drawing.Point(221, 153);
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.Size = new System.Drawing.Size(207, 31);
            this.Taikhoan.TabIndex = 0;
            // 
            // Matkhau
            // 
            this.Matkhau.Location = new System.Drawing.Point(221, 204);
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Size = new System.Drawing.Size(207, 31);
            this.Matkhau.TabIndex = 1;
            this.Matkhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Dangnhap
            // 
            this.Dangnhap.AutoSize = true;
            this.Dangnhap.BackColor = System.Drawing.Color.Maroon;
            this.Dangnhap.ForeColor = System.Drawing.Color.Snow;
            this.Dangnhap.Location = new System.Drawing.Point(221, 252);
            this.Dangnhap.Name = "Dangnhap";
            this.Dangnhap.Size = new System.Drawing.Size(80, 35);
            this.Dangnhap.TabIndex = 2;
            this.Dangnhap.Text = "Login";
            this.Dangnhap.UseVisualStyleBackColor = false;
            this.Dangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng Nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Matkhau);
            this.Controls.Add(this.Taikhoan);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Taikhoan;
        private System.Windows.Forms.TextBox Matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dangnhap;
        private System.Windows.Forms.Label label1;
    }
}

