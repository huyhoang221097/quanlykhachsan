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
        
        

       
        
        public void button1_Click(object sender, EventArgs e)
        {
            
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
                    MessageBox.Show(Taikhoan.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
