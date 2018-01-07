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
            string sql = "select IDphong as [Mã Phòng], TenPhong as [Tên Phòng], sogiuong [Số Giường], Loaiphong as [Loại Phòng], Tentrangthai as [Trạng Thái] From Phong P INNER JOIN TrangThai T On P.IDTrangthai=T.IDTrangthai ORDER BY IDPhong ASC";
            Cmd = new SqlCommand(sql, Cnn);
            SqlDataAdapter alap = new SqlDataAdapter(Cmd);
            DataTable Table = new DataTable();
            alap.Fill(Table);
            Gribview_DSPhong.DataSource = Table;
        }

       

        private void btTimPhong_Click(object sender, EventArgs e)
        {
            //Timphong(tbtimphong.Text);
        }
    }
}
