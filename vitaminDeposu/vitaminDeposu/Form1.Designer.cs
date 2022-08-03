
namespace vitaminDeposu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.butBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butCikis = new System.Windows.Forms.Button();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.MeyveResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MeyveResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(474, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "* VİTAMİN DEPOSU *";
            // 
            // butBasla
            // 
            this.butBasla.BackColor = System.Drawing.Color.RosyBrown;
            this.butBasla.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBasla.Location = new System.Drawing.Point(672, 507);
            this.butBasla.Name = "butBasla";
            this.butBasla.Size = new System.Drawing.Size(146, 73);
            this.butBasla.TabIndex = 5;
            this.butBasla.Text = "BAŞLA";
            this.butBasla.UseVisualStyleBackColor = false;
            this.butBasla.Click += new System.EventHandler(this.butBasla_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(579, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlamak İçin Tıklayınız";
            // 
            // butCikis
            // 
            this.butCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.butCikis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCikis.Location = new System.Drawing.Point(1124, 615);
            this.butCikis.Name = "butCikis";
            this.butCikis.Size = new System.Drawing.Size(126, 44);
            this.butCikis.TabIndex = 7;
            this.butCikis.Text = "Çıkış\r\n";
            this.butCikis.UseVisualStyleBackColor = false;
            this.butCikis.Click += new System.EventHandler(this.butCikis_Click);
            // 
            // sayac
            // 
            this.sayac.Interval = 1000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // MeyveResim
            // 
            this.MeyveResim.Location = new System.Drawing.Point(100, 32);
            this.MeyveResim.Name = "MeyveResim";
            this.MeyveResim.Size = new System.Drawing.Size(217, 206);
            this.MeyveResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeyveResim.TabIndex = 8;
            this.MeyveResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.MeyveResim);
            this.Controls.Add(this.butCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butBasla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vitamin Deposu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeyveResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCikis;
        public System.Windows.Forms.Timer sayac;
        public System.Windows.Forms.PictureBox MeyveResim;
    }
}

