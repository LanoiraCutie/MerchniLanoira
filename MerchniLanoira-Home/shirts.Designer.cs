namespace MerchniLanoira_Home
{
    partial class shirts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shirts));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BackButton = new Button();
            label1 = new Label();
            label2 = new Label();
            Price = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(100, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(467, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 245);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 31;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 332);
            label1.Name = "label1";
            label1.Size = new Size(239, 20);
            label1.TabIndex = 32;
            label1.Text = "Cherry Crewneck Sweatshirt [Black]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 332);
            label2.Name = "label2";
            label2.Size = new Size(268, 20);
            label2.TabIndex = 39;
            label2.Text = "Cherry Crewneck Sweatshirt [Light Pink]";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.ForeColor = SystemColors.ControlDarkDark;
            Price.Location = new Point(100, 361);
            Price.Name = "Price";
            Price.Size = new Size(66, 25);
            Price.TabIndex = 40;
            Price.Text = "[Price]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(467, 361);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 41;
            label3.Text = "[Price]";
            // 
            // shirts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "shirts";
            Text = "shirts";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BackButton;
        private Label label1;
        private Label label2;
        private Label Price;
        private Label label3;
    }
}