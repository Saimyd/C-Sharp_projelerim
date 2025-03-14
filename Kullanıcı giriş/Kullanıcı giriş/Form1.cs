namespace Kullanıcı_giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kodOlustur()
        {
            Random rm = new Random();
            int sayi = rm.Next(10000, 100000);
            textBox4.Text = sayi.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kodOlustur();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "saim" && textBox2.Text == "saim" && textBox3.Text == textBox4.Text)
            {

                Form2 frm = new Form2();
                frm.kullanıcı = textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.sifre = textBox2.Text;
            frm.Show();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.BackColor = Color.Red;
            }
            else if (sayac % 2 == 1) 
            {
                label3.BackColor = Color.Green; 
            }
            else
            {
                sayac = 0;
            }

        }
    }
}
