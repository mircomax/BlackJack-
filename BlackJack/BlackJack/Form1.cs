using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        //Button bottone1;
        Carta carta1Dealer;
        Carta carta2Dealer;
        Carta carta1User;
        Carta carta2User;
        Random random;
        int TotaleGiocatore, TotaleDealer;
        public Form1()
        {
            /*bottone1 = new Button()
            {
                Size = new System.Drawing.Size(107, 170),
                Location = new System.Drawing.Point(784,500),
                Text = "Bottone1",
                Font = new Font("Microsoft sans serif", 8, FontStyle.Regular)
            };
            this.Controls.Add(bottone1);*/
            random = new Random();
            InitializeComponent();
            AssegnaPrimeCarte();
        }

        private void AssegnaPrimeCarte()
        {
            carta1Dealer = new Carta(random);
            Carta1Dealer.BackgroundImageLayout = ImageLayout.Stretch;
            Carta1Dealer.BackgroundImage = new Bitmap(carta1Dealer.getImage());

            carta2Dealer = new Carta(random);
            Carta2Dealer.BackgroundImageLayout = ImageLayout.Stretch;
            Carta2Dealer.BackgroundImage = new Bitmap(carta2Dealer.getImage());

            TotaleDealer = carta2Dealer.getValore() + carta1Dealer.getValore();
            labeltotaledealer.Text = TotaleDealer.ToString();  //Scrivere nella label il totale

            carta1User = new Carta(random);
            Carta1User.BackgroundImageLayout = ImageLayout.Stretch;
            Carta1User.BackgroundImage = new Bitmap(carta1User.getImage());

            carta2User = new Carta(random);   
            Carta2User.BackgroundImageLayout = ImageLayout.Stretch;
            Carta2User.BackgroundImage = new Bitmap(carta2User.getImage());

            TotaleGiocatore = carta2User.getValore() + carta1User.getValore();
            labeltotaleuser.Text = TotaleGiocatore.ToString(); //Scrivere nella label il totale
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
