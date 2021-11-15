using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace e_envanter
{
    public partial class satisSayfasi : Form
    {
        private satisList sl = new satisList();
        private giris frm = new giris();
        private OleDbCommand komut;
        private OleDbDataReader dr;
        private int eAdet, yAdet;
        public int barkodNo = 0;
        private string ad;
        private string mrka;
        private DateTime tarih;
        public int veri, veriBarkod;


        public satisSayfasi()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            yoneticiSayfası ys = new yoneticiSayfası();
            calisanSayfasi cs = new calisanSayfasi();
            ys.listeleme();
            cs.listeleme();
            this.Hide();
        }

        private void listeleme()
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            listView1.Items.Clear();
            komut.CommandText = "Select * From urunTablo";
            komut.Connection = frm.cnn;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lw = new ListViewItem(dr["barkodNo"].ToString());
                lw.SubItems.Add(dr["urunAd"].ToString());
                lw.SubItems.Add(dr["marka"].ToString());
                lw.SubItems.Add(dr["adet"].ToString());
                lw.SubItems.Add(dr["fiyat"].ToString());
                lw.SubItems.Add(dr["girisTarihi"].ToString());
                lw.SubItems.Add(dr["depoBolum"].ToString());
                listView1.Items.Add(lw);
            }
            dr.Close();
            frm.cnn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeleme();
            saat.Interval = 1000;
            saat.Enabled = true;
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView1.SelectedItems)
            {
                barkodNo = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                ad = listView1.SelectedItems[0].SubItems[1].Text;
                mrka = listView1.SelectedItems[0].SubItems[2].Text;
                eAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                fiyatTxtb.Text = listView1.SelectedItems[0].SubItems[4].Text;
                tarih = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[5].Text);
            }
            arama();
        }

        private void guncelle()
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            try
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                komut.CommandText = "UPDATE urunTablo SET adet = @adet WHERE barkodNo = " + id;
                komut.Connection = frm.cnn;
                int gAdet = Convert.ToInt32(miktarTxtb.Text);
                yAdet = eAdet - gAdet;
                komut.Parameters.AddWithValue("@adet", Convert.ToInt32(yAdet));
                komut.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm.cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satisList sl = new satisList();
            this.Hide();
            sl.Show();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            arama();
            frm.cnn.Open();
            int gAdet = Convert.ToInt32(miktarTxtb.Text);
            if (veriBarkod == barkodNo)
            {
                MessageBox.Show("güncelleme");
                gAdet = gAdet + veri;
                komut.CommandText = "UPDATE satisTablo SET satisMiktari = @satisMiktari WHERE barkodNo = " + barkodNo;
                komut.Parameters.AddWithValue("@satisMiktari", Convert.ToInt32(gAdet));
                komut.ExecuteNonQuery();
            }
            else
            {
                komut = new OleDbCommand();
                try
                {
                    komut.CommandText = "INSERT INTO satisTablo(barkodNo,urunAd,marka,satisMiktari,fiyat,girisTarihi,satisTarihi) VALUES (@barkodNo,@urunAd,@marka, @satisMiktari, @fiyat, @girisTarihi,@satisTarihi)";
                    komut.Connection = frm.cnn;
                    double fiyat = Convert.ToDouble(fiyatTxtb.Text);
                    string sTarih = DateTime.Now.ToString("dd/MM/yyyy");
                    komut.Parameters.AddWithValue("@barkodNo", Convert.ToInt32(barkodNo));
                    komut.Parameters.AddWithValue("@urunAd", ad);
                    komut.Parameters.AddWithValue("@marka", mrka);
                    komut.Parameters.AddWithValue("@satisMiktari", Convert.ToInt32(gAdet));
                    komut.Parameters.AddWithValue("@fiyat", Convert.ToDouble(fiyat));
                    komut.Parameters.AddWithValue("@girisTarihi", tarih);
                    komut.Parameters.AddWithValue("@satisTarihi", sTarih);
                    MessageBox.Show("Satış işlemi başarılı");
                    komut.ExecuteNonQuery();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frm.cnn.Close();
            guncelle();
            adetSifir();
            listeleme();
        }

        private void fiyatTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 58) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44)
                e.Handled = false;
            else
                e.Handled = true;

            toolTip1.SetToolTip(this.fiyatTxtb , "küsüratlı miktarlarda ',' kullanınız.");
        }

        private void adetSifir()
        {
            frm.cnn.Open();
            foreach (var item in listView1.SelectedItems)
                eAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            if (yAdet == 0)
            {
                DialogResult secenek = MessageBox.Show("Adet sayınız 0'a ulaştı ürünü silmek ister misiniz?", "bilgilendirme penceresi", MessageBoxButtons.YesNo);
                if (secenek == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    komut.CommandText = "DELETE FROM urunTablo WHERE barkodNo=" + id;
                    MessageBox.Show("silindi");
                    komut.ExecuteNonQuery();
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Yakın Zamanda Tedarik ediniz.");
                }
            }
            frm.cnn.Close();
        }
        public void arama()
        {
            frm.cnn.Open();
            komut = new OleDbCommand("SELECT barkodNo,satisMiktari FROM satisTablo", frm.cnn);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["barkodNo"]) == barkodNo)
                {
                    veriBarkod = Convert.ToInt32(dr["barkodNo"]);
                    veri = Convert.ToInt32(dr["satisMiktari"]);
                    break;
                }
            }
            frm.cnn.Close();
        }
    }
}