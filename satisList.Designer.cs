
namespace e_envanter
{
    partial class satisList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisList));
            this.listView1 = new System.Windows.Forms.ListView();
            this.barkodNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satisMiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.girisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.geriBtn = new System.Windows.Forms.Button();
            this.saatlbl = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.barkodNo,
            this.urunAd,
            this.marka,
            this.satisMiktar,
            this.fiyat,
            this.girisTarihi,
            this.satisTarihi});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1358, 469);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // barkodNo
            // 
            this.barkodNo.Text = "barkod no";
            this.barkodNo.Width = 80;
            // 
            // urunAd
            // 
            this.urunAd.Text = "Ürün adı";
            this.urunAd.Width = 140;
            // 
            // marka
            // 
            this.marka.Text = "Marka";
            this.marka.Width = 140;
            // 
            // satisMiktar
            // 
            this.satisMiktar.Text = "Satış Miktarı";
            this.satisMiktar.Width = 130;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Fiyat";
            this.fiyat.Width = 130;
            // 
            // girisTarihi
            // 
            this.girisTarihi.Text = "Giriş Tarihi";
            this.girisTarihi.Width = 110;
            // 
            // satisTarihi
            // 
            this.satisTarihi.Text = "Satış Tarihi";
            this.satisTarihi.Width = 110;
            // 
            // geriBtn
            // 
            this.geriBtn.Location = new System.Drawing.Point(12, 12);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(118, 42);
            this.geriBtn.TabIndex = 1;
            this.geriBtn.Text = "Geri";
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // saatlbl
            // 
            this.saatlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saatlbl.AutoSize = true;
            this.saatlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.Location = new System.Drawing.Point(1149, 32);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(71, 22);
            this.saatlbl.TabIndex = 37;
            this.saatlbl.Text = "label30";
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // satisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.ControlBox = false;
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "satisList";
            this.Text = "e-envanter";
            this.Load += new System.EventHandler(this.satişList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader barkodNo;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader marka;
        private System.Windows.Forms.ColumnHeader satisMiktar;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader girisTarihi;
        private System.Windows.Forms.ColumnHeader satisTarihi;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Timer saat;
    }
}