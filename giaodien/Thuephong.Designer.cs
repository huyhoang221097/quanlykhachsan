namespace quanlykhachsan.giaodien
{
    partial class Thuephong
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
            this.tabPhong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btTimPhong = new System.Windows.Forms.Button();
            this.tbtimphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gribview_DSPhong = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPhong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gribview_DSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.tabPage1);
            this.tabPhong.Controls.Add(this.tabPage2);
            this.tabPhong.Location = new System.Drawing.Point(12, 49);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.SelectedIndex = 0;
            this.tabPhong.Size = new System.Drawing.Size(1331, 614);
            this.tabPhong.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btTimPhong);
            this.tabPage1.Controls.Add(this.tbtimphong);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Gribview_DSPhong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1323, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btTimPhong
            // 
            this.btTimPhong.BackColor = System.Drawing.Color.Green;
            this.btTimPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimPhong.ForeColor = System.Drawing.Color.White;
            this.btTimPhong.Location = new System.Drawing.Point(573, 91);
            this.btTimPhong.Name = "btTimPhong";
            this.btTimPhong.Size = new System.Drawing.Size(174, 31);
            this.btTimPhong.TabIndex = 4;
            this.btTimPhong.Text = "Tìm phòng";
            this.btTimPhong.UseVisualStyleBackColor = false;
            this.btTimPhong.Click += new System.EventHandler(this.btTimPhong_Click);
            // 
            // tbtimphong
            // 
            this.tbtimphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimphong.Location = new System.Drawing.Point(227, 91);
            this.tbtimphong.Name = "tbtimphong";
            this.tbtimphong.Size = new System.Drawing.Size(303, 31);
            this.tbtimphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // Gribview_DSPhong
            // 
            this.Gribview_DSPhong.AllowUserToAddRows = false;
            this.Gribview_DSPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gribview_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gribview_DSPhong.Location = new System.Drawing.Point(17, 131);
            this.Gribview_DSPhong.Name = "Gribview_DSPhong";
            this.Gribview_DSPhong.ReadOnly = true;
            this.Gribview_DSPhong.Size = new System.Drawing.Size(730, 439);
            this.Gribview_DSPhong.TabIndex = 0;
            this.Gribview_DSPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gribview_DSPhong_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1323, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Thuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 675);
            this.Controls.Add(this.tabPhong);
            this.MaximumSize = new System.Drawing.Size(1372, 780);
            this.Name = "Thuephong";
            this.Text = "Quản Lý Khách Sạn - Thuê Phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thuephong_Load);
            this.tabPhong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gribview_DSPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPhong;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Gribview_DSPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtimphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTimPhong;
    }
}