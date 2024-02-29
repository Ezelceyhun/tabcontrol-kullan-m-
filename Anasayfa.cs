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
        //TabPage myTabPage = new TabPage();
        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString() + "  ";
            TabPage myTabPage = new TabPage();      
            if (tabControl1.TabCount == 0)
            {
                
                form1.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 0;
                form1.Show();
                myTabPage.Controls.Add(form1);              
            }
            else if(myTabPage != null)
            {
                tabControl1.SelectedIndex = 0;
                form1.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString() + "  ";
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 1)
            {
                
                form2.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 1;
                form2.Show();
                myTabPage.Controls.Add(form2);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 1;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString() + "  ";
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 2)
            {

                form3.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 2;
                form3.Show();
                myTabPage.Controls.Add(form3);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 2;
                form3.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string title = "Sekme " + (tabControl1.TabCount + 1).ToString() + "  ";
            TabPage myTabPage = new TabPage();
            if (tabControl1.TabCount == 3)
            {

                form4.MdiParent = this;
                myTabPage.Text = title;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedIndex = 3;
                form4.Show();
                myTabPage.Controls.Add(form4);
            }
            else if (myTabPage != null)
            {
                tabControl1.SelectedIndex = 3;
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                form1.Hide();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                form2.Hide();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                form3.Hide();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                form4.Hide();
            }
            else
            {
                MessageBox.Show("Kapatmak İstediğiniz Sekmeyi Seçin!");
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString(" ", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle(); 
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Bu Sekmeyi Kapatmak Üzeresin. Kapatılsın Mı?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
