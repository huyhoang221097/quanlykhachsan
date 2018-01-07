using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan.giaodien
{
    public partial class Datphong : Form
    {
        DbContext db = new DbContext();
        private SqlCommand Cmd;
        private SqlDataAdapter da = new SqlDataAdapter();
        public Datphong(string x)
        {
            InitializeComponent();
            lbTenphong.Text = x;
        }

        private void Datphong_Load(object sender, EventArgs e)
        {
            cboxLoaiTg.Items.Add("Giờ");
            cboxLoaiTg.Items.Add("Ngày");
        }
        #region========== Insert Khách Hàng ============
        private void AddKH()
        {
            SqlConnection Cnn = db._DbContext();

            
            try
            {
                Cnn.Open();
                string themHD = "INSERT INTO [dbo].[KhachHang]([TenKH],[SDT],[CMND],[DiaChi],[SL]) VALUES(@TenKH,@SDT,@CMND,@DiaChi,@SL)";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@TenKH", tbTenKh.Text);
                Cmd.Parameters.AddWithValue("@SDT", tbSDT.Text);
                Cmd.Parameters.AddWithValue("@CMND", tbCMND.Text);
                Cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
                Cmd.Parameters.AddWithValue("@SL", tbSoNguoi.Text);
                Cmd.ExecuteNonQuery();
                Cnn.Close();
            }
            catch (SqlException)

            {
                MessageBox.Show("Lỗi Khách Hàng Table");

            }


        }
        #endregion=========================================

        #region========== Insert Thuê Phòng ============
        private void AddThuephong()
        {
            SqlConnection Cnn = db._DbContext();


            try
            {
                Cnn.Open();
                string themHD = "INSERT INTO [dbo].[ThanhToan]([IDPhong],[IDKH],[LoaiTG],[TgDat]) VALUES(@IDPhong,@IDKH,@LoaiTG,@TgDat)";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@ID", tbTenKh.Text);
                Cmd.Parameters.AddWithValue("@NgayDat", tbSDT.Text);
                Cmd.Parameters.AddWithValue("@Ngaytra", tbCMND.Text);
                Cmd.Parameters.AddWithValue("@Thanhtien", tbDiaChi.Text);
                Cmd.ExecuteNonQuery();
                Cnn.Close();
            }
            catch (SqlException)

            {
                MessageBox.Show("Lỗi Khách Hàng Table");

            }
        }
        #endregion=========================================

        #region========== Insert Thanh Toan ============
        private void AddThanhToan()
        {
            SqlConnection Cnn = db._DbContext();


            try
            {
                Cnn.Open();
                string themHD = "INSERT INTO [dbo].[ThanhToan]([ID],[Ngaydat],[Ngaytra],[Thanhtien]) VALUES(@ID,@Ngaydat,@Ngaytra,@Thanhtien)";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@ID", tbTenKh.Text);
                Cmd.Parameters.AddWithValue("@NgayDat", tbSDT.Text);
                Cmd.Parameters.AddWithValue("@Ngaytra", tbCMND.Text);
                Cmd.Parameters.AddWithValue("@Thanhtien", tbDiaChi.Text);
                Cmd.ExecuteNonQuery();
                Cnn.Close();
            }
            catch (SqlException)

            {
                MessageBox.Show("Lỗi Khách Hàng Table");

            }


        }
        #endregion=========================================
        private void button1_Click(object sender, EventArgs e)
        {

        }
        int time;
        private void cboxLoaiTg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLoaiTg.SelectedItem.ToString() == "Giờ")
            {
                time = 1;
                MessageBox.Show("Giờ" + time, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (cboxLoaiTg.SelectedItem.ToString() == "Ngày")
            {
                time = 2;
                MessageBox.Show("Ngày" + time, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
