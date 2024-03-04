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
using System.Web.UI;
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
        TabPage myTabPage = new TabPage();
        TabPage myTabPage2 = new TabPage();
        TabPage myTabPage3 = new TabPage();
        TabPage myTabPage4 = new TabPage();
        private void button1_Click(object sender, EventArgs e)
        {
            //sekme adı ve yeni sekme oluştur
            string title = "Sekme " + (tabControl1.TabCount +1).ToString();          
            button1.AccessibleName = "tabkey1";
            if (myTabPage == null)
            {
                myTabPage.AccessibleName = "tabkey1";
                form1.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                this.myTabPage.Show();
                form1.Show();
                myTabPage.Controls.Add(form1);
            }
            else if(myTabPage.AccessibleName == "tabkey1")
            {
                myTabPage.Show();      
                tabControl1.SelectedTab = myTabPage;
                form1.Show();
            }
            else if(myTabPage.AccessibleName == null)
            {
                myTabPage.AccessibleName = "tabkey1";
                form1.MdiParent = this;
                myTabPage.Text = "Sekme 1";
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                form1.Show();
                myTabPage.Controls.Add(form1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString();
            button2.AccessibleName = "tabkey2";
            if (myTabPage == null)
            {
                myTabPage2.AccessibleName = "tabkey2";
                form2.MdiParent = this;
                myTabPage2.Text = title;
                tabControl1.TabPages.Add(myTabPage2);
                tabControl1.SelectedTab = myTabPage2;
                this.myTabPage2.Show();
                form2.Show();
                myTabPage2.Controls.Add(form2);
            }
            else if (myTabPage2.AccessibleName == "tabkey2")
            {
                myTabPage2.Show();
                tabControl1.SelectedTab = myTabPage2;
                form2.Show();
            }
            else if (myTabPage2.AccessibleName == null)
            {
                myTabPage2.AccessibleName = "tabkey2";
                form2.MdiParent = this;
                myTabPage2.Text = "Sekme 2";
                tabControl1.TabPages.Add(myTabPage2);
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                form2.Show();
                myTabPage2.Controls.Add(form2);
            }
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {}
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString();
            button3.AccessibleName = "tabkey3";
            if (myTabPage == null)
            {
                myTabPage3.AccessibleName = "tabkey3";
                form3.MdiParent = this;
                myTabPage3.Text = title;
                tabControl1.TabPages.Add(myTabPage3);
                tabControl1.SelectedTab = myTabPage3;
                this.myTabPage3.Show();
                form3.Show();
                myTabPage3.Controls.Add(form3);
            }
            else if (myTabPage3.AccessibleName == "tabkey3")
            {
                myTabPage3.Show();
                tabControl1.SelectedTab = myTabPage3;
                form3.Show();
            }
            else if (myTabPage3.AccessibleName == null)
            {
                myTabPage3.AccessibleName = "tabkey3";
                form3.MdiParent = this;
                myTabPage3.Text = "Sekme 3";
                tabControl1.TabPages.Add(myTabPage3);
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                form3.Show();
                myTabPage3.Controls.Add(form3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString();
            button4.AccessibleName = "tabkey4";
            if (myTabPage4 == null)
            {
                myTabPage4.AccessibleName = "tabkey4";
                form4.MdiParent = this;
                myTabPage4.Text = title;
                tabControl1.TabPages.Add(myTabPage4);
                this.myTabPage4.Show();
                form4.Show();
                myTabPage4.Controls.Add(form4);
            }
            else if (myTabPage4.AccessibleName == "tabkey4")
            {
                myTabPage4.Show();
                tabControl1.SelectedTab = myTabPage4;
                form4.Show();
            }
            else if (myTabPage4.AccessibleName == null)
            {
                myTabPage4.AccessibleName = "tabkey4";
                form4.MdiParent = this;
                myTabPage4.Text = "Sekme 4";
                tabControl1.TabPages.Add(myTabPage4);
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                form4.Show();
                myTabPage4.Controls.Add(form4);
            }
        }     

        private void button6_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        { }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*try
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

                 
                Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.White;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                 
                using (Pen objpen = new Pen(Color.Black))
                {
                    Bitmap bt = new Bitmap("C:\\Users\\ezelc\\Desktop\\Github Projeleri\\tabcontrol kullanımı\\Resources\\close_FILL0_wght400_GRAD0_opsz24.png");
                    Point p5 = new Point(myTabRect.X, 4);
                    e.Graphics.DrawImage(bt, p5);
                }
                e.Graphics.Dispose();
            }
            catch (Exception)
            { }*/
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
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
            }*/
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
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == myTabPage)
            {
                int a = tabControl1.SelectedIndex;
                this.tabControl1.TabPages.RemoveAt(a);
                myTabPage.AccessibleName = null;
            }
            else if (tabControl1.SelectedTab == myTabPage2)
            {
                int a = tabControl1.SelectedIndex;
                this.tabControl1.TabPages.RemoveAt(a);
                myTabPage2.AccessibleName = null;
            }
            else if (tabControl1.SelectedTab == myTabPage3)
            {
                int a = tabControl1.SelectedIndex;
                this.tabControl1.TabPages.RemoveAt(a);
                myTabPage3.AccessibleName = null;
            }
            else if (tabControl1.SelectedTab == myTabPage4)
            {
                int a = tabControl1.SelectedIndex;
                this.tabControl1.TabPages.RemoveAt(a);
                myTabPage4.AccessibleName = null;
            }
            else
            {
                MessageBox.Show("Kapatmak İstediğiniz Sayfaya Gidin !");
            }
        }
    }
}
