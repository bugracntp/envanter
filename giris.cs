using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace e_envanter
{
    public partial class giris : Form
    {
        public OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e-envanter.mdb");

        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
            saat.Interval = 1000;
            saat.Enabled = true;
            this.AcceptButton = girisBtn;
            sifreG.PasswordChar = '*';
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            cnn.Open();
            bool giris=false;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM calisanTablo", cnn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (yoneticiCheck.Checked == true)
                {
                    if (reader["kullaniciAd"].ToString() == kullanici_AdG.Text && reader["sifre"].ToString() == sifreG.Text && reader["yetki"].ToString() == "Yönetici")
                    {
                        yoneticiSayfası ys = new yoneticiSayfası();
                        this.Hide();
                        ys.Show();
                        giris = true;
                        break;
                    }
                    
                }
                else if (calisanCheck.Checked == true)
                {
                    if (reader["kullaniciAd"].ToString() == kullanici_AdG.Text && reader["sifre"].ToString() == sifreG.Text && reader["yetki"].ToString() == "Çalışan")
                    {
                        calisanSayfasi cs = new calisanSayfasi();
                        this.Hide();
                        cs.Show();
                        giris = true;
                        break;
                    }
                }
                else
                {
                    giris = false;
                    break;
                }
            }
            if (!giris)
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            cnn.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gösterChckb.Checked)
            {
                //karakteri göster.
                sifreG.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifreG.PasswordChar = '*';
            }
        }
    }
}