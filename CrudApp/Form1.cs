using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori frm = new frmKategori();
            frm.Show();

        }

        private void btnNakliye_Click(object sender, EventArgs e)
        {
            frmShippers frm = new frmShippers();
            frm.Show();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            frmKullanici frm = new frmKullanici();
            frm.Show();
        }
    }
}