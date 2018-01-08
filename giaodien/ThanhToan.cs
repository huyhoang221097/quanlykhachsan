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
    public partial class ThanhToan : Form
    {
        DbContext db = new DbContext();
        private SqlCommand Cmd;
        private SqlDataAdapter da = new SqlDataAdapter();
        string idphong,Tenkh,loaiphong;
        int cmnd, sl, tg, thanhtien, loaitg;
        public ThanhToan(string x, string y)
        {
            InitializeComponent();
            lbTenPhong.Text = x;
            idphong = y;
        }



        private void ShowMaKH()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES TenKH FROM KhachHang k INNER JOIN ThuePhong t on k.IDKH=t.IDKH where IDPhong='" + idphong + "' ORDER BY t.ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                Tenkh = (string)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ten kh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowCMND()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES CMND FROM KhachHang k INNER JOIN ThuePhong t on k.IDKH=t.IDKH where IDPhong='" + idphong + "' ORDER BY t.ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                cmnd = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cmnd", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowSL()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES SL FROM KhachHang k INNER JOIN ThuePhong t on k.IDKH=t.IDKH where IDPhong='" + idphong + "' ORDER BY t.ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                sl = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi sl nguoi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowLoaiPhong()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES LoaiPhong FROM Phong p INNER JOIN ThuePhong t on p.IDPhong=t.IDPhong where t.IDPhong='" + idphong + "' ORDER BY t.ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                loaiphong = (string)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Loai phong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Showtg()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES TgDat from ThuePhong where IDPhong='" + idphong + "' ORDER BY ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                tg = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tg", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowLoaiTG()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES LoaiTg from ThuePhong where IDPhong='" + idphong + "' ORDER BY ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                loaitg = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Loai tg", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowThanhTien()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string tamp = "SELECT TOP(1) WITH TIES Thanhtien from ThanhToan t inner join ThuePhong p on t.ID=p.ID  where IDPhong='" + idphong + "'  ORDER BY p.ID DESC";
                Cmd = new SqlCommand(tamp, Cnn);
                object IdKh = Cmd.ExecuteScalar();
                thanhtien = (int)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Thanh tien", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            ShowMaKH();
            lbTenKh.Text = Tenkh;
            ShowCMND();
            lbCMND.Text = cmnd.ToString();
            ShowSL();
            lbsonguoi.Text = sl.ToString();
            ShowLoaiPhong();
            lbLoaiPhong.Text = loaiphong;
            Showtg();
            lbtg.Text = tg.ToString();
            ShowLoaiTG();
            if(loaitg==1)
            {
                lbLoaitg.Text = "Giờ";
            }
            if (loaitg == 2)
            {
                lbLoaitg.Text = "Ngày";
            }
            ShowThanhTien();
            lbThanhtien.Text = thanhtien.ToString();
        }
        private void UpdateTT()
        {
            SqlConnection Cnn = db._DbContext();
            try
            {
                Cnn.Open();
                string themHD = "UPDATE [dbo].[Phong] SET [IDtrangThai] = @tt WHERE IDPhong = @IDPhong";
                Cmd = new SqlCommand(themHD, Cnn);
                Cmd.Parameters.AddWithValue("@tt", 1);
                Cmd.Parameters.AddWithValue("@IDPhong", idphong);
                Cmd.ExecuteNonQuery();
                Cnn.Close();
            }
            catch (SqlException)

            {
                MessageBox.Show("Lỗi Update Tongtien !");

            }
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            UpdateTT();
            MessageBox.Show("Ban có muốn thanh toán? click 'Yes'!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
