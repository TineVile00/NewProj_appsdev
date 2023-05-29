namespace usercontrol
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
            receiptUc1 = new ReceiptUc();
            customization11 = new Customization1();
            SuspendLayout();
            // 
            // receiptUc1
            // 
            receiptUc1.BackColor = Color.White;
            receiptUc1.Location = new Point(0, -3);
            receiptUc1.Name = "receiptUc1";
            receiptUc1.Size = new Size(838, 530);
            receiptUc1.TabIndex = 0;
            // 
            // customization11
            // 
            customization11.Location = new Point(188, 80);
            customization11.Name = "customization11";
            customization11.Size = new Size(460, 340);
            customization11.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 521);
            Controls.Add(customization11);
            Controls.Add(receiptUc1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ReceiptUc receiptUc1;
        private Customization1 customization11;
    }
}