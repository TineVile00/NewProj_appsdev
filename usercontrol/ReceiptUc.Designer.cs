namespace usercontrol
{
    partial class ReceiptUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptUc));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            RECEIPT = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 9, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 560);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 227);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RECEIPT);
            panel2.Location = new Point(262, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 458);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(395, 347);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 4;
            label3.Text = " TOTAL:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(446, 402);
            button1.Name = "button1";
            button1.Size = new Size(103, 28);
            button1.TabIndex = 3;
            button1.Text = "Print Receipt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 140);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "ORDER: ";
            // 
            // RECEIPT
            // 
            RECEIPT.AutoSize = true;
            RECEIPT.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            RECEIPT.Location = new Point(6, 8);
            RECEIPT.Name = "RECEIPT";
            RECEIPT.Size = new Size(119, 39);
            RECEIPT.TabIndex = 0;
            RECEIPT.Text = "Receipt";
            // 
            // ReceiptUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReceiptUc";
            Size = new Size(850, 560);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label RECEIPT;
    }
}
