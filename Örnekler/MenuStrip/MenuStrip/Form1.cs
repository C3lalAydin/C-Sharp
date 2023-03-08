using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açıklayıcıAnlatımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Açıklayıcı Anlatım";
            richTextBox1.Text = "Okuyucuya bilgi vermek, okuyucuyu bir konuda aydınlatmak, bir konuyu açıklamak, bir şey öğretmek amacıyla kullanılan anlatım biçimine açıklayıcı anlatım denir. Açıklayıcı anlatım genellikle makale, deneme, sohbet, fıkra, eleştiri gibi eser türlerinde kullanılır.";
        }

        private void betimleyiAnlatımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Betimleyici Anlatım";
            richTextBox1.Text = "Canlı ve cansız varlıkları en ince ayrıntılarına kadar anlatma sanatına tasvir (betimleme) denir. Çevremizde gördüğümüz her şey betimlenebilir.";
        }

        private void tartışmacıAnlatımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Tartışmacı Anlatım";
            richTextBox1.Text = "Herhangi bir alanda ileri sürülen bir görüşün yanlışlığını kanıtlamak, o tezi çürütmek veya değiştirmek amacıyla yazılan yazılarda kullanılan bir anlatım biçimidir.";
        }

        private void öykülToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Öyküleyici Anlatım";
            richTextBox1.Text = "Olayları bir akış halinde; yer, zaman, kişi ögeleri üzerine kurulmuş bir anlatım biçimidir. Bu anlatımda amaç okuyucuyu olay içinde yaşatmaktır.Olaylar birbiri üzerinden gelişir ve zaman hızlı akar. Daha çok roman, hikâye, anı, gezi, biyografi, otobiyografi, tiyatro... gibi eser türlerinde kullanılır. Olay: eserde yer alan kişi ya da kişilerin yaptıkları işlerdir. Olaylar olağanüstü olabileceği gibi günlük yaşantımızda sık sık karşılaştığımız türden de olabilir. Olaylar yer, zaman ve kişilere bağlı olarak gerçekleşir.";
        }

        private void romanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Roman";
            richTextBox1.Text = " Düz yazı çeşitleri arasında en uzun olanıdır. Biyografi romanları gerçek bir yaşam hikayesine dayanır. Otobiyografik romanlarda kişi doğrudan kendi yaşam öyküsünü kaleme alır. Hikayeye göre çok daha uzun olan romanlarda karakterler derinlemesine analiz edilir. Olaylar ya 1. ya da 3. tekil şahıs ağzından anlatılır. Mekanlar ve karakterler uzun uzun betimlenerek okurun olayları gözünde canlandırması sağlanır.";
        }

        private void hikayeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Hikaye";
            richTextBox1.Text = " Hikaye, kendi içerisinde durum ve olay öyküsü olarak ikiye ayrılır. Romana göre sayfa sayısı daha az olan hikayelerin konuları gerçek, kurgusal ya da fantastik olabilir.";
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Deneme";
            richTextBox1.Text = " Yazarın okuruyla adeta sohbet edermiş gibi kaleme aldığı düşünce yazılarına deneme denir. Deneme türündeki ilk ve en önemli örnekleri 16. yüzyılda yaşamış olan Fransız yazar Michel de Montaigne vermiştir. Deneme türündeki yazılarda yazar, belirlediği bir konu hakkındaki görüşlerini anıları ile birlikte okurla paylaşır. Herhangi bir kanıt sunmasına gerek yoktur";
        }

        private void makaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Makale";
            richTextBox1.Text = " Yazarın bir fikri okura kanıtları ile birlikte sunduğu yazılara makale denir. Yazar konuları objektif bir şekilde ele alır ve nesnel bir üslup kullanır.";
        }

        private void fablToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Fabl";
            richTextBox1.Text = " Çocuklar için kaleme alınan fabl türündeki eserlerde çeşitli hayvanlar konuşturulur. Masallardan daha kısa olan fabl türünün ilk örneklerini La Fontainne adlı Fransız bir yazar vermiştir. Bu düz yazıların ortak özelliği sonunda mutlaka bir mesaj vermesidir. Hayvanların üzerinden açgözlülük, tembellik gibi insani özellikler kötülenirken, çalışkanlık, yardımlaşma gibi erdemler övülür.";
        }

        private void lirikŞiirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Lirik Şiir";
            richTextBox1.Text = " Lirik şiirlerde genelde aşk, özlem, vatan hasreti gibi konular işlenir. Hece ve aruz ölçüsüyle yazılabilen bu şiir türü serbest vezinle de kaleme alınabilir. En çok okunan lirik şairlerimizin başında Orhan Veli, Edip Cansever ve Melih Cevdet Anday yer alıyor.";
        }

        private void epikŞiirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Epik Şiir";
            richTextBox1.Text = " Tarihteki olayların destansı bir üslupla anlatıldığı şiirlere epik şiir denir. Kahramanlık, yiğitlik ve fedakarlık gibi konular ele alınır. Pastoral, satirik ve didaktik şiirler de yazı türleri içerisinde yer almaktadır.";
        }
    }
}
