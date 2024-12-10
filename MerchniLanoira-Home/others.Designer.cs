namespace MerchniLanoira_Home
{
    partial class others
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(others));
            label3 = new Label();
            Price = new Label();
            label2 = new Label();
            label1 = new Label();
            BackButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(493, 371);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 55;
            label3.Text = "[Price]";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.ForeColor = SystemColors.ControlDarkDark;
            Price.Location = new Point(123, 371);
            Price.Name = "Price";
            Price.Size = new Size(66, 25);
            Price.TabIndex = 54;
            Price.Text = "[Price]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(493, 341);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 53;
            label2.Text = "Cherry On Top Eco Tote Bag\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 341);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 52;
            label1.Text = "Cherry On Top Flag\r\n";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 51;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(96, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(468, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // others
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(Price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Name = "others";
            Text = "others";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label Price;
        private Label label2;
        private Label label1;
        private Button BackButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}