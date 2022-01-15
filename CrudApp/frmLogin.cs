using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrudApp.Models;
//using CrudApp.Repository;

namespace CrudApp
{
    // proje içerisindeki namespaceleri bu bölüme bu şekilde yazabiliriz...
    using Models;
    using Repository;
    public partial class frmLogin : Form
    {
        UserRepository repository = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text)) // string null mı ? veya space kararkter var mı??
            {
                lblValidateKullaniciAdi.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                lblValidateSifre.Visible = true;
                return;
            }


            User user = repository.findByUserName(txtKullaniciAdi.Text);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                return;
            }

            if (user.IsLock)
            {
                if (user.LockDate > DateTime.Now)
                {
                    MessageBox.Show($"Hesabınız { user.LockDate.Value.ToShortTimeString() } kadar bloke oldu...");
                    return;
                }

                repository.RemoveBloke();
            }

            if (txtSifre.Text == user.Password) // şifreler eşleşirse..
            {
                MessageBox.Show("Hoşgeldiniz.. Ana Forma yönlendiriliyorsunuz....");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();// login formu gizle
            }
            else
            {
                if (hak == 3)
                {

                    user.LockDate = DateTime.Now.AddMinutes(5); // şimdiki zamana 5 dakika ekle...
                    user.IsLock = true;
                    repository.Update(user);

                    MessageBox.Show($"Hesabınız { user.LockDate.Value.ToShortTimeString() } kadar bloke oldu...");
                }
                else
                {
                    MessageBox.Show($"Hatalı şifre. Kalan hakkınız {3 - (hak++)}");
                }
            }
        }

        int hak = 0;

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                lblValidateKullaniciAdi.Visible = true;
            }
            else
            {
                lblValidateKullaniciAdi.Visible = false;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                lblValidateSifre.Visible = true;
            }
            else
            {
                lblValidateSifre.Visible = false;
            }
        }
    }
}
