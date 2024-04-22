using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Proj_FatemehSadatMusavi_98125173
{
    class DNA_DATA
    {
        public void loading()
        {
            Form1 frm1 = new Form1();
            frm1 = new Form1();

            string[] uu = File.ReadAllLines("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\Data.txt");

            for (int i = 1, l = 1; i <= 60 && l < 600; i++, l = l + 2)
            {
                string a = i.ToString();
                string folderName = string.Concat("C:\\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\DNA DATA\\.", a);

                for (int j = 1; j <= 10; j++)
                {
                    string b = j.ToString();
                    string pathString = System.IO.Path.Combine(folderName, b);
                    System.IO.Directory.CreateDirectory(pathString);
                    string textpath = string.Concat(pathString, "000000_DNA.txt");
                    FileStream dna = new FileStream(textpath, FileMode.Create);
                    dna.Close();
                    StreamWriter stw = new StreamWriter(textpath);
                    if (j % 2 == 0)
                    {
                        stw.Write(uu[l + j]);
                        stw.Close();
                    }
                    else if (j % 2 != 0)
                    {
                        stw.Write(uu[l + j - 1]);
                        stw.Close();
                    }
                    string textpathe = string.Concat(pathString, "000000_Info.txt");
                    FileStream info = new FileStream(textpathe, FileMode.Create);
                    info.Close();
                    string texttpathe = string.Concat(pathString, "000000_Digit.txt");
                    FileStream digit = new FileStream(texttpathe, FileMode.Create);
                    digit.Close();
                    string texttppathe = string.Concat(pathString, "000000_Dna_ENC.txt");
                    FileStream Enc = new FileStream(texttppathe, FileMode.Create);
                    Enc.Close();

                }
            }



        }

        public void openfile()
        {
            //دریافت توالی
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            DialogResult dr;
            dr = frm1.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool ex = File.Exists(frm1.openFileDialog1.FileName);
                if (ex)
                {
                    StreamReader str = new StreamReader(frm1.openFileDialog1.FileName);
                    frm1.richTextBox1.Text = str.ReadToEnd();
                    str.Close();
                }
            }
            //شمارش کاراکتر ها
            string source = frm1.richTextBox1.Text;
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
            string e = "E=" + ecount.ToString();
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
            string alphabet = a + ";" + b + ";" + c2 + ";" + d + ";" + e + ";" + f + ";" + g + ";" + h + ";" + i + ";" + j + ";" + k + ";" + l + ";" + m + ";" + n + ";" + o + ";" + p + ";" + q + ";" + r + ";" + w + ";" + z + ";" + x + ";" + y + ";" + u + ";" + s + ";" + t + ";" + v;
            frm1.richTextBox2.Text = alphabet;
            SaveFileDialog saveFile1 = new SaveFileDialog();
            DialogResult drr = saveFile1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool exx = File.Exists(saveFile1.FileName);
                if (exx)
                {
                    StreamWriter stw = new StreamWriter(saveFile1.FileName);
                    stw.Write(frm1.richTextBox2.Text);
                    stw.Close();
                }
            }


        }
        public void digitfile()
        {
            //توالی بگیره
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            frm1.richTextBox2.Clear();
            DialogResult dr;
            dr = frm1.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool ex = File.Exists(frm1.openFileDialog1.FileName);
                if (ex)
                {
                    StreamReader str = new StreamReader(frm1.openFileDialog1.FileName);
                    frm1.richTextBox2.Text = str.ReadToEnd();
                    str.Close();
                }
            }

            string read = frm1.richTextBox2.Text;
            //تبدیل به کداسکی
            string Str = "";
            foreach (char C in read)
            {
                Str = Str + "-" + (Convert.ToInt32(C)).ToString();
            }
            frm1.richTextBox3.Text = Str;
            SaveFileDialog saveFile1 = new SaveFileDialog();
            DialogResult drr = saveFile1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool exx = File.Exists(saveFile1.FileName);
                if (exx)
                {
                    StreamWriter stw = new StreamWriter(saveFile1.FileName);
                    stw.Write(frm1.richTextBox3.Text);
                    stw.Close();
                }
            }
        }
        //بخش هفتم
        //انکودر سزار
        public void caesarA()
        {
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            frm1.richTextBox4.Clear();
            DialogResult dr;
            dr = frm1.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool ex = File.Exists(frm1.openFileDialog1.FileName);
                if (ex)
                {
                    StreamReader str = new StreamReader(frm1.openFileDialog1.FileName);
                    frm1.richTextBox4.Text = str.ReadToEnd();
                    str.Close();
                }
                string read = frm1.richTextBox4.Text;
                string Str = "";
                foreach (char C in read)
                {
                    int d = Convert.ToInt32(C) + 5;
                    Str = char.ConvertFromUtf32(d);
                    frm1.richTextBox2.Text += Str;
                }
                SaveFileDialog saveFile1 = new SaveFileDialog();
                DialogResult drr = saveFile1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bool exx = File.Exists(saveFile1.FileName);
                    if (exx)
                    {
                        StreamWriter stw = new StreamWriter(saveFile1.FileName);
                        stw.Write(frm1.richTextBox2.Text);
                        stw.Close();
                    }
                }

            }
        }
        //بخش هشتم
        public object caesarB()
        {
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            frm1.richTextBox3.Clear();
            DialogResult dr;
            dr = frm1.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool ex = File.Exists(frm1.openFileDialog1.FileName);
                if (ex)
                {
                    StreamReader str = new StreamReader(frm1.openFileDialog1.FileName);
                    frm1.richTextBox3.Text = str.ReadToEnd();
                    str.Close();
                }
            }
            string read = frm1.richTextBox3.Text;
            string t = "";
            foreach (char C in read)
            {
                int d = Convert.ToInt32(C) - 5;
            string Str =  char.ConvertFromUtf32(d) ;
                t += C + "=" +Str+";";
            }
            frm1.richTextBox4.Text = t.Remove(t.Length-1,1);
            string[] rowss = frm1.richTextBox4.Text.Split(';');
            DataTable dt = new DataTable();
            dt.Columns.Add("کد");
            dt.Columns.Add("رمزگشایی");


            for (int i = 0; i < rowss.Length; i++)
            {
                string[] col_1 = rowss[i].ToString().Split('=');
                dt.Rows.Add(col_1[0], col_1[1]);
            }

         return  dt;

        }
        //بخش پنجم
        public string killer()
        {
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            int [,] sum  = new int [60,10];
            int t =0;
            int min = 0;
            string s = "";
            string[] uu = File.ReadAllLines("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\Data.txt");

            for (int j = 0; j < 60; j++)
            {
                for (int i = 1, k = 0; i < 1200 ; i += 2, k=(k+1)%10)

                {
                    foreach (char C in uu[i])
                    {
                        t += Convert.ToInt32(C);

                    }

                    int l = 1961 - t;

                    sum[j, k] = l;

                    t = 0;
                    
                }
               
            }
            string keshvar = "";
            string shomare = "";
            for (int j = 0; j < 60; j++)
            {
                min = sum[j, 0];
                for (int k = 0; k < 10; k++)
                {
                    if (sum[j, k] < min)
                    {
                        min = sum[j, k];
                        keshvar = j.ToString();
                        shomare = k.ToString();
                        
                    }
                }
            }
            s += "Search results = "+ min.ToString() + " show the person with ID = " + shomare+ " from "+ keshvar+"th country is most likely to be the main suspect" ;
            return s;
        }
     
        public int m ()
        {
            Form1 frm1 = new Form1();
            frm1 = new Form1();
            int[,] sum = new int[60, 10];
            int t = 0;
           
            string[] uu = File.ReadAllLines("C: \\Users\\M\\Desktop\\Proj_FatemehSadatMusavi_98125173\\Proj_FatemehSadatMusavi_98125173\\Data.txt");
            int j = 0;
            int k = 0;
            for (j = 0; j < 60; j++)
            {
                for (int i = 1; i < 1200; i += 2, k = (k + 1) % 10)

                {
                    foreach (char C in uu[i])
                    {
                        t += Convert.ToInt32(C);

                    }

                    int l = 1961 - t;

                    sum[j, k] = l;

                    t = 0;

                }

           
               
            }
            int h = 0;
            for (int z = 0; z < k; z++)
            {
                int minm = sum[0, z];
                for (int s = 1; s < j; s++)
                {
                    if (sum[k, j] < minm) minm = sum[k, j];
                }
                h = minm;

            }
            return h;

            

        }

        }
    }


        
           

   




