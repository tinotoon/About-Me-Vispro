namespace VisproAssignment
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 33F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 53);
            label1.TabIndex = 0;
            label1.Text = "ABOUT ME";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_09_20_at_19_491;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 17.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(325, 62);
            label2.Name = "label2";
            label2.Size = new Size(321, 28);
            label2.TabIndex = 2;
            label2.Text = "Nama : Falentino Marky Tombeng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 17.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(325, 97);
            label3.Name = "label3";
            label3.Size = new Size(283, 28);
            label3.TabIndex = 3;
            label3.Text = "TTL : Manado, 7 Februari 2004";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 17.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(325, 132);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 4;
            label4.Text = "Status : Mahasiswa";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Bebas Neue", 17.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Biasanya di kenal dengan nama Falen.", "Saat ini sebagai Mahasiswa di Fakultas Ilmu Komputer,", "Universitas Klabat.", "Seperti yang ada di gambar, memiliki hobi yang", "berhubungan dengan otomotif khususnya motor.", "Sekian dan Terima Kasih." });
            listBox1.Location = new Point(325, 178);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 172);
            listBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(436, 371);
            label5.Name = "label5";
            label5.Size = new Size(224, 25);
            label5.TabIndex = 6;
            label5.Text = "Contact : 0821-9607-0955";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(791, 424);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
    }
}