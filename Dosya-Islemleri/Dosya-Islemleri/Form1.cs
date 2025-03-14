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

        string belgeyolu, belgeadý;
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
            belgeadý = textBox2.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "//" + belgeadý + ".txt");
            MessageBox.Show("Belgeniz baþarýyla oluþturuldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satýr = sr.ReadLine();

                while (satýr != null)
                {
                    listBox1.Items.Add(satýr);
                    satýr = sr.ReadLine();
                }
            }
        }

        private void btnYazdýr_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyasý | *.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin belgesine kayýt yapýldý ", "bilgi" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
