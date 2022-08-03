/****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2020-2021 BAHAR DÖNEMİ
**	
**				PROJE NUMARASI..........:1.Proje
**				ÖĞRENCİ ADI............:Aslıhan AKBULUT
**				ÖĞRENCİ NUMARASI.......:G201210080
**              DERSİN ALINDIĞI GRUP...:2.Öğretim B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vitaminDeposu
{
    public partial class Form1 : Form
    {
        abstract class Vitamin
        {
            public abstract double VitDeger(int meyveNo , double verim);
  
        }
        class VitaminA : Vitamin
        { 
            public override double VitDeger(int meyveNo, double verim)
            {
                return (vitaminA100gr[meyveNo] * verim) / 100;
            }
        }
        class VitaminC : Vitamin
        {
            public override double VitDeger(int meyveNo, double verim)
            {
                return (vitaminC100gr[meyveNo] * verim) / 100;
            }
        }
        interface Imeyve
        {

            int MeyveSecim();
            int MeyveGram();

            int Verim(int gram);
        }
        class KatiMeyve: Imeyve
        {
            public int MeyveGram()
            {
                int MeyveGr = 0;
                Random rastgele = new Random();
                MeyveGr = rastgele.Next(70, 120);
                return MeyveGr;
            }

            public int MeyveSecim()
            {
                int meyve = 0;
                Random rastgele1 = new Random();
                meyve = rastgele1.Next(30);
                return meyve;
            }

            public int Verim(int gram)
            {
                int verim = 0;
                Random rastgele = new Random();
                verim = rastgele.Next(80, 95);
                return ((verim * gram) / 100);
            }

            
        }
        class Narenciye: Imeyve
        {
            

            public int MeyveGram()
            {
                int MeyveGr = 0;
                Random rastgele = new Random();
                MeyveGr = rastgele.Next(70, 120);
                return MeyveGr;
            }

            public int MeyveSecim()
            {
                int meyve = 0;
                Random rastgele1 = new Random();
                meyve = rastgele1.Next(30);
                return meyve;
            }

            public int Verim(int gram)
            {
                int verim = 0;
                Random rastgele = new Random();
                verim = rastgele.Next(30, 70);
                return ((verim * gram) / 100);
            }
        }
        

        public static int meyveNo = 0;

        public static string[] Meyveler = { "ÇİLEK","PORTAKAL","ELMA","LİMON","AVOKADO","GREYFURT","MUZ","MANDALİNA","KİVİ",
                "KUMKUAT","VİŞNE","MİSKET LİMON","KİRAZ","BERGAMOT","ŞEFTALİ","TURUNÇ","ARMUT","POMELO","BEYAZ DUT","KLEMANTİN"
                ,"ÜZÜM","KÜTDİKEN","YABAN MERSİNİ","ENTERDONAT","BÖĞÜRTLEN","KEBBET","KARADUT","KAFFİR LİME","HURMA","TATLI LİMON"};
        public static int[] vitaminA100gr = { 12,225,54,22,146,1150,64,681,87,290,569,50,1283,125,326,554,
            25,8,25,326,100,235,54,584,214,86,25,135,10,50};
        public static int[] vitaminC100gr = { 58,50,5,53,10,31,9,26,93,44,10,29,10,21,7,48,5,61,36,49,
            4,34,10,28,21,43,36,27,1,29};

        public static Label MeyveAd = new Label();
        public static Label lblMeyveGr = new Label();
        public static Label lblVitA = new Label();
        public static Label lblVitC = new Label();
        public static Label lblTopVitA = new Label();
        public static Label lblTopVitC = new Label();
        public static Label lblTopMeyve = new Label();
        public static Button butKatiMeyve = new Button();
        public static Button butNarenciye = new Button();
        public static ListBox listMeyve = new ListBox();
        public static ListBox listVitA = new ListBox();
        public static ListBox listVitC = new ListBox();
        public static Label sonucGr = new Label();
        public static Label sonucVitA = new Label();
        public static Label sonucVitC = new Label();
        public static double toplamGr = 0;
        public static double toplamVitA = 0;
        public static double toplamVitC = 0;
        
        public static Label sonuc = new Label();
        public void Temizleme()
        {
            this.Controls.Remove(MeyveResim);
            this.Controls.Remove(MeyveAd);
            this.Controls.Remove(lblVitA);
            this.Controls.Remove(lblVitC);
            this.Controls.Remove(lblMeyveGr);
            this.Controls.Remove(lblTopVitA);
            this.Controls.Remove(lblTopVitC);
            this.Controls.Remove(lblTopMeyve);
            this.Controls.Remove(butKatiMeyve);
            this.Controls.Remove(butNarenciye);
            this.Controls.Remove(listMeyve);
            this.Controls.Remove(listVitA);
            this.Controls.Remove(listVitC);
            
            sayac.Stop();
            sonucGr.Left = 60;
            sonucGr.Top = 350;
            sonucGr.Width = 300;
            sonucGr.Height = 60;
            Controls.Add(sonucGr);
            sonucGr.BackColor = Color.Silver;
            sonucGr.Text = (toplamGr).ToString();

            sonucVitA.Left = 420;
            sonucVitA.Top = 350;
            sonucVitA.Width = 300;
            sonucVitA.Height = 60;
            Controls.Add(sonucVitA);
            sonucVitA.BackColor = Color.Silver;
            sonucVitA.Text = (toplamVitA).ToString();

            sonucVitC.Left = 780;
            sonucVitC.Top = 350;
            sonucVitC.Width = 300;
            sonucVitC.Height = 60;
            Controls.Add(sonucVitC);
            sonucVitC.BackColor = Color.Silver;
            sonucVitC.Text = (toplamVitC).ToString();

            sonuc.Left = 420;
            sonuc.Top = 300;
            sonuc.Width = 300;
            sonuc.Height = 50;
            Controls.Add(sonuc);

            sonuc.ForeColor = Color.FromArgb(255, 255, 128);
            sonuc.Text = "  *TOPLADIĞINIZ VİTAMİN MİKTARLARI*  ";

            sonuc.Font = new Font(sonuc.Font, sonuc.Font.Style ^ FontStyle.Bold);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butBasla_Click(object sender, EventArgs e)
        {
            KatiMeyve katiMeyve = new KatiMeyve();
            Narenciye narenciye = new Narenciye();
            Form1 form1 = new Form1();
            this.Controls.Remove(label1);
            this.Controls.Remove(label2);
            this.Controls.Remove(butBasla);
            this.Controls.Remove(butCikis);

            sayac.Start();

            MeyveAd.Left = 60;
            MeyveAd.Top = 220;
            MeyveAd.Width = 350;
            MeyveAd.Height = 40;
            MeyveAd.BackColor = Color.Silver;
            Controls.Add(MeyveAd);

            butKatiMeyve.Left = 60;
            butKatiMeyve.Top = 300;
            butKatiMeyve.Width = 350;
            butKatiMeyve.Height = 60;
            butKatiMeyve.BackColor = Color.Silver;
            butKatiMeyve.Text = "    KATI MEYVE SIKACAĞI";
            Controls.Add(butKatiMeyve);

            butNarenciye.Left = 60;
            butNarenciye.Top = 400;
            butNarenciye.Width = 350;
            butNarenciye.Height = 60;
            butNarenciye.BackColor = Color.Silver;
            butNarenciye.Text = "    NARENCİYE SIKACAĞI";
            Controls.Add(butNarenciye);

            listMeyve.Left = 460;
            listMeyve.Top = 100;
            listMeyve.Width = 180;
            listMeyve.Height = 180;
            Controls.Add(listMeyve);

            listVitA.Left = 680;
            listVitA.Top = 100;
            listVitA.Width = 180;
            listVitA.Height = 180;
            Controls.Add(listVitA);

            listVitC.Left = 900;
            listVitC.Top = 100;
            listVitC.Width = 180;
            listVitC.Height = 180;
            Controls.Add(listVitC);

            lblMeyveGr.Left = 470;
            lblMeyveGr.Top = 80;
            lblMeyveGr.Width = 150;
            lblMeyveGr.Height = 30;
            lblMeyveGr.Text = "  PÜRE - SIVI SON GRAM";
            Controls.Add(lblMeyveGr);

            lblVitA.Left = 690;
            lblVitA.Top = 80;
            lblVitA.Width = 150;
            lblVitA.Height = 30;
            lblVitA.Text = "          VİTAMİN A ( iu ) ";
            Controls.Add(lblVitA);

            lblVitC.Left = 910;
            lblVitC.Top = 80;
            lblVitC.Width = 150;
            lblVitC.Height = 30;
            lblVitC.Text = "          VİTAMİN C ( mg ) ";
            Controls.Add(lblVitC);

            lblTopMeyve.Left = 470;
            lblTopMeyve.Top = 330;
            lblTopMeyve.Width = 150;
            lblTopMeyve.Height = 30;
            lblTopMeyve.BackColor = Color.Silver;
            Controls.Add(lblTopMeyve);

            lblTopVitA.Left = 690;
            lblTopVitA.Top = 330;
            lblTopVitA.Width = 150;
            lblTopVitA.Height = 30;
            lblTopVitA.BackColor = Color.Silver;
            Controls.Add(lblTopVitA);

            lblTopVitC.Left = 910;
            lblTopVitC.Top = 330;
            lblTopVitC.Width = 150;
            lblTopVitC.Height = 30;
            lblTopVitC.BackColor = Color.Silver;
            Controls.Add(lblTopVitC);
            lblTopVitC.Left = 910;
            lblTopVitC.Top = 330;
            lblTopVitC.Width = 150;
            lblTopVitC.Height = 30;
            lblTopVitC.BackColor = Color.Silver;
            Controls.Add(lblTopVitC);

            butKatiMeyve.Click += new EventHandler(butKatiMeyve_Click);
            butNarenciye.Click += new EventHandler(butNarenciye_Click);


            meyveNo = katiMeyve.MeyveSecim();
            MeyveAd.Text = Meyveler[meyveNo];
            ResimYazdir(meyveNo);
        }
        public void butKatiMeyve_Click(object sender, EventArgs e)
        {
            KatiMeyve katiMeyve = new KatiMeyve();
            VitaminA vitA = new VitaminA();
            VitaminC vitC = new VitaminC();

            if (sayac1 >= 60)
            {
                Temizleme();
            }

            if (meyveNo % 2 == 0 || meyveNo == 0)
            {
                double kativerim = katiMeyve.Verim(katiMeyve.MeyveGram());
                listMeyve.Items.Add(kativerim);
                listVitA.Items.Add(vitA.VitDeger(meyveNo,kativerim));
                listVitC.Items.Add(vitC.VitDeger(meyveNo, kativerim));
                toplamGr += kativerim;
                toplamVitA += (vitA.VitDeger(meyveNo, kativerim));
                toplamVitC += (vitC.VitDeger(meyveNo, kativerim));
                lblTopMeyve.Text = (toplamGr).ToString();
                lblTopVitA.Text = (toplamVitA).ToString();
                lblTopVitC.Text = (toplamVitC).ToString();
            }
            else
            {
                MessageBox.Show("Yanlış Seçim Yaptınız!!");
            }
            meyveNo = katiMeyve.MeyveSecim();
            MeyveAd.Text = Meyveler[meyveNo];
            ResimYazdir(meyveNo);
        }
        public void butNarenciye_Click(object sender, EventArgs e)
        {
            Narenciye narenciye = new Narenciye();
            VitaminA vitA = new VitaminA();
            VitaminC vitC = new VitaminC();

            if (sayac1 >= 60)
            {
                Temizleme();
            }
     
            if (meyveNo % 2 == 1 || meyveNo == 1)
            {
                double verim = narenciye.Verim(narenciye.MeyveGram());
                listMeyve.Items.Add(verim);
                listVitA.Items.Add(vitA.VitDeger(meyveNo, verim));
                listVitC.Items.Add(vitC.VitDeger(meyveNo, verim));
                toplamGr += verim;
                toplamVitA += (vitA.VitDeger(meyveNo, verim));
                toplamVitC += (vitC.VitDeger(meyveNo, verim));
                lblTopMeyve.Text = (toplamGr).ToString();
                lblTopVitA.Text = (toplamVitA).ToString();
                lblTopVitC.Text = (toplamVitC).ToString();
            }
            else
            {
                MessageBox.Show("Yanlış Seçim Yaptınız!!");
            }
            meyveNo = narenciye.MeyveSecim();
            MeyveAd.Text = Meyveler[meyveNo];
            ResimYazdir(meyveNo);
        }
        
        public void ResimYazdir(int meyve)
        {
            
            switch (meyve)
            {
                case 0:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString()+"\\meyveler\\çilek.jpg";
                    break;
                case 1:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\portakal.jpg";
                    break;
                case 2:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\elma.jpg";
                    break;
                case 3:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\limon.jpg";
                    break;
                case 4:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\avokado.jpg";
                    break;
                case 5:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\greyfurt.jpg";
                    break;
                case 6:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\muz.jpg";
                    break;
                case 7:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\mandalina.jpg";
                    break;
                case 8:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kivi.jpg";
                    break;
                case 9:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kumkuat.jpg";
                    break;
                case 10:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\vişne.jpg";
                    break;
                case 11:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\misketlimon.jpg";
                    break;
                case 12:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kiraz.jpg";
                    break;
                case 13:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\bergamot.jpg";
                    break;
                case 14:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\şeftali.jpg";
                    break;
                case 15:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\turunç.jpg";
                    break;
                case 16:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\armut.jpg";
                    break;
                case 17:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\pomelo.jpg";
                    break;
                case 18:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\beyazdut.jpg";
                    break;
                case 19:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\klemantin.jpg";
                    break;
                case 20:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\üzüm.jpg";
                    break;
                case 21:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kütdiken.jpg";
                    break;
                case 22:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\yabanmersini.jpg";
                    break;
                case 23:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\enterdonat.jpg";
                    break;
                case 24:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\böğürtlen.jpg";
                    break;
                case 25:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kebbet.jpg";
                    break;
                case 26:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\karadut.jpg";
                    break;
                case 27:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\kaffirlime.jpg";
                    break;
                case 28:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\hurma.jpg";
                    break;
                case 29:
                    MeyveResim.ImageLocation = Application.StartupPath.ToString() + "\\meyveler\\tatlılimon.jpg";
                    break;

                default:
                    break;
            }
        }

        private void butCikis_Click(object sender, EventArgs e)
        {
            Close();

        }

        public static int sayac1 = 0;
        private void sayac_Tick(object sender, EventArgs e)
        {
            sayac1++;
            
        }
    }
}
