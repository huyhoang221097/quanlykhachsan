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
