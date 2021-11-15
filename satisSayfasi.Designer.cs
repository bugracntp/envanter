
namespace e_envanter
{
    partial class satisSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisSayfasi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.miktarTxtb = new System.Windows.Forms.TextBox();
            this.fiyatTxtb = new System.Windows.Forms.TextBox();
            this.onayla = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ıd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.girisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depoBolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.geri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.saatlbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış Fiyatı";
            // 
            // miktarTxtb
            // 
            this.miktarTxtb.Location = new System.Drawing.Point(145, 76);
            this.miktarTxtb.Name = "miktarTxtb";
            this.miktarTxtb.Size = new System.Drawing.Size(100, 22);
            this.miktarTxtb.TabIndex = 2;
            // 
            // fiyatTxtb
            // 
            this.fiyatTxtb.Location = new System.Drawing.Point(145, 123);
            this.fiyatTxtb.Name = "fiyatTxtb";
            this.fiyatTxtb.Size = new System.Drawing.Size(100, 22);
            this.fiyatTxtb.TabIndex = 3;
            this.fiyatTxtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyatTxtb_KeyPress);
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(289, 57);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(75, 41);
            this.onayla.TabIndex = 4;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ıd,
            this.urunAd,
            this.marka,
            this.adet,
            this.fiyat,
            this.girisTarih,
            this.depoBolum});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1258, 335);
            this.listView1.TabIndex = 5;
            this.listView1.TileSize = new System.Drawing.Size(250, 40);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ıd
            // 
            this.ıd.Text = "barkodNo";
            this.ıd.Width = 120;
            // 
            // urunAd
            // 
            this.urunAd.Text = "Ürün Adı";
            this.urunAd.Width = 150;
            // 
            // marka
            // 
            this.marka.Text = "Marka";
            this.marka.Width = 150;
            // 
            // adet
            // 
            this.adet.Text = "Adet";
            this.adet.Width = 150;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Fiyat";
            this.fiyat.Width = 150;
            // 
            // girisTarih
            // 
            this.girisTarih.Text = "Giriş tarihi";
            this.girisTarih.Width = 120;
            // 
            // depoBolum
            // 
            this.depoBolum.Text = "Depo Bölüm";
            this.depoBolum.Width = 150;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(289, 123);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 41);
            this.geri.TabIndex = 6;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1099, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Satış Miktarını Gör";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // saatlbl
            // 
            this.saatlbl.AutoSize = true;
            this.saatlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.Location = new System.Drawing.Point(12, 9);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(71, 22);
            this.saatlbl.TabIndex = 37;
            this.saatlbl.Text = "label30";
            // 
            // satisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 558);
            this.ControlBox = false;
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.fiyatTxtb);
            this.Controls.Add(this.miktarTxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "satisSayfasi";
            this.Text = "e-envanter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox miktarTxtb;
        private System.Windows.Forms.TextBox fiyatTxtb;
        private System.Windows.Forms.Button onayla;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ıd;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader marka;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader girisTarih;
        private System.Windows.Forms.ColumnHeader depoBolum;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}