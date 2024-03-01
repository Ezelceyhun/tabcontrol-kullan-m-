using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tabcontrol_kullanımı
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            //sekme adı ve yeni sekme oluştur
            string title = "Sekme " + (tabControl1.TabCount).ToString();
            TabPage myTabPage = new TabPage();      
            if (tabControl1.TabCount == 1)
            {
                
                form1.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 1;
                form1.Show();
                myTabPage.Controls.Add(form1);              
            }
            else if(myTabPage != null)
            {
                tabControl1.SelectedIndex = 1;
                form1.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount).ToString();
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 2)
            {
                
                form2.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);               
                tabControl1.SelectedIndex = 2;
                form2.Show();
                myTabPage.Controls.Add(form2);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 2;
                form2.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            

        }
        //global sekme_id değişkeni
        int sekme_id;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected indexe göre sekme_id değişir ve selectedIndex 0 ise sekme_id de bulunan sayının bulunduğu
            //sekmeyi kapatır.
            if (tabControl1.SelectedIndex == 1)
            {
                sekme_id = 1;

            }
            else if(tabControl1.SelectedIndex == 2)
            {
                sekme_id = 2;
            }
            else if(tabControl1.SelectedIndex == 3)
            {
                sekme_id = 3;
            }
            else if(tabControl1.SelectedIndex == 4)
            {
                sekme_id = 4;
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                if (sekme_id != null)
                {
                    this.tabControl1.TabPages.RemoveAt(sekme_id);
                }
            }
            else
            {
                MessageBox.Show("Kapatmak İstediğiniz Sayfaya Gidin !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount).ToString();
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 3)
            {

                form3.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 3;
                form3.Show();
                myTabPage.Controls.Add(form3);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 3;
                form3.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount).ToString();
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 4)
            {

                form4.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 4;
                form4.Show();
                myTabPage.Controls.Add(form4);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 4;
                form4.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }     

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form1.Hide();
            form2.Hide();
            form3.Hide();
            form4.Hide();
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {        
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {          
        }
    }
}
