using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_film_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ıDIOTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "3 IDIOTS";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\komedi\\3-ahmak.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2009";
            label5.Text = "Hindistan";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Film Hindistan'ın en iyi mühendislik okulundaki üç arkadaşın dostluklarını ve hayatını anlatırken eğitim sistemini eleştirmektedir. Hindistan'da tüm zamanların (kendi yılına kadar) en yüksek gişe rekoru ve hasılatını yapan filmidir.";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void hOMEALONEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "HOME ALONE";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\komedi\\homealone.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "1990";
            label5.Text = "ABD";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Ailesini pek sevmeyen Kevin (Macaulay Culkin) aldığı ceza üzerine geceyi evlerinin çatıkatında geçirir ve ertesi gün yatağında uyandığında ailesinin evde olmadığını, tatile giderken onu unuttuklarını fark eder. Başta panikleyen Kevin bunun fırsat olduğunu çok geçmeden anlar ve yalnızlığın keyfini çıkarır.";
        }

        private void jOHNWICK4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "JOHN WICK 4";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\aksiyon\\john-wick-4-.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2023";
            label5.Text = "ABD";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Köpeğinin öldürülmesi üzerine yeniden yeraltı dünyasına karışan eski bir suikastçi olan John Wick'in yüksek tansiyonlu maceraları hız kesmeden devam ediyor. Suikastçinin tekrardan peşine takılan katillerle mücadelesini izleyeceğimiz devam filminde, mutlu bir son beklemenin büyük bir hata olacağı söylentiler arasında.";
        }

        private void lORDOFRINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "LORD OF RINGS";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\aksiyon\\lordofrings.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2001";
            label5.Text = "İngiltere";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Yüzüklerin Efendisi: Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar.";
        }

        private void tHEHUNGERGAMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "THE HUNGER GAMES";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\macera\\açlıkoyunları.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2012";
            label5.Text = "UK";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Bir zamanlar Kuzey Amerika olarak bilinen bir yerin yıkıntıları içinde Panem ulusu yaşamaktadır. Capitol'ün etrafında bir hat boyunca sıralanmış 12 bölge bulunmaktadır. Capitol yönetimi şiddetli ve acımasızdır. Bölgeler, her yıl yapılan Açlık Oyunları'na katılmak zorundadır. Her bölge yarışma için yaşları 12 ila 18 arasında değişen birer erkek ve kız çocuğu göndermek durumundadır. Açlık Oyunları televizyondan canlı olarak yayınlanan ve ölümüne bir kavgadır.\r\n\r\n16 yaşındaki Katniss Everdeen annesi ve kendinden daha küçük kız kardeşi ile yaşamaktadır. Oyunlarda kız kardeşinin yerine gönüllü olarak Açlık Oyunları'na katılır. Kız kardeşi için hayatta kalma mücadelesi verecektir. Ancak bu mücadeleyi kazanırsa hayatta kalma seçeneği olacaktır.";
        }

        private void pIRATESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label7.Text = "PIRATES CARRIBBEAN";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\macera\\karayip korsanları.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2010";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Kaptan Jack Sparrow (Johnny Depp) tehlikeli sulardaki bol aksiyonlu macerasına dördüncü film ile geri dönüyor. Gençlik Çeşmesi'nin bulunması için İngiltere Kralı'na hizmet etmeyi reddeden Sparrow, kentte kendi adıyla gemisine mürettebat toplayan sahte bir kaptanın olduğunu öğrenir.";
        }

        private void ıTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "IT";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\korku\\ıt.jpeg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2017";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır.";
        }

        private void aNABELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "ANABELLE";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\korku\\anabella.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2014";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "John Form, oyuncak bebek koleksiyonu yapan hamile eşi Mia için yeni bir oyuncağı gözüne kestirir. Beyaz gelinlik giydirilmiş, eşine zor rastlanır bu antika oyuncak bebek Mia için kusursuz bir hediye olacaktır. Mia beklediği gibi hediyesi Annabelle'i görünce mutlu olur, ancak bu güzel anlar çok uzun sürmez. Form ailesinin evi bir gece evleri sapkın bir tarikat tarafından basılır ve ciddi bir saldırıya uğrarlar. Saldırganlar uzaklaşırlar ancak hiçbir şey çözülmüş değildir. Zira ailenin hiç tahmin edemeyeceği bir kötü ruhu evde bırakmışlardır. ";
        }

        private void hIGHLANEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label7.Text = "HIGH LANE";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\gerilim\\gerilim hattı.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2009";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Bir grup arkadaş eğlenceli bir tırmanış yapmaya karar verir. Tırmanış rotası kapalı olsa da yollarına devam ederler. Göze aldıkları bu tırmanış, gittikçe daha riskli ve tehlikeli bir hal alır ve kazalar birbirini izler. Yolun kapalı olmasının bir nedeni vardır.";
        }

        private void tHESILENCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "THE SILENCE";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\gerilim\\the-silence.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2019";
            label5.Text = "USA-Almanya";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Dünya, onlarca yıl boyunca yeraltında yetişen ölümcül yaratıkların saldırısı altındadır. Yeryüzüne çıkıp insanları avlayan yaratıklar, kurbanlarını seslerinden tanıyarak ele geçirir. Dünyaya dehşet saçan yaratıklardan kaçmaya çalışan genç bir kız ve ailesi, şehir dışında bir yerde saklanmaya çalışır.";
        }

        private void aVANGERSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label7.Text = "AVANGERS END GAME";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\bilim kurgu\\endgame.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2019";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Thanos'un (Josh Brolin) Sonsuzluk Eldiveni'ni ele geçirmesi ve kendi Dünya dengesini kurması nedeniyle süperkahramanlar dahil dünyanın yarısı küle dönüşmüştü. Geriye kalan ve yas tutan Yenilmezler'in as kadrosu Black Widow (Scarlett Johansson), Captain America (Chris Evans), Hulk (Mark Ruffalo), Thor (Chris Hemsworth) ve Iron Man'e (Robert Downey Jr.) kuantum bölgesinden gelerek aralarına katılan Ant-Man (Paul Rudd) umut ışığı olacak. ";
        }

        private void ıNCEPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "INCEPTION";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\bilim kurgu\\inception.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "2010";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Dom Cobb (Leonardo DiCaprio) çok yetenekli bir hırsızdır. Uzmanlık alanı, zihnin en savunmasız olduğu rüya görme anında, bilinçaltının derinliklerindeki değerli sırları çekip çıkarmak ve onları çalmaktır.";
        }

        private void tHEGREENMILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "THE GREEN MILE";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\dram\\220px-YesilYol.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "1999";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "Yeşil Yol, bir hapishane görevlisi ile bir mahkumun öyküsünü anlatıyor. Paul Edgecomb'un hapishanedeki görevi, idama mahkum edilen mahkumları son yolculuklarına uğurlamaktır. Çalıştığı yıllar içerisinde yüzlerce mahkumu idam etmiştir. Bir gün John Coffey isimli korkutucu görünümlü bir adamla tanışır.";
        }

        private void tITANICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Text = "TITANIC";
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\iseli\\OneDrive\\Resimler\\filmler\\dram\\titanic.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "1997";
            label5.Text = "Amerika";
            label6.Text = "Türkçe";
            richTextBox1.Text = "İnsan elinden çıkmış en büyük ve en gösterişli yüzen araç olan Titanic yola koyuldu. Batmaz, sarsılmaz denilen bu büyük lüks yolcu gemisinde yolculuk yapmak, 20. Yüzyılın muhteşem bir rüyasıydı. Ancak bu büyük rüya sadece 4.5 gün serecek ve anısını bir sonraki yüzyıla bile taşıyacak büyüklükte bir kabusa dönüşecekti.\r\n\r\nGeminin ilk ve son yolculuğuyla örtüşen, kısa soluklu ama ölümsüz bir aşk öyküsüne yer veren yönetmen James Cameron, Titanic kadar büyük bir aşk öyküsü merkez alarak, bu bildik felaketi farklı bir tarzda anlatıyor.";
        }
    }
}
