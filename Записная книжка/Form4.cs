using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Записная_книжка
{
    public partial class Form4 : Form
    {
        Form f1;
        public Form4(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.Transparent;
            int n = 0, start = 0, d = 0;
            while (n!=richTextBox1.Text.Length-SearchBox.Text.Length && SearchBox.Text != "")
            {
                n = richTextBox1.Find(SearchBox.Text, start, RichTextBoxFinds.MatchCase);
                if (n != -1)
                {
                    richTextBox1.SelectionBackColor = Color.LightBlue;
                    richTextBox1.Select(n, SearchBox.Text.Length);
                    start = n + SearchBox.Text.Length;
                }
                else break;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }
    }
}
