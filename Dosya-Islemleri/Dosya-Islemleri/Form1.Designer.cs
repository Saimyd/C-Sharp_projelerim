namespace Dosya_Islemleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnKonumSec = new Button();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFileDialog = new Button();
            btnSaveFileDialog = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label2 = new Label();
            textBox1 = new TextBox();
            btnKonum = new Button();
            btnOlustur = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            btnOku = new Button();
            listBox1 = new ListBox();
            btnYazdır = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnKonumSec
            // 
            btnKonumSec.Location = new Point(659, 40);
            btnKonumSec.Margin = new Padding(3, 4, 3, 4);
            btnKonumSec.Name = "btnKonumSec";
            btnKonumSec.Size = new Size(197, 31);
            btnKonumSec.TabIndex = 0;
            btnKonumSec.Text = "Folder brovser dialog";
            btnKonumSec.UseVisualStyleBackColor = true;
            btnKonumSec.Click += btnKonumSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(659, 114);
            btnOpenFileDialog.Margin = new Padding(3, 4, 3, 4);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(197, 31);
            btnOpenFileDialog.TabIndex = 2;
            btnOpenFileDialog.Text = "Open File Dialog";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // btnSaveFileDialog
            // 
            btnSaveFileDialog.Location = new Point(659, 184);
            btnSaveFileDialog.Margin = new Padding(3, 4, 3, 4);
            btnSaveFileDialog.Name = "btnSaveFileDialog";
            btnSaveFileDialog.Size = new Size(197, 31);
            btnSaveFileDialog.TabIndex = 3;
            btnSaveFileDialog.Text = "Save File Dialog";
            btnSaveFileDialog.UseVisualStyleBackColor = true;
            btnSaveFileDialog.Click += btnSaveFileDialog_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 27);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Belge Yolu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 5;
            // 
            // btnKonum
            // 
            btnKonum.Location = new Point(659, 252);
            btnKonum.Margin = new Padding(3, 4, 3, 4);
            btnKonum.Name = "btnKonum";
            btnKonum.Size = new Size(197, 31);
            btnKonum.TabIndex = 6;
            btnKonum.Text = "Konum Seç";
            btnKonum.UseVisualStyleBackColor = true;
            btnKonum.Click += btnKonum_Click;
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(659, 329);
            btnOlustur.Margin = new Padding(3, 4, 3, 4);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(197, 31);
            btnOlustur.TabIndex = 7;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 84);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Belge Adı";
            // 
            // btnOku
            // 
            btnOku.Location = new Point(659, 390);
            btnOku.Margin = new Padding(3, 4, 3, 4);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(197, 31);
            btnOku.TabIndex = 10;
            btnOku.Text = "Oku";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(476, 164);
            listBox1.TabIndex = 11;
            // 
            // btnYazdır
            // 
            btnYazdır.Location = new Point(659, 450);
            btnYazdır.Margin = new Padding(3, 4, 3, 4);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.Size = new Size(197, 31);
            btnYazdır.TabIndex = 12;
            btnYazdır.Text = "Yazdır";
            btnYazdır.UseVisualStyleBackColor = true;
            btnYazdır.Click += btnYazdır_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(20, 331);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(476, 167);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(richTextBox1);
            Controls.Add(btnYazdır);
            Controls.Add(listBox1);
            Controls.Add(btnOku);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnOlustur);
            Controls.Add(btnKonum);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnSaveFileDialog);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(label1);
            Controls.Add(btnKonumSec);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnKonumSec;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFileDialog;
        private Button btnSaveFileDialog;
        private SaveFileDialog saveFileDialog1;
        private Label label2;
        private TextBox textBox1;
        private Button btnKonum;
        private Button btnOlustur;
        private TextBox textBox2;
        private Label label3;
        private Button btnOku;
        private ListBox listBox1;
        private Button btnYazdır;
        private RichTextBox richTextBox1;
    }
}
