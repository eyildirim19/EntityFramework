using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudApp.Models;
using CrudApp.Repository;


namespace CrudApp
{
    public partial class frmKullanici : Form
    {
        UserRepository repository = new UserRepository();
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void dgwKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            ID = (int)dgwKullanici.Rows[e.RowIndex].Cells[0].Value;
            txtKullaniciAdi.Text = (string)dgwKullanici.Rows[e.RowIndex].Cells[1].Value;
            txtSifre.Text = (string)dgwKullanici.Rows[e.RowIndex].Cells[2].Value;
            cbAktifmi.Checked = (bool)dgwKullanici.Rows[e.RowIndex].Cells[4].Value;
        }

        int ID;

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            User user = repository.FindById(ID);
            if (user == null)
                user = new User();

            user.Name = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;

            int result = 0;
            if (ID == 0)
                result = repository.Create(user);
            else
                result = repository.Update(user);

            if (result > 0)
                MessageBox.Show("İşlem Başarılı");
            else
                MessageBox.Show("İşlem Başarısız");

            Doldur();
            Clear();
        }
        void Clear()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            cbAktifmi.Checked = false;
            ID = 0;
        }
        void Doldur()
        {
            dgwKullanici.DataSource = repository.List().Select(c => new
            {
                c.ID,
                c.Name,
                c.Password,
                c.CreDate,
                c.IsLock,
                c.LockDate
            }).ToList();
        }

        // todo : Ödev  : Customer modülü yapılacak. Compnayname,ContactTitle,ContactPhone,ID alanlarına göre sınıf oluşturulup, crud operasyonları repository pattern ile yapılacak......
    }
}