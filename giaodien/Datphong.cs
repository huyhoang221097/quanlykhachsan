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
        string idphong;
        public Datphong(string x,string y)
        {
            InitializeComponent();
            lbTenphong.Text = x;
            idphong = y;
        }

        private void Datphong_Load(object sender, EventArgs e)
        {
            cboxLoaiTg.Items.Add("Giờ");
            cboxLoaiTg.Items.Add("Ngày");
        }

        int time;
        private void cboxLoaiTg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLoaiTg.SelectedItem.ToString() == "Giờ")
            {
                time = 1;
                
            }
            if (cboxLoaiTg.SelectedItem.ToString() == "Ngày")
            {
                time = 2;
                
            }
        }

        #region====== Truy Cập Kh ==================
        int makh;
        int gia;
        private string Xuat_kq(SqlDataReader kq)
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
        private void ShowMaKH()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES IDKH FROM KhachHang ORDER BY IDKH DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                makh = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ShowMaKh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowGia()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string sql = "select Gia from LoaiTGdat Where LoaiTG=@textbox";
                Cmd = new SqlCommand(sql, Cnn);
                Cmd.Parameters.Add(new SqlParameter("@textbox", time));
                object giaban = Cmd.ExecuteScalar();
                gia = (int)giaban;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion=======================================

        #region========== Insert Thuê Phòng ============
        private void AddThuephong()
        {
            ShowMaKH();
            


            try
            {
                SqlConnection Cnn = db._DbContext();
                Cnn.Open();
                string themHD = "INSERT INTO [dbo].[Thuephong]([IDPhong],[IDKH],[LoaiTG],[TgDat]) VALUES(@IDPhong,@IDKH,@LoaiTG,@TgDat)";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@IDPhong", idphong.Trim());
                Cmd.Parameters.AddWithValue("@IDKH", makh);
                Cmd.Parameters.AddWithValue("@LoaiTG", time);
                Cmd.Parameters.AddWithValue("@TGDat", tbTGdat.Text);
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
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        

        

        private void AddThanhToan()
        {
            ShowGia();
            SqlConnection Cnn = db._DbContext();
            int tg = int.Parse(tbTGdat.Text);
            int s = gia * tg;
            try
            {
                Cnn.Open();
                string themHD = "INSERT INTO [dbo].[ThanhToan]([ID],[Ngaydat],[Ngaytra],[Thanhtien]) VALUES(@ID,@Ngaydat,@Ngaytra,@Thanhtien)";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@ID", tbTenKh.Text);
                Cmd.Parameters.AddWithValue("@NgayDat", year + "-" + month + "-" + day);
                Cmd.Parameters.AddWithValue("@Ngaytra", year + "-" + month + "-" + day);
                Cmd.Parameters.AddWithValue("@Thanhtien",s);
                Cmd.ExecuteNonQuery();
                Cnn.Close();
            }
            catch (SqlException)

            {
                MessageBox.Show("Lỗi Khách Hàng Table");

            }


        }
        #endregion=========================================
        private void settext()
        {
            tbTenKh.Text = string.Empty;
            tbSDT.Text = string.Empty;
            tbCMND.Text = string.Empty;
            tbDiaChi.Text = string.Empty;
            tbSoNguoi.Text = string.Empty;
            tbTGdat.Text = string.Empty;
        }
    private void button1_Click(object sender, EventArgs e)
        {
            if(KiemTraTextbox()==false)
            {
                AddKH();
                
                AddThuephong();
                AddThanhToan();
                settext();
                MessageBox.Show("Thành CÔng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        
        #region==== Bắt lỗi Dự Liệu ============
        public bool KiemTraTextbox()
        {
            if (tbTenKh.Text.Length < 4)
            { 
                    MessageBox.Show("Lỗi: 'Tên Khách Hàng' ít nhất 4 Ký Tự!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
            }
            if (tbSDT.Text.Length < 9 || tbSDT.Text.Length >11)
            {
                MessageBox.Show("Lỗi: 'SĐT' phải 9 tới 10 số!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (tbCMND.Text.Length != 9)
            {
                MessageBox.Show("Lỗi: 'Số SMND' phải 9 số!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (tbDiaChi.Text.Length < 4)
            {
                MessageBox.Show("Lỗi: 'Địa chỉ' ít nhất 4 Ký Tự!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (int.Parse(tbSoNguoi.Text) <1 || int.Parse(tbSoNguoi.Text) > 4 )
            {
                MessageBox.Show("Lỗi: 'Phòng' chỉ chứa từ 1 đến 4 người!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (int.Parse(tbTGdat.Text) < 1)
            {
                MessageBox.Show("Lỗi: 'Thời gian đặt' phải lớn hơn 1!", "Thống Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        #endregion ===================================

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.tbSDT.Text, out n))
            {

            }
            else
                tbSDT.Text = "";
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.tbCMND.Text, out n))
            {

            }
            else
                tbCMND.Text = "";
        }

        private void tbSoNguoi_TextChanged(object sender, EventArgs e)
        {
            int n = 1;
            if (int.TryParse(this.tbSoNguoi.Text, out n))
            {

            }
            else
                tbSoNguoi.Text = "";
        }

        private void tbTGdat_TextChanged(object sender, EventArgs e)
        {
            int n = 1;
            if (int.TryParse(this.tbTGdat.Text, out n))
            {

            }
            else
                tbTGdat.Text = "";
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
    }
}
