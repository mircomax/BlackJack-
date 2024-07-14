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
        Carta[] nuovecarteuser;
        Carta[] nuovecartedealer;
        int TotaleGiocatore, TotaleDealer;
        int contanumcarteuser = 0;
        int contanumcartedealer = 0;
        public Form1()
        {
            nuovecarteuser = new Carta[3];
            nuovecartedealer = new Carta[3];
            panel1 = new Panel();
            panel1.Visible = false;
            random = new Random();
            InitializeComponent();
            AssegnaPrimeCarte();
            Aspetta();
        }
        private async void Aspetta()
        {
            await Task.Delay(3000);
            panel1.Visible = true;
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

        private void CartaButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            switch (contanumcarteuser) { //switch per far comparire le altre carte quando viene schiacciato il tasto carta
                case 0:
                    Carta3User.Visible = true;
                    nuovecarteuser[contanumcarteuser] = new Carta(random);
                    Carta3User.BackgroundImageLayout = ImageLayout.Stretch;
                    Carta3User.BackgroundImage = new Bitmap(nuovecarteuser[contanumcarteuser].getImage());
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore();
                    contanumcarteuser++;
                break;
                case 1:
                    Carta4User.Visible = true;
                    nuovecarteuser[contanumcarteuser] = new Carta(random);
                    Carta4User.BackgroundImageLayout = ImageLayout.Stretch;
                    Carta4User.BackgroundImage = new Bitmap(nuovecarteuser[contanumcarteuser].getImage());
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore();
                    contanumcarteuser++;
                break;
                case 2:
                    Carta5User.Visible = true;
                    nuovecarteuser[contanumcarteuser] = new Carta(random);
                    Carta5User.BackgroundImageLayout = ImageLayout.Stretch;
                    Carta5User.BackgroundImage = new Bitmap(nuovecarteuser[contanumcarteuser].getImage());
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore();
                    contanumcarteuser++;
                break;
            }
            labeltotaleuser.Text = TotaleGiocatore.ToString();
            Aspetta();
        }

        private void StaiButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            while(TotaleDealer < 17)
            {
                switch (contanumcartedealer)
                { //switch per far comparire le altre carte quando viene schiacciato il tasto stai
                    case 0:
                        carta3Dealer.Visible = true;
                        nuovecartedealer[contanumcartedealer] = new Carta(random);
                        carta3Dealer.BackgroundImageLayout = ImageLayout.Stretch;
                        carta3Dealer.BackgroundImage = new Bitmap(nuovecartedealer[contanumcartedealer].getImage());
                        TotaleDealer += nuovecartedealer[contanumcartedealer].getValore();
                        contanumcartedealer++;
                        break;
                    case 1:
                        carta4Dealer.Visible = true;
                        nuovecartedealer[contanumcartedealer] = new Carta(random);
                        carta4Dealer.BackgroundImageLayout = ImageLayout.Stretch;
                        carta4Dealer.BackgroundImage = new Bitmap(nuovecartedealer[contanumcartedealer].getImage());
                        TotaleDealer += nuovecartedealer[contanumcartedealer].getValore();
                        contanumcartedealer++;
                        break;
                    case 2:
                        carta5Dealer.Visible = true;
                        nuovecartedealer[contanumcartedealer] = new Carta(random);
                        carta5Dealer.BackgroundImageLayout = ImageLayout.Stretch;
                        carta5Dealer.BackgroundImage = new Bitmap(nuovecartedealer[contanumcartedealer].getImage());
                        TotaleDealer += nuovecartedealer[contanumcartedealer].getValore();
                        contanumcartedealer++;
                        break;
                }

            }
            labeltotaledealer.Text = TotaleDealer.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
