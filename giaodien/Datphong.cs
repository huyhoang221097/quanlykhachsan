using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan.giaodien
{
    public partial class Datphong : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboxLoaiTg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLoaiTg.SelectedItem.ToString() == "Giờ")
            {
                MessageBox.Show("Giờ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (cboxLoaiTg.SelectedItem.ToString() == "Ngày")
            {
                MessageBox.Show("Ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
