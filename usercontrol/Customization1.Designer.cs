namespace usercontrol
{
    partial class Customization1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SizeComBox = new ComboBox();
            TopComboBox = new ComboBox();
            AddComBox = new ComboBox();
            MessageTxtBox = new TextBox();
            ImgButton = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Size:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 118);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Toppings:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 209);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Additional:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(212, 36);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 3;
            label4.Text = "Message:";
            // 
            // SizeComBox
            // 
            SizeComBox.BackColor = SystemColors.ActiveCaption;
            SizeComBox.FormattingEnabled = true;
            SizeComBox.Location = new Point(16, 71);
            SizeComBox.Name = "SizeComBox";
            SizeComBox.Size = new Size(137, 23);
            SizeComBox.TabIndex = 4;
            // 
            // TopComboBox
            // 
            TopComboBox.BackColor = SystemColors.ActiveCaption;
            TopComboBox.FormattingEnabled = true;
            TopComboBox.Location = new Point(16, 155);
            TopComboBox.Name = "TopComboBox";
            TopComboBox.Size = new Size(137, 23);
            TopComboBox.TabIndex = 5;
            // 
            // AddComBox
            // 
            AddComBox.BackColor = SystemColors.ActiveCaption;
            AddComBox.FormattingEnabled = true;
            AddComBox.Location = new Point(16, 249);
            AddComBox.Name = "AddComBox";
            AddComBox.Size = new Size(137, 23);
            AddComBox.TabIndex = 6;
            // 
            // MessageTxtBox
            // 
            MessageTxtBox.Location = new Point(212, 71);
            MessageTxtBox.Name = "MessageTxtBox";
            MessageTxtBox.Size = new Size(182, 23);
            MessageTxtBox.TabIndex = 7;
            // 
            // ImgButton
            // 
            ImgButton.BackColor = SystemColors.ActiveCaption;
            ImgButton.Location = new Point(214, 115);
            ImgButton.Name = "ImgButton";
            ImgButton.Size = new Size(75, 23);
            ImgButton.TabIndex = 8;
            ImgButton.Text = "Img";
            ImgButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(295, 125);
            label5.Name = "label5";
            label5.Size = new Size(72, 12);
            label5.TabIndex = 9;
            label5.Text = ".jpg, .png, .jpeg";
            label5.Click += label5_Click;
            // 
            // Customization1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(ImgButton);
            Controls.Add(MessageTxtBox);
            Controls.Add(AddComBox);
            Controls.Add(TopComboBox);
            Controls.Add(SizeComBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customization1";
            Size = new Size(460, 340);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox SizeComBox;
        private ComboBox TopComboBox;
        private ComboBox AddComBox;
        private TextBox MessageTxtBox;
        private Button ImgButton;
        private Label label5;
    }
}
