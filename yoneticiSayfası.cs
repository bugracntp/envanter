using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace e_envanter
{
    public partial class yoneticiSayfası : Form
    {
        private giris frm = new giris();
        private satisSayfasi frm2 = new satisSayfasi();
        private OleDbCommand komut;
        private OleDbDataReader dr;
        private bool panelkontrol, calisanMalzeme=true;
        public string[] comboBox = { "", "GIDA", "EV TEKSTİLİ", "EV DEKORASYONU", "TEMİZLİK ÜRÜNLERİ", "KOZMETİK", "ELEKTRONİK", "İNŞAAT MALZEMELERİ" };

        public yoneticiSayfası()
        {
            InitializeComponent();
        }

        private void yoneticiSayfası_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("iyi günler dileriz...");
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girişEkranınaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void yoneticiSayfası_Load(object sender, EventArgs e)
        {
            guncelPanel.Visible = false;
            eklemePanel.Visible = false;
            cGuncelPanel.Visible = false;
            cEklemePanel.Visible = false;
            saat.Interval = 1000;
            saat.Enabled = true;
            saatlbl.Text = DateTime.Now.ToString();
            lbl1.Text = "Envanter Tablosu";
            /*dropbox içerikleri*/
            {//ekleme
                bolumCmbox.Items.AddRange(comboBox);
                //güncelleme
                gBolumTxtb.Items.AddRange(comboBox);
            }
            {
            }
            lbl1.Visible = true;
            lbl2.Visible = false;
            satisBtn.Visible = true;
            listBtn.Visible = true;
            panelkontrol = true;
            calisanMalzeme = true;
            listView1.Show();
            listView2.Hide();
            guncelPanel.Hide();
            cGuncelPanel.Hide();
            eklemePanel.Hide();
            cEklemePanel.Hide();
            girisTarihiTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
            gTarihTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
            listeleme();
            sayimMethod();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
            lbl2.Text = "Çalışan Tablosu";
            lbl1.Visible = false;
            panelkontrol = true;
            calisanMalzeme = false;
            satisBtn.Visible = false;
            listBtn.Visible = false;
            listView2.Show();
            listView1.Hide();
            eklemePanel.Hide();
            cEklemePanel.Hide();
            guncelPanel.Hide();
            cGuncelPanel.Hide();
            listeleme();
        }

        private void envanterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl1.Text = "Envanter Tablosu";
            lbl2.Visible = false;
            panelkontrol = true;
            calisanMalzeme = true;
            satisBtn.Visible = true;
            listBtn.Visible = true;
            listView1.Show();
            listView2.Hide();
            cEklemePanel.Hide();
            cGuncelPanel.Hide();
            listeleme();
        }

        public void listeleme()
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            if (calisanMalzeme)
            {
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
            }
            else
            {
                listView2.Items.Clear();
                komut.CommandText = "Select * From calisanTablo";
                komut.Connection = frm.cnn;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lw = new ListViewItem(dr["id"].ToString());
                    lw.SubItems.Add(dr["ad"].ToString());
                    lw.SubItems.Add(dr["soyad"].ToString());
                    lw.SubItems.Add(dr["telefon"].ToString());
                    lw.SubItems.Add(dr["email"].ToString());
                    lw.SubItems.Add(dr["tc"].ToString());
                    lw.SubItems.Add(dr["adres"].ToString());
                    listView2.Items.Add(lw);
                }
                dr.Close();
            }
            sayimMethod();
            frm.cnn.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            panelkontrol = true;
            if (panelkontrol && calisanMalzeme)
            {//ekleme paneli açık
                guncelPanel.Visible = false;
                eklemePanel.Visible = true;
            }
            else if (panelkontrol && !calisanMalzeme)
            {//çalışan paneli açık
                cGuncelPanel.Visible = false;
                cEklemePanel.Visible = true;
                {
                    yetkiCmb.Items.Add("Yönetici");
                    yetkiCmb.Items.Add("Çalışan");
                }
                {
                    tcTxtb.MaxLength = 11;
                    tcTxtb.Mask = "00000000000";
                    gTelefonTxtb.MaxLength = 10;
                    gTelefonTxtb.Mask = "0000000000";
                    emailTxtb.MaxLength = 30;
                    kullanıcıAdTxtb.MaxLength = 12;
                    toolTip1.SetToolTip(this.tcTxtb, "T.C numaranız 11 karakter olmalıdır.");
                    toolTip1.SetToolTip(this.emailTxtb, "Örnek mail adresi 'exmple@exmple.com'.");
                    toolTip1.SetToolTip(this.gTelefonTxtb, "5xx xxx xxxx şeklinde giriniz.");
                    sifreTxtb.MaxLength = 10;
                    adTxtb.Mask = "LL?????????";
                    soyadTxt.Mask = "LL????????????";
                }
            }
        }

        private void gBtn_Click(object sender, EventArgs e) 
        {
            panelkontrol = false;
            if (!panelkontrol && calisanMalzeme)
            {//güncelleme açık
                guncelPanel.Visible = true;
                eklemePanel.Visible = false;
            }
            else if (!panelkontrol && !calisanMalzeme)
            {//eleman güncelleme açık
                cEklemePanel.Hide();
                cGuncelPanel.Show();
                cGuncelPanel.Visible = true;
                cEklemePanel.Visible = false;
                {
                    gTCTxtb.MaxLength = 11;
                    gTCTxtb.Mask = "00000000000";
                    cgtelefonTxt.MaxLength = 10;
                    gMailTxtb.MaxLength = 30;
                    kullanıcıAdTxtb.MaxLength = 12;
                    toolTip1.SetToolTip(this.gTCTxtb, "T.C numaranız 11 karakter olmalıdır.");
                    toolTip1.SetToolTip(this.emailTxtb, "Örnek mail adresi 'exmple@exmple.com'.");
                    toolTip1.SetToolTip(this.cgtelefonTxt, "5xx xxx xxxx şeklinde giriniz.");
                    gAdTxtb.Mask = "LL?????????";
                    gSoyadTxtb.Mask = "LL????????????";
                }
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            frm.cnn.Open();
            OleDbCommand komut = new OleDbCommand();
            if (panelkontrol && calisanMalzeme)//ekleme paneli işlemleri
            {
                try
                {
                    if (urunAdTxtb.Text != "" && markatxtb.Text != "" && adetTxtb.Text != "" && fiyatTxtb.Text != "" && girisTarihiTxtb.Text != "" && bolumCmbox.Text != "")
                    {
                        komut.CommandText = "INSERT INTO urunTablo(urunAd, marka , adet , fiyat , girisTarihi , depoBolum) VALUES (@urunAd, @marka , @adet , @fiyat , @girisTarihi , @depoBolum)";
                        komut.Connection = frm.cnn;
                        string urunAd = urunAdTxtb.Text, marka = markatxtb.Text, adet = adetTxtb.Text, fiyat = fiyatTxtb.Text, girisTarih = girisTarihiTxtb.Text, depoBolum = bolumCmbox.Text;
                        komut.Parameters.AddWithValue("@urunAd", urunAd);
                        komut.Parameters.AddWithValue("@marka", marka);
                        komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet));
                        komut.Parameters.AddWithValue("@fiyat", Convert.ToDouble(fiyat));
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
                    girisTarihiTxtb.Text = girisTarihiTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    bolumCmbox.Text = comboBox[0];
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!panelkontrol && calisanMalzeme)//güncelleme paneli işemleri
            {
                try
                {
                    int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    komut.CommandText = "UPDATE urunTablo SET urunAd = @urunAd, marka = @marka, adet = @adet, fiyat = @fiyat, girisTarihi = @girisTarihi, depoBolum =@depoBolum WHERE barkodNo = " + id;
                    komut.Connection = frm.cnn;
                    string urunAd = gUrunAdTxtb.Text, marka = gMarkaTxtb.Text, adet = gAdetTxtb.Text, fiyat = gFiyatTxtb.Text, girisTarih = gTarihTxtb.Text, depoBolum = gBolumTxtb.Text;
                    komut.Parameters.AddWithValue("@urunAd", urunAd);
                    komut.Parameters.AddWithValue("@marka", marka);
                    komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet));
                    komut.Parameters.AddWithValue("@fiyat", Convert.ToDouble(fiyat));
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
                gUrunAdTxtb.Text = "";
                gMarkaTxtb.Text = "";
                gAdetTxtb.Text = "";
                gFiyatTxtb.Text = "";
                gTarihTxtb.Text = DateTime.Now.ToString("dd / MM / yyyy");
                gBolumTxtb.Text = comboBox[0];
            }
            else if (panelkontrol && !calisanMalzeme)//çalışan ekleme işlemleri
            {
                try
                {
                    string ad = "", soyad = "", tc = "", telefon = "", email = "", adres = "", sifre = "", yetki = "", kullaniciAd = "";
                    if (adTxtb.Text != "" && soyadTxt.Text != "" && tcTxtb.Text != "" && gTelefonTxtb.Text != "" && emailTxtb.Text != "" && adresTxtb.Text != "")
                    {
                        bool arananKayitKontrol = false;
                        for (int i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].SubItems[3].Text == tcTxtb.Text)
                            {
                                arananKayitKontrol = true;
                                MessageBox.Show(tcTxtb.Text + " T.C kimlik numarası zaten mevcut");
                            }
                            else if (listView2.Items[i].SubItems[4].Text == gTelefonTxtb.Text)
                            {
                                arananKayitKontrol = true;
                                MessageBox.Show(gTelefonTxtb.Text + " telefon numarası zaten mevcut");
                            }
                            else if (listView2.Items[i].SubItems[5].Text == emailTxtb.Text)
                            {
                                arananKayitKontrol = true;
                                MessageBox.Show(emailTxtb.Text + " mail aderesi zaten mevcut");
                            }
                        }
                        if (!arananKayitKontrol)
                        {
                            ad = adTxtb.Text; soyad = soyadTxt.Text; tc = tcTxtb.Text; telefon = gTelefonTxtb.Text; email = emailTxtb.Text; adres = adresTxtb.Text; sifre = sifreTxtb.Text; yetki = yetkiCmb.Text; kullaniciAd = kullanıcıAdTxtb.Text;
                            komut.CommandText = "INSERT INTO calisanTablo(ad, soyad , tc , telefon , email , adres,sifre,yetki,kullaniciAd) VALUES (@ad, @soyad , @tc , @telefon , @email , @adres,@sifre,@yetki,@kullaniciAd)";
                            komut.Connection = frm.cnn;
                            if (tcTxtb.TextLength == 11)
                            {
                                if (gTelefonTxtb.TextLength == 10)
                                {
                                    if (emailTxtb.TextLength < 30 && emailTxtb.TextLength >= 6)
                                    {
                                        komut.Parameters.AddWithValue("@ad", ad);
                                        komut.Parameters.AddWithValue("@soyad", soyad);
                                        komut.Parameters.AddWithValue("@tc", Convert.ToInt64(tc));
                                        komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(telefon));
                                        komut.Parameters.AddWithValue("@email", email);
                                        komut.Parameters.AddWithValue("@adres", adres);
                                        komut.Parameters.AddWithValue("@sifre", sifre);
                                        komut.Parameters.AddWithValue("@yetki", yetki);
                                        komut.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                                        MessageBox.Show("kayıt başarılı");
                                        komut.ExecuteNonQuery();
                                        frm.cnn.Close();
                                        listeleme();
                                    }
                                    else
                                        MessageBox.Show("mail adresinizi 'example@example.com' şeklinde giriniz.");
                                }
                                else
                                    MessageBox.Show("telefon numaranızı '5xx xxx xxxx' şeklinde giriniz.");
                            }
                            else
                                MessageBox.Show("tc kimlik numaranız 11 haneli olmalıdır.");
                        }
                    }
                    else
                        MessageBox.Show("lütfen boş alan bırakmayınız");
                    adTxtb.Text = "";
                    soyadTxt.Text = "";
                    tcTxtb.Text = "";
                    gTelefonTxtb.Text = "";
                    emailTxtb.Text = "";
                    adresTxtb.Text = "";
                    sifreTxtb.Text = "";
                    kullanıcıAdTxtb.Text = "";
                    yetkiCmb.Text = comboBox[0];
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!panelkontrol && !calisanMalzeme)//çalışan güncelleme işlemleri
            {
                int secim = calisanMalzeme ? listView1.SelectedItems.Count : listView2.SelectedItems.Count;
                if (secim == 0)
                    MessageBox.Show("lütfen en az bir öğe seçiniz.");
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                        komut.CommandText = "UPDATE calisanTablo SET ad = @ad, soyad = @soyad, tc = @tc, telefon = @telefon, email = @email, adres = @adres WHERE id = " + id;
                        komut.Connection = frm.cnn;
                        string ad = gAdTxtb.Text, soyad = gSoyadTxtb.Text, tc = gTCTxtb.Text, telefon = cgtelefonTxt.Text, email = gMailTxtb.Text, adres = gAdresTxtb.Text;
                        if (gTCTxtb.TextLength == 11)
                        {
                            if (cgtelefonTxt.TextLength == 10)
                            {
                                if (gMailTxtb.TextLength < 30 && gMailTxtb.TextLength >= 6)
                                {
                                    komut.Parameters.AddWithValue("@ad", ad);
                                    komut.Parameters.AddWithValue("@soyad", soyad);
                                    komut.Parameters.AddWithValue("@tc", Convert.ToInt64(tc));
                                    komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(telefon));
                                    komut.Parameters.AddWithValue("@email", email);
                                    komut.Parameters.AddWithValue("@adres", adres);
                                    MessageBox.Show("kayıt başarılı");
                                    komut.ExecuteNonQuery();
                                    frm.cnn.Close();
                                    listeleme();
                                }
                                else
                                    MessageBox.Show("mail adresinizi 'example@example.com' şeklinde giriniz.");
                            }
                            else
                                MessageBox.Show("telefon numaranızı '5xx xxx xxxx' şeklinde giriniz.");
                        }
                        else
                            MessageBox.Show("tc kimlik numaranız 11 haneli olmalıdır.");
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Envanter takip programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                gAdTxtb.Text = "";
                gSoyadTxtb.Text = "";
                gTCTxtb.Text = "";
                cgtelefonTxt.Text = "";
                gMailTxtb.Text = "";
                gAdresTxtb.Text = "";
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            if (panelkontrol && calisanMalzeme)
            {//ekleme paneli kapalı
                eklemePanel.Hide();
            }
            else if (panelkontrol && !calisanMalzeme)
            {//çalışan paneli kapalı
                cEklemePanel.Hide();
            }
            else if (!panelkontrol && calisanMalzeme)
            {//güncelleme kapalı
                guncelPanel.Hide();
            }
            else if (!panelkontrol && !calisanMalzeme)
            {//eleman güncelleme kapalı
                cGuncelPanel.Hide();
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            if (panelkontrol && calisanMalzeme)
            {//ekleme paneli
                urunAdTxtb.Text = "";
                markatxtb.Text = "";
                adetTxtb.Text = "";
                fiyatTxtb.Text = "";
                girisTarihiTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                bolumCmbox.Text = comboBox[0];
            }
            else if (panelkontrol && !calisanMalzeme)
            {//çalışan ekleme paneli
                adTxtb.Text = "";
                soyadTxt.Text = "";
                tcTxtb.Text = "";
                gTelefonTxtb.Text = "";
                emailTxtb.Text = "";
                adresTxtb.Text = "";
            }
            else if (!panelkontrol && calisanMalzeme)
            {//ürün güncelleme paneli
                gUrunAdTxtb.Text = "";
                gMarkaTxtb.Text = "";
                gAdetTxtb.Text = "";
                gFiyatTxtb.Text = "";
                gTarihTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                gBolumTxtb.Text = comboBox[0];
            }
            else if (!panelkontrol && !calisanMalzeme)
            {//çalışan güncelleme paneli
                gAdTxtb.Text = "";
                gSoyadTxtb.Text = "";
                gTCTxtb.Text = "";
                gTelefonTxtb.Text = "";
                gMailTxtb.Text = "";
                gAdresTxtb.Text = "";
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            frm.cnn.Open();
            int secim = calisanMalzeme ? listView1.SelectedItems.Count : listView2.SelectedItems.Count;
            if (secim == 0)
                MessageBox.Show("lütfen en az bir öğe seçiniz.");
            else
            {
                if (calisanMalzeme)
                {
                    int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    komut.CommandText = "DELETE FROM urunTablo WHERE barkodNo=" + id;
                    MessageBox.Show("silindi");
                    komut.ExecuteNonQuery();
                }
                else if (!calisanMalzeme)
                {
                    int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                    komut.CommandText = "DELETE FROM calisanTablo WHERE id=" + id;
                    MessageBox.Show("silindi");
                    komut.ExecuteNonQuery();
                }
            }
            frm.cnn.Close();
            listeleme();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calisanMalzeme)
            {
                foreach (var item in listView1.SelectedItems)
                {
                    gUrunAdTxtb.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    gMarkaTxtb.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    gAdetTxtb.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    gFiyatTxtb.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    gTarihTxtb.Text = girisTarihiTxtb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    gBolumTxtb.Text = listView1.SelectedItems[0].SubItems[6].Text;
                }
            }
            else if (!calisanMalzeme)
            {
                foreach (var item in listView2.SelectedItems)
                {
                    gAdTxtb.Text = listView2.SelectedItems[0].SubItems[1].Text;
                    gSoyadTxtb.Text = listView2.SelectedItems[0].SubItems[2].Text;
                    gTCTxtb.Text = listView2.SelectedItems[0].SubItems[5].Text;
                    cgtelefonTxt.Text = listView2.SelectedItems[0].SubItems[3].Text;
                    gMailTxtb.Text = listView2.SelectedItems[0].SubItems[4].Text;
                    gAdresTxtb.Text = listView2.SelectedItems[0].SubItems[6].Text;
                }
            }
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            satisList sl = new satisList();
            sl.Show();
        }

        private void sifreTxtb_TextChanged(object sender, EventArgs e)
        {
            if (sifreTxtb.Text.Length < 6)
                errorProvider1.SetError(sifreTxtb, "Şifreniz 6 karakterden uzun olmalıdır");
            else
                errorProvider1.Clear();
        }

        private void kullanıcıAdTxtb_TextChanged(object sender, EventArgs e)
        {
            if (kullanıcıAdTxtb.Text.Length < 6)
                errorProvider2.SetError(kullanıcıAdTxtb, "kullanıcı adınız 6 karakterden uzun olmalıdır");
            else
                errorProvider2.Clear();
        }

        private void tcTxtb_TextChanged(object sender, EventArgs e)
        {
            if (tcTxtb.Text.Length < 11)
                errorProvider1.SetError(tcTxtb, "T.C niz 11 karakter olmalıdır");
            else
                errorProvider1.Clear();
        }

        private void gTCTxtb_TextChanged(object sender, EventArgs e)
        {
            if (gTCTxtb.Text.Length < 11)
                errorProvider4.SetError(gTCTxtb, "T.C niz 11 karakter olmalıdır");
            else
                errorProvider4.Clear();
        }

        private void tcTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 58) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void adTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void gFiyatTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 58) || (int)e.KeyChar == 8|| (int)e.KeyChar == 44)
                e.Handled = false;
            else
                e.Handled = true;

            toolTip1.SetToolTip(this.gFiyatTxtb, "küsüratlı miktarlarda ',' kullanınız.");
            toolTip1.SetToolTip(this.fiyatTxtb, "küsüratlı miktarlarda ',' kullanınız.");
        }

        private void sayimMethod()
        {
            if (calisanMalzeme)
            {
                int urunSayısı = listView1.Items.Count;
                sayimLbl.Text = "Ürün Sayısı : " + Convert.ToString(urunSayısı);
            }
            else
            {
                int calisanSayisi = listView2.Items.Count;
                sayimLbl.Text = "Ürün Sayısı : " + Convert.ToString(calisanSayisi);
            }
        }
    }
}