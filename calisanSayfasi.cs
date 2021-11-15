using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace e_envanter
{
    public partial class calisanSayfasi : Form
    {
        private giris frm = new giris();
        satisList ls = new satisList();
        private satisSayfasi frm2 = new satisSayfasi();
        private yoneticiSayfası ys = new yoneticiSayfası();
        private OleDbCommand komut;
        private OleDbDataReader dr;
        private bool panelKontrol;

        public calisanSayfasi()
        {
            InitializeComponent();
        }

        private void calisanSayfasi_Load(object sender, EventArgs e)
        {
            girisTarihiTxtb.Text = DateTime.Now.ToString("MM / dd / yyyy");
            gGirisTarihTxtb.Text = DateTime.Now.ToString("MM / dd / yyyy");
            /*dropbox içerikleri */
            {
                depoBolumuTxtb.Items.AddRange(ys.comboBox);
                //güncelleme
                gDepoBolumTxtb.Items.AddRange(ys.comboBox);
            }
            listeleme();
            saatlbl.Text = DateTime.Now.ToString();
            saat.Interval = 1000;
            saat.Enabled = true;
            panelKontrol = true;
            eklemePanel.Hide();
            guncelPanel.Hide();
        }

        public void listeleme()
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
            sayimMethod();
        }

        private void calisanSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void girişSayfasınaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*panel kodları başlangıç*/

        private void ekle_Click(object sender, EventArgs e)
        {
            panelKontrol = true;
            if (panelKontrol)
            {
                eklemePanel.Show();
                guncelPanel.Hide();
            }
        }

        private void guncelBtn_Click(object sender, EventArgs e)
        {
            panelKontrol = false;
            if (!panelKontrol)
            {
                guncelPanel.Show();
                eklemePanel.Hide();
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            yoneticiSayfası ys = new yoneticiSayfası();
            if (panelKontrol)//ekleme paneli işlemleri
            {
                try
                {
                    string  urunAd = "", marka = "", adet = "", fiyat = "", girisTarih = "", depoBolum = "";
                    if (urunAdTxtb.Text != "" && markatxtb.Text != "" && adetTxtb.Text != "" && fiyatTxtb.Text != "" && girisTarihiTxtb.Text != "" && depoBolumuTxtb.Text != "")
                    {
                        komut.CommandText = "INSERT INTO urunTablo(urunAd, marka , adet , fiyat , girisTarihi , depoBolum) VALUES (@urunAd, @marka , @adet , @fiyat , @girisTarihi , @depoBolum)";
                        komut.Connection = frm.cnn;
                        urunAd = urunAdTxtb.Text; marka = markatxtb.Text; adet = adetTxtb.Text; fiyat = fiyatTxtb.Text; girisTarih = girisTarihiTxtb.Text; depoBolum = depoBolumuTxtb.Text;
                        komut.Parameters.AddWithValue("@urunAd", urunAd);
                        komut.Parameters.AddWithValue("@marka", marka);
                        komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet));
                        komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat));
                        komut.Parameters.AddWithValue("@girisTarihi", Convert.ToDateTime(girisTarih));
                        komut.Parameters.AddWithValue("@depoBolumu", depoBolum);
                        MessageBox.Show("kayıt başarılı");
                        komut.ExecuteNonQuery();
                        frm.cnn.Close();
                        listeleme();
                    }
                    else
                        MessageBox.Show("lütfen boş alan bırakmayınız");
                    urunAdTxtb.Text = "";
                    markatxtb.Text = "";
                    adetTxtb.Text = "";
                    fiyatTxtb.Text = "";
                    girisTarihiTxtb.Text = girisTarihiTxtb.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    depoBolumuTxtb.Text = "";
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!panelKontrol)//güncelleme paneli işemleri
            {
                if (listView1.SelectedItems.Count == 0)
                    MessageBox.Show("lütfen en az bir öğe seçiniz.");
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                        komut.CommandText = "UPDATE urunTablo SET urunAd = @urunAd, marka = @marka, adet = @adet, fiyat = @fiyat, girisTarihi = @girisTarihi, depoBolum =@depoBolum WHERE barkodNo = " + id;
                        komut.Connection = frm.cnn;
                        string urunAd = gUrunTxtb.Text, marka = gMarkaTxtb.Text, adet = gAdetTxtb.Text, fiyat = gFiyatTxtb.Text, girisTarih = gGirisTarihTxtb.Text, depoBolum = gDepoBolumTxtb.Text;
                        komut.Parameters.AddWithValue("@urunAd", urunAd);
                        komut.Parameters.AddWithValue("@marka", marka);
                        komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet));
                        komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat));
                        komut.Parameters.AddWithValue("@girisTarihi", Convert.ToDateTime(girisTarih));
                        komut.Parameters.AddWithValue("@depoBolumu", depoBolum);
                        MessageBox.Show("kayıt başarılı");
                        komut.ExecuteNonQuery();
                        frm.cnn.Close();
                        listeleme();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                gUrunTxtb.Text = "";
                gMarkaTxtb.Text = "";
                gAdetTxtb.Text = "";
                gFiyatTxtb.Text = "";
                gGirisTarihTxtb.Text = girisTarihiTxtb.Text = DateTime.Now.ToString("MM/dd/yyyy");
                gDepoBolumTxtb.Text = "";
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            if (panelKontrol)
                eklemePanel.Hide();
            else if (!panelKontrol)
                guncelPanel.Hide();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            if (panelKontrol)
            {
                urunAdTxtb.Text = "";
                markatxtb.Text = "";
                adetTxtb.Text = "";
                fiyatTxtb.Text = "";
                girisTarihiTxtb.Text = "";
                depoBolumuTxtb.Text = "";
            }
            else
            {
                gUrunTxtb.Text = "";
                gMarkaTxtb.Text = "";
                gAdetTxtb.Text = "";
                gFiyatTxtb.Text = "";
                gGirisTarihTxtb.Text = "";
                gDepoBolumTxtb.Text = "";
            }
        }

        /*son*/

        private void sayimMethod()
        {
            int urunSayısı = listView1.Items.Count;
            sayimlbl.Text = "Ürün Sayısı : " + Convert.ToString(urunSayısı);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            komut.Connection = frm.cnn;
            if (listView1.SelectedItems.Count == 0)
                MessageBox.Show("en az bir öğe seçiniz");
            else
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                komut.CommandText = "DELETE FROM urunTablo WHERE barkodNo=" + id;
                MessageBox.Show("silindi");
                komut.ExecuteNonQuery();
                frm.cnn.Close();
                listeleme();
            }
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView1.SelectedItems)
            {
                gUrunTxtb.Text = listView1.SelectedItems[0].SubItems[1].Text;
                gMarkaTxtb.Text = listView1.SelectedItems[0].SubItems[2].Text;
                gAdetTxtb.Text = listView1.SelectedItems[0].SubItems[3].Text;
                gFiyatTxtb.Text = listView1.SelectedItems[0].SubItems[4].Text;
                gGirisTarihTxtb.Text = girisTarihiTxtb.Text = DateTime.Now.ToString("MM/dd/yyyy");
                gDepoBolumTxtb.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            ls.Show();
        }
        private void sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 58) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44)
                    e.Handled = false;
                else
                    e.Handled = true;

                toolTip1.SetToolTip(this.fiyatTxtb, "küsüratlı miktarlarda ',' kullanınız.");
        }

        private void yazi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}