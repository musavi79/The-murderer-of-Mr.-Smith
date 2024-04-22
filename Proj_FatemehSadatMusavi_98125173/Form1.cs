using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_FatemehSadatMusavi_98125173
{
    public partial class Form1 : Form
    {
        DNA_DATA DNA_DATA = new DNA_DATA();

        public Form1()
        {
            InitializeComponent();
        }

        //ساختن فولدر
        private void button3_Click(object sender, EventArgs e)
        {
            DNA_DATA.loading();
        }


        //خواندن دیتا
        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader str = new StreamReader("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\Data.txt");
            richTextBox1.Text = str.ReadToEnd();
            str.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DNA_DATA.openfile();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DNA_DATA.digitfile();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool ex = File.Exists(openFileDialog1.FileName);
                if (ex)
                {
                    StreamReader str = new StreamReader(openFileDialog1.FileName);
                  richTextBox2.Text = str.ReadToEnd();
                    str.Close();
                }
            }
            
            string[] rowss = richTextBox2.Text.Split(';');
            DataTable dt = new DataTable();
            dt.Columns.Add("حروف");
            dt.Columns.Add("تعداد");


            for (int i = 0; i < rowss.Length; i++)
            {
                string[] col_1 = rowss[i].ToString().Split('=');
                dt.Rows.Add(col_1[0], col_1[1]);
            }

            dataGridView1.DataSource = dt;
        }
        //killer data
        private void button2_Click(object sender, EventArgs e)
        {
            //خواندن فایل کیلر
            StreamReader str = new StreamReader("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\Killer.txt");
            richTextBox3.Text = str.ReadToEnd();
            str.Close();
            //ساخت اینفو و دیجیت
            string Address = "C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\KILLER";
            string textpath = string.Concat(Address, "killer_info.txt");
            FileStream info = new FileStream(textpath, FileMode.Create);
            info.Close();
            string textpathe = string.Concat(Address, "killer_Digit.txt");
            FileStream digit = new FileStream(textpathe, FileMode.Create);
            digit.Close();
            //ریختن اطلاعات در اینفو
            string source = richTextBox3.Text;
            int acount = 0;
            foreach (char c in source)
                if (c == 'A') acount++;
            int bcount = 0;
            foreach (char c in source)
                if (c == 'B') bcount++;
            int ccount = 0;
            foreach (char c in source)
                if (c == 'C') ccount++;
            int dcount = 0;
            foreach (char c in source)
                if (c == 'D') dcount++;
            int ecount = 0;
            foreach (char c in source)
                if (c == 'E') ecount++;
            int fcount = 0;
            foreach (char c in source)
                if (c == 'F') fcount++;
            int gcount = 0;
            foreach (char c in source)
                if (c == 'G') gcount++;
            int hcount = 0;
            foreach (char c in source)
                if (c == 'H') hcount++;
            int icount = 0;
            foreach (char c in source)
                if (c == 'I') icount++;
            int jcount = 0;
            foreach (char c in source)
                if (c == 'J') jcount++;
            int kcount = 0;
            foreach (char c in source)
                if (c == 'K') kcount++;
            int lcount = 0;
            foreach (char c in source)
                if (c == 'L') lcount++;
            int mcount = 0;
            foreach (char c in source)
                if (c == 'M') mcount++;
            int ncount = 0;
            foreach (char c in source)
                if (c == 'N') ncount++;
            int ocount = 0;
            foreach (char c in source)
                if (c == 'O') ocount++;
            int pcount = 0;
            foreach (char c in source)
                if (c == 'P') pcount++;
            int qcount = 0;
            foreach (char c in source)
                if (c == 'Q') qcount++;
            int rcount = 0;
            foreach (char c in source)
                if (c == 'R') rcount++;
            int scount = 0;
            foreach (char c in source)
                if (c == 'S') scount++;
            int tcount = 0;
            foreach (char c in source)
                if (c == 'T') tcount++;
            int ucount = 0;
            foreach (char c in source)
                if (c == 'U') ucount++;
            int xcount = 0;
            foreach (char c in source)
                if (c == 'X') xcount++;
            int vcount = 0;
            foreach (char c in source)
                if (c == 'V') vcount++;
            int ycount = 0;
            foreach (char c in source)
                if (c == 'Y') ycount++;
            int zcount = 0;
            foreach (char c in source)
                if (c == 'Z') zcount++;
            int wcount = 0;
            foreach (char c in source)
                if (c == 'W') wcount++;
            //تبدیل عدد به کارکتر
            string a = "A=" + acount.ToString();
            string b = "B=" + bcount.ToString();
            string c2 = "c=" + ccount.ToString();
            string d = "D=" + dcount.ToString();
            string ee = "E=" + ecount.ToString();
            string f = "F=" + fcount.ToString();
            string g = "G=" + gcount.ToString();
            string h = "H=" + hcount.ToString();
            string i = "I=" + icount.ToString();
            string j = "J=" + jcount.ToString();
            string k = "K=" + kcount.ToString();
            string l = "L=" + lcount.ToString();
            string m = "M=" + mcount.ToString();
            string n = "N=" + ncount.ToString();
            string o = "O=" + ocount.ToString();
            string p = "P=" + pcount.ToString();
            string q = "Q=" + qcount.ToString();
            string r = "R=" + rcount.ToString();
            string s = "S=" + scount.ToString();
            string t = "T=" + tcount.ToString();
            string v = "V=" + vcount.ToString();
            string u = "U=" + ucount.ToString();
            string x = "X=" + xcount.ToString();
            string y = "Y=" + ycount.ToString();
            string z = "Z=" + zcount.ToString();
            string w = "W=" + wcount.ToString();
            //تمام رشته ها در تکست باکس دوم ریخته میشوند
            string alphabet = a + ";" + b + ";" + c2 + ";" + d + ";" + ee + ";" + f + ";" + g + ";" + h + ";" + i + ";" + j + ";" + k + ";" + l + ";" + m + ";" + n + ";" + o + ";" + p + ";" + q + ";" + r + ";" + w + ";" + z + ";" + x + ";" + y + ";" + u + ";" + s + ";" + t + ";" + v;
            richTextBox2.Text = alphabet;
            StreamWriter stw = new StreamWriter("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\KILLER\\killer_info.txt");
            stw.Write(richTextBox2.Text);
            stw.Close();
            //ساخت فایل دیجیت
            string read = richTextBox3.Text;
            //تبدیل به کداسکی
            string Str = "";
            foreach (char C in read)
            {
                Str = Str + "-" + (Convert.ToInt32(C)).ToString();
            }
            richTextBox4.Text = Str;
            StreamWriter stwm = new StreamWriter("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\KILLER\\killer_Digit.txt");
            stwm.Write(richTextBox4.Text);
            stwm.Close();
            richTextBox3.Text = "";
            richTextBox2.Text = "";
            richTextBox4.Text = "";

        }
        //نمایش اطلاعات قاتل
        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader(@"C:\Users\M\Desktop\Proj_FatemehSadatMusavi_98125173\Proj_FatemehSadatMusavi_98125173\Killer.txt");
            richTextBox3.Text = str.ReadToEnd();
            str.Close();
        }
        //بخش هفتم
        private void button7_Click(object sender, EventArgs e)
        {
            DNA_DATA.caesarA();
        }
        //بخش هشتم
        private void button10_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = DNA_DATA.caesarB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox4.BackColor = Color.Yellow;
            richTextBox4.Text += DNA_DATA.killer();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
          richTextBox2.Text=   DNA_DATA.m().ToString();

        }
    }
}
