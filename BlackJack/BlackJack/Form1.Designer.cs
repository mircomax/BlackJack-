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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltitolopanel = new System.Windows.Forms.Label();
            this.StaiButton = new System.Windows.Forms.Button();
            this.CartaButton = new System.Windows.Forms.Button();
            this.Carta3User = new System.Windows.Forms.Button();
            this.Carta4User = new System.Windows.Forms.Button();
            this.Carta5User = new System.Windows.Forms.Button();
            this.carta4Dealer = new System.Windows.Forms.Button();
            this.carta3Dealer = new System.Windows.Forms.Button();
            this.carta5Dealer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Carta2User
            // 
            this.Carta2User.Location = new System.Drawing.Point(517, 458);
            this.Carta2User.Name = "Carta2User";
            this.Carta2User.Size = new System.Drawing.Size(118, 170);
            this.Carta2User.TabIndex = 0;
            this.Carta2User.UseVisualStyleBackColor = true;
            // 
            // Carta1User
            // 
            this.Carta1User.Location = new System.Drawing.Point(427, 458);
            this.Carta1User.Name = "Carta1User";
            this.Carta1User.Size = new System.Drawing.Size(118, 170);
            this.Carta1User.TabIndex = 1;
            this.Carta1User.UseVisualStyleBackColor = true;
            // 
            // Carta1Dealer
            // 
            this.Carta1Dealer.BackgroundImage = global::BlackJack.Properties.Resources.retrocarta;
            this.Carta1Dealer.Location = new System.Drawing.Point(427, 53);
            this.Carta1Dealer.Name = "Carta1Dealer";
            this.Carta1Dealer.Size = new System.Drawing.Size(118, 170);
            this.Carta1Dealer.TabIndex = 2;
            this.Carta1Dealer.UseVisualStyleBackColor = true;
            // 
            // Carta2Dealer
            // 
            this.Carta2Dealer.Location = new System.Drawing.Point(511, 53);
            this.Carta2Dealer.Name = "Carta2Dealer";
            this.Carta2Dealer.Size = new System.Drawing.Size(118, 170);
            this.Carta2Dealer.TabIndex = 3;
            this.Carta2Dealer.UseVisualStyleBackColor = true;
            // 
            // labeltotaleuser
            // 
            this.labeltotaleuser.AutoSize = true;
            this.labeltotaleuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotaleuser.Location = new System.Drawing.Point(505, 413);
            this.labeltotaleuser.Name = "labeltotaleuser";
            this.labeltotaleuser.Size = new System.Drawing.Size(0, 28);
            this.labeltotaleuser.TabIndex = 4;
            this.labeltotaleuser.UseCompatibleTextRendering = true;
            this.labeltotaleuser.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeltotaledealer
            // 
            this.labeltotaledealer.AutoSize = true;
            this.labeltotaledealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotaledealer.Location = new System.Drawing.Point(508, 244);
            this.labeltotaledealer.Name = "labeltotaledealer";
            this.labeltotaledealer.Size = new System.Drawing.Size(0, 28);
            this.labeltotaledealer.TabIndex = 5;
            this.labeltotaledealer.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labeltitolopanel);
            this.panel1.Controls.Add(this.StaiButton);
            this.panel1.Controls.Add(this.CartaButton);
            this.panel1.Location = new System.Drawing.Point(317, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 280);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stai";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labeltitolopanel
            // 
            this.labeltitolopanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitolopanel.Location = new System.Drawing.Point(14, 10);
            this.labeltitolopanel.Name = "labeltitolopanel";
            this.labeltitolopanel.Size = new System.Drawing.Size(253, 19);
            this.labeltitolopanel.TabIndex = 2;
            this.labeltitolopanel.Text = "Seleziona cosa desideri fare:";
            // 
            // StaiButton
            // 
            this.StaiButton.BackColor = System.Drawing.Color.Red;
            this.StaiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StaiButton.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold);
            this.StaiButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.StaiButton.Location = new System.Drawing.Point(233, 38);
            this.StaiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaiButton.Name = "StaiButton";
            this.StaiButton.Size = new System.Drawing.Size(147, 133);
            this.StaiButton.TabIndex = 1;
            this.StaiButton.Text = "-";
            this.StaiButton.UseVisualStyleBackColor = false;
            this.StaiButton.Click += new System.EventHandler(this.StaiButton_Click);
            // 
            // CartaButton
            // 
            this.CartaButton.BackColor = System.Drawing.Color.Lime;
            this.CartaButton.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartaButton.Location = new System.Drawing.Point(38, 38);
            this.CartaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartaButton.Name = "CartaButton";
            this.CartaButton.Size = new System.Drawing.Size(147, 133);
            this.CartaButton.TabIndex = 0;
            this.CartaButton.Text = "+";
            this.CartaButton.UseVisualStyleBackColor = false;
            this.CartaButton.Click += new System.EventHandler(this.CartaButton_Click);
            // 
            // Carta3User
            // 
            this.Carta3User.Location = new System.Drawing.Point(600, 458);
            this.Carta3User.Name = "Carta3User";
            this.Carta3User.Size = new System.Drawing.Size(118, 170);
            this.Carta3User.TabIndex = 7;
            this.Carta3User.UseVisualStyleBackColor = true;
            this.Carta3User.Visible = false;
            // 
            // Carta4User
            // 
            this.Carta4User.Location = new System.Drawing.Point(683, 458);
            this.Carta4User.Name = "Carta4User";
            this.Carta4User.Size = new System.Drawing.Size(118, 170);
            this.Carta4User.TabIndex = 8;
            this.Carta4User.UseVisualStyleBackColor = true;
            this.Carta4User.Visible = false;
            // 
            // Carta5User
            // 
            this.Carta5User.Location = new System.Drawing.Point(765, 458);
            this.Carta5User.Name = "Carta5User";
            this.Carta5User.Size = new System.Drawing.Size(118, 170);
            this.Carta5User.TabIndex = 9;
            this.Carta5User.UseVisualStyleBackColor = true;
            this.Carta5User.Visible = false;
            // 
            // carta4Dealer
            // 
            this.carta4Dealer.Location = new System.Drawing.Point(683, 53);
            this.carta4Dealer.Name = "carta4Dealer";
            this.carta4Dealer.Size = new System.Drawing.Size(118, 170);
            this.carta4Dealer.TabIndex = 11;
            this.carta4Dealer.UseVisualStyleBackColor = true;
            this.carta4Dealer.Visible = false;
            // 
            // carta3Dealer
            // 
            this.carta3Dealer.Location = new System.Drawing.Point(597, 53);
            this.carta3Dealer.Name = "carta3Dealer";
            this.carta3Dealer.Size = new System.Drawing.Size(118, 170);
            this.carta3Dealer.TabIndex = 10;
            this.carta3Dealer.UseVisualStyleBackColor = true;
            this.carta3Dealer.Visible = false;
            // 
            // carta5Dealer
            // 
            this.carta5Dealer.Location = new System.Drawing.Point(765, 53);
            this.carta5Dealer.Name = "carta5Dealer";
            this.carta5Dealer.Size = new System.Drawing.Size(118, 170);
            this.carta5Dealer.TabIndex = 12;
            this.carta5Dealer.UseVisualStyleBackColor = true;
            this.carta5Dealer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1055, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.carta5Dealer);
            this.Controls.Add(this.carta4Dealer);
            this.Controls.Add(this.Carta5User);
            this.Controls.Add(this.Carta4User);
            this.Controls.Add(this.carta3Dealer);
            this.Controls.Add(this.Carta3User);
            this.Controls.Add(this.labeltotaledealer);
            this.Controls.Add(this.labeltotaleuser);
            this.Controls.Add(this.Carta2Dealer);
            this.Controls.Add(this.Carta1Dealer);
            this.Controls.Add(this.Carta2User);
            this.Controls.Add(this.Carta1User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StaiButton;
        private System.Windows.Forms.Button CartaButton;
        private System.Windows.Forms.Label labeltitolopanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Carta3User;
        private System.Windows.Forms.Button Carta4User;
        private System.Windows.Forms.Button Carta5User;
        private System.Windows.Forms.Button carta4Dealer;
        private System.Windows.Forms.Button carta3Dealer;
        private System.Windows.Forms.Button carta5Dealer;
    }
}

