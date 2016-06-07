namespace водка_Drinker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.VodkaPicture = new System.Windows.Forms.PictureBox();
            this.VodkaCounter = new System.Windows.Forms.Label();
            this.VodkaButton = new System.Windows.Forms.Button();
            this.ShopDistiller = new System.Windows.Forms.Button();
            this.DistillerTimer = new System.Windows.Forms.Timer(this.components);
            this.DistillerCounterLabel = new System.Windows.Forms.Label();
            this.DistillerPriceLabel = new System.Windows.Forms.Label();
            this.VodkaStrength = new System.Windows.Forms.Button();
            this.VodkaStrengthLabel = new System.Windows.Forms.Label();
            this.VodkaStrengthPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VodkaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // VodkaPicture
            // 
            this.VodkaPicture.BackgroundImage = global::водка_Drinker.Properties.Resources.russian_vodka_beluga;
            this.VodkaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VodkaPicture.Location = new System.Drawing.Point(438, 170);
            this.VodkaPicture.Name = "VodkaPicture";
            this.VodkaPicture.Size = new System.Drawing.Size(140, 129);
            this.VodkaPicture.TabIndex = 0;
            this.VodkaPicture.TabStop = false;
            this.VodkaPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VodkaCounter
            // 
            this.VodkaCounter.AutoSize = true;
            this.VodkaCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VodkaCounter.Location = new System.Drawing.Point(96, 82);
            this.VodkaCounter.Name = "VodkaCounter";
            this.VodkaCounter.Size = new System.Drawing.Size(124, 25);
            this.VodkaCounter.TabIndex = 1;
            this.VodkaCounter.Text = "Vodkas:  0";
            // 
            // VodkaButton
            // 
            this.VodkaButton.Location = new System.Drawing.Point(438, 305);
            this.VodkaButton.Name = "VodkaButton";
            this.VodkaButton.Size = new System.Drawing.Size(140, 94);
            this.VodkaButton.TabIndex = 2;
            this.VodkaButton.Text = "Make";
            this.VodkaButton.UseVisualStyleBackColor = true;
            this.VodkaButton.Click += new System.EventHandler(this.DrinkButton_Click);
            // 
            // ShopDistiller
            // 
            this.ShopDistiller.Location = new System.Drawing.Point(845, 170);
            this.ShopDistiller.Name = "ShopDistiller";
            this.ShopDistiller.Size = new System.Drawing.Size(75, 23);
            this.ShopDistiller.TabIndex = 3;
            this.ShopDistiller.Text = "Distiller";
            this.ShopDistiller.UseVisualStyleBackColor = true;
            this.ShopDistiller.Click += new System.EventHandler(this.ShopDistiller_Click);
            // 
            // DistillerTimer
            // 
            this.DistillerTimer.Interval = 1000;
            this.DistillerTimer.Tick += new System.EventHandler(this.DistillerTimer_Tick);
            // 
            // DistillerCounterLabel
            // 
            this.DistillerCounterLabel.AutoSize = true;
            this.DistillerCounterLabel.Location = new System.Drawing.Point(926, 175);
            this.DistillerCounterLabel.Name = "DistillerCounterLabel";
            this.DistillerCounterLabel.Size = new System.Drawing.Size(57, 13);
            this.DistillerCounterLabel.TabIndex = 4;
            this.DistillerCounterLabel.Text = "Distillers: 0";
            // 
            // DistillerPriceLabel
            // 
            this.DistillerPriceLabel.AutoSize = true;
            this.DistillerPriceLabel.Location = new System.Drawing.Point(862, 202);
            this.DistillerPriceLabel.Name = "DistillerPriceLabel";
            this.DistillerPriceLabel.Size = new System.Drawing.Size(49, 13);
            this.DistillerPriceLabel.TabIndex = 5;
            this.DistillerPriceLabel.Text = "Price: 50";
            // 
            // VodkaStrength
            // 
            this.VodkaStrength.Location = new System.Drawing.Point(837, 228);
            this.VodkaStrength.Name = "VodkaStrength";
            this.VodkaStrength.Size = new System.Drawing.Size(83, 23);
            this.VodkaStrength.TabIndex = 6;
            this.VodkaStrength.Text = "BetterVodkas";
            this.VodkaStrength.UseVisualStyleBackColor = true;
            this.VodkaStrength.Click += new System.EventHandler(this.VodkaStrength_Click);
            // 
            // VodkaStrengthLabel
            // 
            this.VodkaStrengthLabel.AutoSize = true;
            this.VodkaStrengthLabel.Location = new System.Drawing.Point(926, 233);
            this.VodkaStrengthLabel.Name = "VodkaStrengthLabel";
            this.VodkaStrengthLabel.Size = new System.Drawing.Size(84, 13);
            this.VodkaStrengthLabel.TabIndex = 7;
            this.VodkaStrengthLabel.Text = "Vodka Rating: 1";
            // 
            // VodkaStrengthPrice
            // 
            this.VodkaStrengthPrice.AutoSize = true;
            this.VodkaStrengthPrice.Location = new System.Drawing.Point(862, 263);
            this.VodkaStrengthPrice.Name = "VodkaStrengthPrice";
            this.VodkaStrengthPrice.Size = new System.Drawing.Size(55, 13);
            this.VodkaStrengthPrice.TabIndex = 8;
            this.VodkaStrengthPrice.Text = "Price: 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::водка_Drinker.Properties.Resources.Shop_Window_for_Game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.VodkaStrengthPrice);
            this.Controls.Add(this.VodkaStrengthLabel);
            this.Controls.Add(this.VodkaStrength);
            this.Controls.Add(this.DistillerPriceLabel);
            this.Controls.Add(this.DistillerCounterLabel);
            this.Controls.Add(this.ShopDistiller);
            this.Controls.Add(this.VodkaButton);
            this.Controls.Add(this.VodkaCounter);
            this.Controls.Add(this.VodkaPicture);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Vodka Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VodkaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VodkaPicture;
        private System.Windows.Forms.Label VodkaCounter;
        private System.Windows.Forms.Button VodkaButton;
        private System.Windows.Forms.Button ShopDistiller;
        private System.Windows.Forms.Timer DistillerTimer;
        private System.Windows.Forms.Label DistillerCounterLabel;
        private System.Windows.Forms.Label DistillerPriceLabel;
        private System.Windows.Forms.Button VodkaStrength;
        private System.Windows.Forms.Label VodkaStrengthLabel;
        private System.Windows.Forms.Label VodkaStrengthPrice;
    }
}

