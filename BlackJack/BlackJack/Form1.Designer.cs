namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Carta2User = new System.Windows.Forms.Button();
            this.Carta1User = new System.Windows.Forms.Button();
            this.Carta1Dealer = new System.Windows.Forms.Button();
            this.Carta2Dealer = new System.Windows.Forms.Button();
            this.labeltotaleuser = new System.Windows.Forms.Label();
            this.labeltotaledealer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Carta2User
            // 
            this.Carta2User.Location = new System.Drawing.Point(553, 585);
            this.Carta2User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Carta2User.Name = "Carta2User";
            this.Carta2User.Size = new System.Drawing.Size(133, 212);
            this.Carta2User.TabIndex = 0;
            this.Carta2User.UseVisualStyleBackColor = true;
            // 
            // Carta1User
            // 
            this.Carta1User.Location = new System.Drawing.Point(461, 585);
            this.Carta1User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Carta1User.Name = "Carta1User";
            this.Carta1User.Size = new System.Drawing.Size(133, 212);
            this.Carta1User.TabIndex = 1;
            this.Carta1User.UseVisualStyleBackColor = true;
            // 
            // Carta1Dealer
            // 
            this.Carta1Dealer.Location = new System.Drawing.Point(461, 79);
            this.Carta1Dealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Carta1Dealer.Name = "Carta1Dealer";
            this.Carta1Dealer.Size = new System.Drawing.Size(133, 212);
            this.Carta1Dealer.TabIndex = 2;
            this.Carta1Dealer.UseVisualStyleBackColor = true;
            // 
            // Carta2Dealer
            // 
            this.Carta2Dealer.Location = new System.Drawing.Point(553, 79);
            this.Carta2Dealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Carta2Dealer.Name = "Carta2Dealer";
            this.Carta2Dealer.Size = new System.Drawing.Size(133, 212);
            this.Carta2Dealer.TabIndex = 3;
            this.Carta2Dealer.UseVisualStyleBackColor = true;
            // 
            // labeltotaleuser
            // 
            this.labeltotaleuser.AutoSize = true;
            this.labeltotaleuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotaleuser.Location = new System.Drawing.Point(549, 529);
            this.labeltotaleuser.Name = "labeltotaleuser";
            this.labeltotaleuser.Size = new System.Drawing.Size(0, 32);
            this.labeltotaleuser.TabIndex = 4;
            this.labeltotaleuser.UseCompatibleTextRendering = true;
            this.labeltotaleuser.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeltotaledealer
            // 
            this.labeltotaledealer.AutoSize = true;
            this.labeltotaledealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotaledealer.Location = new System.Drawing.Point(553, 318);
            this.labeltotaledealer.Name = "labeltotaledealer";
            this.labeltotaledealer.Size = new System.Drawing.Size(0, 32);
            this.labeltotaledealer.TabIndex = 5;
            this.labeltotaledealer.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1187, 851);
            this.Controls.Add(this.labeltotaledealer);
            this.Controls.Add(this.labeltotaleuser);
            this.Controls.Add(this.Carta2Dealer);
            this.Controls.Add(this.Carta1Dealer);
            this.Controls.Add(this.Carta2User);
            this.Controls.Add(this.Carta1User);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Carta2User;
        private System.Windows.Forms.Button Carta1User;
        private System.Windows.Forms.Button Carta1Dealer;
        private System.Windows.Forms.Button Carta2Dealer;
        private System.Windows.Forms.Label labeltotaleuser;
        private System.Windows.Forms.Label labeltotaledealer;
    }
}

