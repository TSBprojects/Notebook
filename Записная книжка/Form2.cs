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
    public partial class Form2 : Form
    {
        Match r;
        Form1 f1;
        bool a, b, c;
        public bool addnote = true;
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            if (addnote)
            {
                if (a&&b&&c)
                {
                    if (f1.lines.Count >= 18) f1.Next.Enabled = true;
                    f1.SaveNote(); Close();
                }
            }
            else if (a&&b&&c) {f1.ChangeNote(); Close();}
        }
        private void TextBox1TextChanged(object sender, EventArgs e)
		{
			a=ChName();
		}
		private void TextBox2TextChanged(object sender, EventArgs e)
		{
			b=ChEmail();
		}
		private void TextBox3TextChanged(object sender, EventArgs e)
		{
			c=ChPhone();
		}
        private bool ChName()
        {
        	r = Regex.Match(textBox1.Text, "^[^\\d\\s]{1,15}$");
            if (r.Value != "")
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Имя ✓";
                return true;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Некорректное имя! ✕";
                return false;
            }
        }
        private bool ChEmail()
        {
        	r = Regex.Match(textBox2.Text, "^([A-Za-z0-9_\\-\\.]){1,25}\\@([A-Za-z0-9_\\-\\.]){1,15}\\.([A-Za-z]{2,4})$");
            if (r.Value != "")
            {
                label2.ForeColor = Color.Green;
                label2.Text = "E-mail ✓";
                return true;
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Некорректный e-mail! ✕";
                return false;
            }
        }
        private bool ChPhone()
        {
        	r = Regex.Match(textBox3.Text, "^(8|\\+7)[\\- ]?(\\d{3}[\\- ]?){2}(\\d{2}[\\- ]?){2}$");
            if (r.Value != "")
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Мобильный телефон ✓";
                return true;
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Некорректный телефон! ✕";
                return false;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.ForeColor = Color.Black;
            label1.Text = "Введите имя";
            label2.ForeColor = Color.Black;
            label2.Text = "Введите e-mail";
            label3.ForeColor = Color.Black;
            label3.Text = "Введите мобильный телефон";
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
