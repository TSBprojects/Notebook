using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Записная_книжка
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        private void Yes_Click(object sender, EventArgs e)
        {
            if (f1.dellAll)
            {
                f1.DellAllNote();
                f1.dellAll = false;
                Close();
            }
            else
            {
                if (checkBox1.Checked) f1.dellNote = false;
                f1.DellNote(); Close();
            }
        }
        private void No_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked) f1.dellNote = false;
            f1.dellAll = false;
            Close();
        }
    }
}
