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
        string idphong,Tenkh;
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
                string tamp = "SELECT TOP(1) WITH TIES IDKH FROM KhachHang ORDER BY IDKH DESC";
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

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            ShowMaKH();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
