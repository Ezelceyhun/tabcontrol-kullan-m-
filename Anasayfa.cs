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
                MessageBox.Show("Sekmeleri Sırası İle Ekleyiniz !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 1)
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

            }
            else
            {
                MessageBox.Show("Sekmeleri Sırası İle Ekleyiniz !");
            }
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Padding = new System.Drawing.Point(CLOSE_SIZE, CLOSE_SIZE);
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);

        }
        const int CLOSE_SIZE = 15;
        //global sekme_id değişkeni
        int sekme_id;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
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
                if (sekme_id > 0)
                {
                    this.tabControl1.TabPages.RemoveAt(sekme_id);
                }
                else
                {
                    MessageBox.Show("Tümü Kapatıldı !");
                }
            }
            else
            {
                MessageBox.Show("Kapatmak İstediğiniz Sayfaya Gidin !");
            }
        */}

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 2 && tabControl1.TabCount != 1)
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
            }
            else
            {
                MessageBox.Show("Sekmeleri Sırası İle Ekleyiniz !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 3 && tabControl1.TabCount !=2 && tabControl1.TabCount != 1)
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
            }
            else
            {
                MessageBox.Show("Sekmeleri Sırası İle Ekleyiniz !");
            }
        }     

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            int a = sekme_id - 1;
            for(int i = a;i>0;i--)
            {
                this.tabControl1.TabPages.RemoveAt(i);            
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle myTabRect = this.tabControl1.GetTabRect(e.Index);

                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, myTabRect.X + 2, myTabRect.Y + 2);

                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                // Fill the rectangular box
                Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.White;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                // Painting close symbol
                using (Pen objpen = new Pen(Color.Black))
                {
                    Bitmap bt = new Bitmap("C:\\Users\\ezelc\\Desktop\\Github Projeleri\\tabcontrol kullanımı\\Resources\\close_FILL0_wght400_GRAD0_opsz24.png");
                    Point p5 = new Point(myTabRect.X, 4);
                    e.Graphics.DrawImage(bt, p5);
                }
                e.Graphics.Dispose();
            }
            catch (Exception)
            { }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                Rectangle myTabRect = this.tabControl1.GetTabRect(this.tabControl1.SelectedIndex);
                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;
                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                }
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
