using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Записная_книжка
{
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        Form4 f4; 
        public List<string> lines;
        public bool dellNote = true, dellAll = false;
        Button[] Chb = new Button[18];
        Button[] Db = new Button[18];
        Label[] labels = new Label[18];
        public int lineNum, cntrlNum, LineCount, index = 0, pageNum = 1;
        public Form1()
        {
            InitializeComponent();
            MyInitializeComponent();
            BindControls();
        }

        public void AddNote_Click(object sender, EventArgs e)
        {
            f2.addnote = true;
            f2.Text = "Добавление записи";
            f2.ShowDialog();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (lines.Count == 0) MessageBox.Show("Записи отсутсвуют!");
            else
            {
                string[] arr = new string[lines.Count];
                for (int i = 0; i < lines.Count; i++) arr[i] = (i + 1) + ". " + lines[i];
                f4.richTextBox1.Lines = arr;
                f4.ShowDialog();
            }
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            int j = 0;
            pageNum-=2; label19.Text=pageNum+""; label20.Text=(pageNum+1)+"";
            if (index - 36 == -18) Previous.Enabled = false;
            Next.Enabled=true;
            index -= 18;
            for (int i = index; i < index + 18; i++, j++)
                if (i < lines.Count) labels[j].Text = (i + 1)+". "+lines[i];
                else labels[j].Text = "";
            RefreshNotes();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            int j = 0;
            pageNum+=2; label19.Text=pageNum+""; label20.Text =(pageNum+1)+"";
            if (index+36 >= lines.Count) Next.Enabled = false;
            Previous.Enabled = true;
            index += 18;
            for (int i = index; i < index + 18; i++, j++)
                if (i < lines.Count) labels[j].Text = (i+1)+". "+lines[i];
                else labels[j].Text = "";         
            if (lines.Count-index<18) RefreshNotes();
        }
        private void Dell_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            cntrlNum = GetNumControls(b.Name) - 1;
            lineNum = index + cntrlNum;
            if (dellNote)
            {
                f3.Text = "Удалить запись";
                f3.label1.Text = "Вы действительно хотите удалить эту запись?";
                f3.checkBox1.Visible = true;
                f3.ShowDialog();
            }
            else DellNote();
        }
        private void Change_Click(object sender, EventArgs e)
        {
            f2.addnote = false;
            f2.Text = "Изменение записи";
            Button b = (Button)sender;
            lineNum = index+GetNumControls(b.Name)-1;
            f2.ShowDialog();
        }
        private void DellAll_Click(object sender, EventArgs e)
        {
            if (lines.Count == 0) MessageBox.Show("Записи отсутсвуют!");
            else
            {
                dellAll = true;
                f3.Text = "Удалить все записи";
                f3.label1.Text = "Вы действительно хотите удалить все записи?";
                f3.checkBox1.Visible = false;
                f3.ShowDialog();
            }
        }
        private void Note_Click(object sender, EventArgs e)
        {
            Label b = (Label)sender;
            lineNum = index + GetNumControls(b.Name) - 1;
            MessageBox.Show((lineNum + 1) + ". " + lines[lineNum], "Запись №" + (lineNum + 1));
        }
        private void Note_MouseMove(object sender, MouseEventArgs e)
        {
            Label b = (Label)sender;
            b.BackColor = Color.Gainsboro;
        }
        private void Note_MouseLeave(object sender, EventArgs e)
        {
            Label b = (Label)sender;
            b.BackColor = Color.Transparent;
        }

        public void ReadFile()
        {
            try{
                lines = File.ReadAllLines("NoteBook.save").ToList();
                LineCount = lines.Count;
                ReadNotes();
                RefreshNotes();
            }
            catch{LineCount = 0;}
        }
        public void SaveNote()
        {
            LineCount++;
            int k = lines.Count-index;
            label21.Text = "Всего записей: " + LineCount;
            lines.Add(f2.textBox1.Text+", "+f2.textBox2.Text+", "+f2.textBox3.Text);
            StreamWriter wr = new StreamWriter("NoteBook.save", true);
            if (k < 18)
            {
                labels[k].Text = LineCount+". "+lines[LineCount-1];
                labels[k].Visible = true;
                Chb[k].Visible = true;
                Db[k].Visible = true;
            }
            wr.WriteLine(lines[LineCount-1]);
            wr.Close();
            File.SetAttributes("NoteBook.save", FileAttributes.Hidden);
        }
        public void ChangeNote()
        {
            File.SetAttributes("NoteBook.save", FileAttributes.Normal);
            lines[lineNum] = f2.textBox1.Text+", "+f2.textBox2.Text+", "+f2.textBox3.Text;
            File.WriteAllLines("NoteBook.save", lines.ToArray());
            labels[lineNum-index].Text = (lineNum+1)+". "+lines[lineNum];
            File.SetAttributes("NoteBook.save", FileAttributes.Hidden);
        }
        public void DellNote()
        {
            File.SetAttributes("NoteBook.save", FileAttributes.Normal);
            LineCount--;
            lines.RemoveAt(lineNum);
            label21.Text = "Всего записей: " + LineCount;
            File.WriteAllLines("NoteBook.save", lines.ToArray());
            if (lines.Count <= 18) Next.Enabled = false;
            for (int i = cntrlNum; i < 18; i++, lineNum++)
                if (lineNum < lines.Count) labels[i].Text = (lineNum + 1) + ". " + lines[lineNum];
                else labels[i].Text = "";
            RefreshNotes();
            File.SetAttributes("NoteBook.save", FileAttributes.Hidden);
        }
        public void DellAllNote()
        {
            index=0;
            LineCount=0;
            lines.RemoveRange(0,lines.Count);
            pageNum=0; label19.Text="1"; label20.Text="2";
            label21.Text = "Всего записей: " + LineCount;
            Next.Enabled = false; Previous.Enabled = false;
            File.Delete("NoteBook.save");
            for (int i = 0; i < 18; i++) labels[i].Text = "";
            RefreshNotes();
        }
        public void ReadNotes()
        {
            for (int i = 0; i < lines.Count; i++) if(i<18) labels[i].Text = (i+1)+". "+lines[i];
            if(lines.Count>18) Next.Enabled=true;

        }
        public void RefreshNotes()
        {
            for (int i = 0; i < labels.Length; i++)
                if (labels[i].Text != "")
                {
                    labels[i].Visible = true;
                    Chb[i].Visible = true;
                    Db[i].Visible = true;
                }
                else
                {
                    labels[i].Visible = false;
                    Chb[i].Visible = false;
                    Db[i].Visible = false;
                }
        }

        private void GetControls()
        {
            int i = 0, j = 0, k = 0;
            foreach (Control l in NoteB.Controls)
            {
                if (l is Label) { labels[i] = ((Label)l); i++; }
                if (l is Button && l.Name[0] == 'C')
                { Chb[j] = ((Button)l); j++; }
                if (l is Button && l.Name[0] == 'D')
                { Db[k] = ((Button)l); k++; }
            }
            SortControls(labels); SortControls(Chb); SortControls(Db);
        }
        private void SortControls(Control[] arr)
        {
            int current;
            Control temp;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    current = GetNumControls(arr.ElementAt(i).Name) - 1;
                    if (current != i)
                    {
                        temp = arr[current];
                        arr[current] = arr[i];
                        arr[i] = temp;
                        flag = true;
                    }
                }
            }
        }
        private int GetNumControls(string s)
        {
            if (s.Length == 7 || s.Length == 3) return Convert.ToInt32(s[s.Length - 2] + "" + s[s.Length - 1]);
            else return Convert.ToInt32(s[s.Length - 1] + "");
        }

        private void BindControls()
        {
            AddNote.Parent = Background;
            DellAll.Parent = Background;
            Search.Parent = Background;
            Previous.Parent = Background;
            Next.Parent = Background;
            NoteB.Parent = Background;
            label19.Parent = NoteB;
            label19.Location = new Point(label19.Location.X, label19.Location.Y-55);
            label20.Parent = NoteB;
            label20.Location = new Point(label20.Location.X, label20.Location.Y-55);
            label21.Parent = NoteB;
            label21.Location = new Point(label21.Location.X, label21.Location.Y - 55);
        }
        private void MyInitializeComponent()
        {
            lines = new List<string>();
            GetControls();
            ReadFile();
            label21.Text = "Всего записей: "+LineCount;
            f2 = new Form2(this);
            f3 = new Form3(this);
            f4 = new Form4(this);
        }
    }
}
