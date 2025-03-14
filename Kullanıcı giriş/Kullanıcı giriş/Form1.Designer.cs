namespace Kullanıcı_giriş
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(284, 266);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 122);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adınız:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(304, 315);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 166);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Şifreniz:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(460, 270);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(164, 29);
            label3.Name = "label3";
            label3.Size = new Size(413, 57);
            label3.TabIndex = 8;
            label3.Text = "Admin Giriş Sayıfası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 213);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 10;
            label4.Text = "Kodu Girin:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(436, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 27);
            textBox4.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(779, 377);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
    }
}
