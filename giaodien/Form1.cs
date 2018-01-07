using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using quanlykhachsan.giaodien;

namespace quanlykhachsan
{


   


    public partial class Form1 : Form
    {
        DbContext db = new DbContext();
        SqlCommand Cmd;

        public string xy;
        public Form1()
        {
            
            InitializeComponent();
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //--------------------- Chỉnh Size Form ---------------------------------------------
        public void SetSize(System.Windows.Forms.Form frm)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey( frm.Name);
                frm.Height = (int)key.GetValue("Height", frm.Height);
                frm.Width = (int)key.GetValue("Width", frm.Width);
                frm.Left = (int)key.GetValue("Left", frm.Left);
                frm.Top = (int)key.GetValue("Top", frm.Top);
                //
    


            }
            catch
            {
            }
        }
        string bientam;
        private string tmp(SqlDataReader kq)
        {
            StringBuilder strb = new StringBuilder();
            while (kq.Read())
            {

                //-- Truy chỉ số cột
                for (int i = 0; i < kq.FieldCount; i++)
                    strb.Append(kq[i].ToString() + (i == kq.FieldCount - 1 ? "" : ":"));
                strb.AppendLine();
            }
            return strb.ToString();
        }
        //--- truy cập và gán vào biến tạm
        private void ShowQuyenhan()
        {
            SqlConnection Cnn = db._DbContext();
            Cnn.Open();
            try
            {
                
                string tamp = "select Roles from Accounts WHERE ID = '" + Taikhoan.Text + "' ";
                Cmd = new SqlCommand(tamp, Cnn);
                SqlDataReader dr = Cmd.ExecuteReader();
                bientam= tmp(dr);
                

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Search Accounts!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

       
        
        public void button1_Click(object sender, EventArgs e)
        {
            ShowQuyenhan();
            try
            {
                SqlConnection Cnn = db._DbContext();
                Cnn.Open();

                string login_in = "Select Count(*) from Accounts Where ID=@acc and Password=@pass";
                Cmd = new SqlCommand(login_in, Cnn);
                Cmd.Parameters.Add(new SqlParameter("@acc", Taikhoan.Text));
                Cmd.Parameters.Add(new SqlParameter("@pass", Matkhau.Text));
                int K = (int)Cmd.ExecuteScalar();
                if (K == 1)
                {
                    if (bientam.Trim() != null)
                    {
                        if (bientam.Trim() == "admin")
                        {
                            admin ad = new admin();
                            this.Visible = false;
                            if ((new admin()).ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            { this.Visible = true; }
                            ad.Show();
                            this.Close();

                        }
                        if (bientam.Trim() == "manager")
                        {
                            QLphong ql = new QLphong();
                            this.Visible = false;
                            if ((new QLphong()).ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            { this.Visible = true; }
                            ql.Show();
                            this.Close();
                        }
                        if (bientam.Trim() == "salesman")
                        {
                            Thuephong tp = new Thuephong();
                            this.Visible = false;
                            if ((new Thuephong()).ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            { this.Visible = true; }
                            tp.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa có quyền đăng nhập!" + "\nHệ Thống đang cập nhật... Vui lòng liên hệ Quản Trị Viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    
                    MessageBox.Show("Đăng nhập thất bại !!!"+ "\n Lỗi: Sai tài khoản hoặc mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối Form 1 ");
                
              
            }
            
            Taikhoan.Text = string.Empty;
            Matkhau.Text = string.Empty;


        }
        
       
        
    }
}
