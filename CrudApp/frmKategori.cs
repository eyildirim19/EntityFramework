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

namespace CrudApp
{
    public partial class frmKategori : Form
    {
        // Başka bir namespaceden sınıf instance alınacaksa, o sınıfın namespacesi using bölümene eklenmelidir.

        CrudAppDbContext dbContext = new CrudAppDbContext();

        public frmKategori()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Name = txtKategoriAdi.Text;
            c.Description = txtAciklama.Text;

            dbContext.Kategori.Add(c);

            try
            {
                dbContext.SaveChanges(); // değişikliği veritabanına yansıt....
                MessageBox.Show("Tebrikler. \nKategori ekleme işlemi başarılı"); //\n alt satıra geç..
                Clear();

                KategoriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu...");
            }
        }

        void Clear()
        {
            txtAciklama.Text = "";
            txtKategoriAdi.Text = "";
        }

        void KategoriDoldur()
        {
            //List<Categories> katList = dbContext.Kategori.ToList();
            //dgwKategoriler.DataSource = katList;

            // bir linq komutu olan select'i kullandık...koleksiyon nesneleri içerisinden property (ler) seçmek için kullanılır.. EĞer select içerisinde new ifadesi kulalnılıyorsa kümenin dönüş tipi anonimdir. anonim tipler (var) 

            var katList2 = dbContext.Kategori.Select(c => new
            {
                c.ID,
                c.Name,
                c.Description,
                c.CreDate
            }).ToList();


            dgwKategoriler.DataSource = katList2;
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }
    }
}
