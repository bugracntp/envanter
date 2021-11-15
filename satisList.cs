using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace e_envanter
{
    public partial class satisList : Form
    {
        OleDbCommand komut;
        OleDbDataReader dr;
        giris frm = new giris();
        public satisList()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void satişList_Load(object sender, EventArgs e)
        {
            listeleme();
            saat.Interval = 1000;
            saat.Enabled = true;
            saatlbl.Text = DateTime.Now.ToString();
        }
        private void listeleme()
        {
            frm.cnn.Open();
            komut = new OleDbCommand();
            listView1.Items.Clear();
            komut.CommandText = "Select * From satisTablo";
            komut.Connection = frm.cnn;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lw = new ListViewItem(dr["barkodNo"].ToString());
                lw.SubItems.Add(dr["urunAd"].ToString());
                lw.SubItems.Add(dr["marka"].ToString());
                lw.SubItems.Add(dr["satisMiktari"].ToString());
                lw.SubItems.Add(dr["fiyat"].ToString());
                lw.SubItems.Add(dr["girisTarihi"].ToString());
                lw.SubItems.Add(dr["satisTarihi"].ToString());
                listView1.Items.Add(lw);
            }
            frm.cnn.Close();
        }
       

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }
    }
}
