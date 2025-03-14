namespace Dosya_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        string belgeyolu, belgead�;
        private void btnKonum_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                textBox1.Text = belgeyolu;

            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            belgead� = textBox2.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "//" + belgead� + ".txt");
            MessageBox.Show("Belgeniz ba�ar�yla olu�turuldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string sat�r = sr.ReadLine();

                while (sat�r != null)
                {
                    listBox1.Items.Add(sat�r);
                    sat�r = sr.ReadLine();
                }
            }
        }

        private void btnYazd�r_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyas� | *.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin belgesine kay�t yap�ld� ", "bilgi" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
