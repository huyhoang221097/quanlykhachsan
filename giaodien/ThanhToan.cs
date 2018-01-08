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
        string idphong,Tenkh,cmnd,sl,loaiphong,tg,loaitg,thanhtien;
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
                MessageBox.Show("Lỗi ShowMaKh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                cmnd = (string)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ShowMaKh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                cmnd = (string)IdKh;
                Cnn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ShowMaKh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            ShowMaKH();
            lbTenKh.Text = Tenkh;
            ShowCMND();
            lbCMND.Text = cmnd;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
