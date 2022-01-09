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
    public partial class frmShippers : Form
    {
        CrudAppDbContext dbContext = new CrudAppDbContext();

        public frmShippers()
        {
            InitializeComponent();
        }

        private void dgwShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            ID = (int)dgwShippers.Rows[e.RowIndex].Cells[0].Value;
            txtAdi.Text = (string)dgwShippers.Rows[e.RowIndex].Cells[1].Value;
        }

        int ID;
        private void frmShippers_Load(object sender, EventArgs e)
        {
            ShipperDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region eski
            //if (ID == 0) // insert
            //{
            //    Shippers ship = new Shippers();
            //    ship.Name = txtAdi.Text;

            //    dbContext.Nakliyeci.Add(ship);

            //    try
            //    {
            //        dbContext.SaveChanges();
            //        MessageBox.Show("İşlem başarılı");
            //        ShipperDoldur();
            //        Clear();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Bir Hata Var");
            //    }
            //}
            //else
            //{
            //    Shippers sip = dbContext.Nakliyeci.Find(ID);
            //    sip.Name = txtAdi.Text;

            //    try
            //    {
            //        dbContext.SaveChanges();
            //        MessageBox.Show("İşlem Başarılı");
            //        ShipperDoldur();
            //        Clear();
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}
            #endregion
            Shippers ship = dbContext.Nakliyeci.Find(ID);
            if (ship == null) // ship nesnesi nullsa yeni nesne oluştur...
            {
                ship = new Shippers();
            }

            ship.Name = txtAdi.Text;

            if (ID == 0)
            {
                dbContext.Nakliyeci.Add(ship);
            }
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                ShipperDoldur();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
            ID = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Silme işlemi için önce kayıt seç");
                return;
            }

            if (MessageBox.Show("Silmek istediğine eminmisin?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            {
                return;
            }


            Shippers sip = dbContext.Nakliyeci.Find(ID);
            dbContext.Nakliyeci.Remove(sip);

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("iŞLEM BAŞARILI");
                Clear();
                ShipperDoldur();
                ID = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("İşlem başarısız");
            }
        }
        
        void Clear()
        {
            //txtAdi.Text = "";
            txtAdi.Clear();
        }
        void ShipperDoldur()
        {
            dgwShippers.DataSource = dbContext.Nakliyeci.Select(c => new
            {
                c.ID,
                c.Name,
                c.CreDate
            }).ToList();
        }
    }
}
