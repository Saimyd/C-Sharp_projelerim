using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_giriş
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         public string sifre;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = sifre ;
        }
    }
}
