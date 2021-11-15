
namespace e_envanter
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label1 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici_AdG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.calisanCheck = new System.Windows.Forms.RadioButton();
            this.yoneticiCheck = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatlbl = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sifreG = new System.Windows.Forms.MaskedTextBox();
            this.gösterChckb = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ EKRANI";
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(147, 258);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(127, 32);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre : ";
            // 
            // kullanici_AdG
            // 
            this.kullanici_AdG.Location = new System.Drawing.Point(147, 69);
            this.kullanici_AdG.Name = "kullanici_AdG";
            this.kullanici_AdG.Size = new System.Drawing.Size(176, 22);
            this.kullanici_AdG.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.gösterChckb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.calisanCheck);
            this.panel1.Controls.Add(this.yoneticiCheck);
            this.panel1.Controls.Add(this.sifreG);
            this.panel1.Controls.Add(this.kullanici_AdG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.girisBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(135, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 308);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yetki : ";
            // 
            // calisanCheck
            // 
            this.calisanCheck.AutoSize = true;
            this.calisanCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanCheck.Location = new System.Drawing.Point(261, 181);
            this.calisanCheck.Name = "calisanCheck";
            this.calisanCheck.Size = new System.Drawing.Size(85, 22);
            this.calisanCheck.TabIndex = 9;
            this.calisanCheck.TabStop = true;
            this.calisanCheck.Text = "Çalışan";
            this.calisanCheck.UseVisualStyleBackColor = true;
            // 
            // yoneticiCheck
            // 
            this.yoneticiCheck.AutoSize = true;
            this.yoneticiCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiCheck.Location = new System.Drawing.Point(147, 181);
            this.yoneticiCheck.Name = "yoneticiCheck";
            this.yoneticiCheck.Size = new System.Drawing.Size(89, 22);
            this.yoneticiCheck.TabIndex = 8;
            this.yoneticiCheck.TabStop = true;
            this.yoneticiCheck.Text = "Yönetici";
            this.yoneticiCheck.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // saatlbl
            // 
            this.saatlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saatlbl.AutoSize = true;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.Location = new System.Drawing.Point(408, 52);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(65, 20);
            this.saatlbl.TabIndex = 2;
            this.saatlbl.Text = "saatlbl";
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // sifreG
            // 
            this.sifreG.Location = new System.Drawing.Point(147, 117);
            this.sifreG.Name = "sifreG";
            this.sifreG.Size = new System.Drawing.Size(176, 22);
            this.sifreG.TabIndex = 7;
            // 
            // gösterChckb
            // 
            this.gösterChckb.AutoSize = true;
            this.gösterChckb.Location = new System.Drawing.Point(329, 117);
            this.gösterChckb.Name = "gösterChckb";
            this.gösterChckb.Size = new System.Drawing.Size(70, 21);
            this.gösterChckb.TabIndex = 11;
            this.gösterChckb.Text = "göster";
            this.gösterChckb.UseVisualStyleBackColor = true;
            this.gösterChckb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 554);
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "giris";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-envanter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox kullanici_AdG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton calisanCheck;
        private System.Windows.Forms.RadioButton yoneticiCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox gösterChckb;
        private System.Windows.Forms.MaskedTextBox sifreG;
    }
}

