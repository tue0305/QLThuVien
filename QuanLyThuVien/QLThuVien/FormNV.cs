using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;

            userBUS.Instance.getNhanViens(dgvNhanVien);

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;

        }

        private void btTroVe_Click(object sender, EventArgs e)
        {

        }
    }
}
