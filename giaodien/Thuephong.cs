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
    public partial class Thuephong : Form
    {
        DbContext db = new DbContext();
        private SqlCommand Cmd;
        private SqlDataAdapter da = new SqlDataAdapter();
        public Thuephong()
        {
            InitializeComponent();
        }

        private void Thuephong_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }



        private void LoadGrid()
        {
            SqlConnection Cnn = db._DbContext();
            Cnn.Open();
            string sql = "select IDphong as [Mã Phòng], TenPhong as [Tên Phòng], sogiuong [Số Giường], Loaiphong as [Loại Phòng], Tentrangthai as [Trạng Thái] From Phong P INNER JOIN TrangThai T On P.IDTrangthai=T.IDTrangthai";
            Cmd = new SqlCommand(sql, Cnn);
            SqlDataAdapter alap = new SqlDataAdapter(Cmd);
            DataTable Table = new DataTable();
            alap.Fill(Table);
            Gribview_DSPhong.DataSource = Table;
        }

        private void Timphong(string x)
        {
            SqlConnection Cnn = db._DbContext();
            Cnn.Open();
            string sql = "select IDphong as [Mã Phòng], TenPhong as [Tên Phòng], sogiuong [Số Giường], Loaiphong as [Loại Phòng], Tentrangthai as [Trạng Thái] From Phong P INNER JOIN TrangThai T On P.IDTrangthai=T.IDTrangthai where TenPhong = @tenphong";
            Cmd = new SqlCommand(sql, Cnn);
            Cmd.Parameters.Add(new SqlParameter("@tenphong", x));
            SqlDataAdapter alap = new SqlDataAdapter(Cmd);
            DataTable Table = new DataTable();
            alap.Fill(Table);
            Gribview_DSPhong.DataSource = Table;
        }

        private void btTimPhong_Click(object sender, EventArgs e)
        {
            Timphong(tbtimphong.Text);
        }

        string bt;
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
        private void timtenphong(string x)
        {
            SqlConnection Cnn = db._DbContext();
            Cnn.Open();
            try
            {

                string tamp = "select TenPhong from Phong WHERE IDPhong = @ID ";
                Cmd = new SqlCommand(tamp, Cnn);
                Cmd.Parameters.Add(new SqlParameter("@ID",x));
                SqlDataReader dr = Cmd.ExecuteReader();
                bt = tmp(dr);


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        string bientam;
        private void Gribview_DSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                       
            bientam = this.Gribview_DSPhong.CurrentRow.Cells[4].Value.ToString();
            timtenphong(this.Gribview_DSPhong.CurrentRow.Cells[0].Value.ToString());
            if (bientam.Trim()=="Trống")
            {
                Datphong dp = new Datphong(bt, this.Gribview_DSPhong.CurrentRow.Cells[0].Value.ToString());
                dp.ShowDialog();
               
            }
            if (bientam.Trim() == "Đã Thuê")
            {
                ThanhToan tt = new ThanhToan(bt);
                tt.ShowDialog();
            }
            if (bientam.Trim() == "Bảo Trì")
            {
                MessageBox.Show("Phòng Đang Bảo Trì", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        
    }
}
