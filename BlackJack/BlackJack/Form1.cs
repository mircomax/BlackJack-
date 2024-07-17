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
        int TotaleGiocatore, TotaleDealer, puntata;
        int contanumcarteuser = 0;
        int contanumcartedealer = 0;
        DialogResult finepartita;
        Saldo primosaldo;
        string percorsoretrocarte = "C:\\Users\\mirco\\Desktop\\C#\\BlackJack\\BlackJack\\Resources\\retrocarta.png";
        public Form1()
        {
            primosaldo = new Saldo();
            PuntataCorrente = new NumericUpDown();
            progressBar1 = new ProgressBar();
            nuovecarteuser = new Carta[3];
            nuovecartedealer = new Carta[3];
            panel1 = new Panel();
            puntata = new int();
            InitializeComponent();
           
            random = new Random();
        }
        private async void Aspetta()
        {
            await Task.Delay(3000);
            panel1.Visible = true;
            progressBar1.Value = 1000;
            for (int i = 0; i < 1000; i++)
            {
                await Task.Delay(10);
                progressBar1.Value--;
                if (!panel1.Visible) { 
                    break; //se un qualsiasi tasto è cliccato esce dal ciclo 
                }
                else if (progressBar1.Value == 1)
                {
                    StaiButton.PerformClick();
                }//se non viene cliccato nulla prima della scadenza del timer viene cliccato in automatico il tasto "Stai"
            }
        }
        private void AssegnaPrimeCarte()
        {
            
            carta1Dealer = new Carta(random);

            carta2Dealer = new Carta(random);           
            Carta2Dealer.BackgroundImage = new Bitmap(carta2Dealer.getImage()); //visualizzare l'immagine sulla carta

            TotaleDealer = carta2Dealer.getValore() ;
            labeltotaledealer.Text = TotaleDealer.ToString();  //Scrivere nella label il totale

            carta1User = new Carta(random);
            Carta1User.BackgroundImage = new Bitmap(carta1User.getImage()); //visualizzare l'immagine sulla carta

            carta2User = new Carta(random);   
            Carta2User.BackgroundImage = new Bitmap(carta2User.getImage()); //visualizzare l'immagine sulla carta 

            TotaleGiocatore = carta2User.getValore() + carta1User.getValore();
            labeltotaleuser.Text = TotaleGiocatore.ToString(); //Scrivere nella label il totale
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
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore(); //aggiunge il valore della carta al totale
                    contanumcarteuser++;
                break;
                case 1:
                    Carta4User.Visible = true;
                    nuovecarteuser[contanumcarteuser] = new Carta(random);
                    Carta4User.BackgroundImageLayout = ImageLayout.Stretch;
                    Carta4User.BackgroundImage = new Bitmap(nuovecarteuser[contanumcarteuser].getImage());
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore(); //aggiunge il valore della carta al totale
                    contanumcarteuser++;
                break;
                case 2:
                    Carta5User.Visible = true;
                    nuovecarteuser[contanumcarteuser] = new Carta(random);
                    Carta5User.BackgroundImageLayout = ImageLayout.Stretch;
                    Carta5User.BackgroundImage = new Bitmap(nuovecarteuser[contanumcarteuser].getImage());
                    TotaleGiocatore += nuovecarteuser[contanumcarteuser].getValore(); //aggiunge il valore della carta al totale
                    contanumcarteuser++;
                break;
            }
            labeltotaleuser.Text = TotaleGiocatore.ToString();
            if(TotaleGiocatore > 21) //controllo nel caso il giocatore sballi
            {
                finepartita = MessageBox.Show("Hai sballato!!", "Fine partita!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Ricomincia(finepartita);
            }
            Aspetta();
        }
        private async void StaiButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Carta1Dealer.BackgroundImage = new Bitmap(carta1Dealer.getImage()); //carta1dealer viene rivelata
            TotaleDealer += carta1Dealer.getValore(); //valore carta 1 aggiunto e visualizzato nella label
            labeltotaledealer.Text = TotaleDealer.ToString();
            await Task.Delay(1000);
            while (TotaleDealer < 17)
            {
                switch (contanumcartedealer)
                { //switch per far comparire le carte del dealer quando viene schiacciato il tasto stai
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
                labeltotaledealer.Text = TotaleDealer.ToString();
                await Task.Delay(1000);
            }
            if(finepartita != DialogResult.Cancel || finepartita != DialogResult.Retry)
            {
                ControlloFinePartita(); //se la message box non è ancora comparsa compare quando viene schiacciato il tasto stai
            }
        }
        private void NuovoTurno()
        {
            contanumcartedealer = 0; contanumcarteuser = 0; //setta i contatori delle carte aggiuntive a 0
            nuovecartedealer = new Carta[3]; nuovecarteuser = new Carta[3]; //create nuove istanze delle carte
            labeltotaledealer.Text = "0";
            labeltotaleuser.Text = "0";
            //Carte iniziali nascoste
            Carta1Dealer.BackgroundImage = new Bitmap(percorsoretrocarte); Carta2Dealer.BackgroundImage = new Bitmap(percorsoretrocarte);
            Carta1User.BackgroundImage = new Bitmap(percorsoretrocarte); Carta2User.BackgroundImage = new Bitmap(percorsoretrocarte);
            //vengono fatte scomparire le carte aggiuntive
            Carta3User.Visible = false; Carta4User.Visible = false; Carta5User.Visible = false;
            carta3Dealer.Visible = false; carta4Dealer.Visible = false; carta5Dealer.Visible = false; 

            groupBox1.Enabled = true; //la groupbox torna ad essere disponibile per ricevere la puntata e ricreare la partita
            Saldo_corrente.Text = "Saldo Corrente: " + primosaldo.getSaldoCorrente();
        }
        private void Ricomincia(DialogResult finepartita)
        {
            if (finepartita == DialogResult.Cancel) { this.Close(); } //se viene schiacciato il tasto annulla viene chiuso il form 
            else if (finepartita == DialogResult.Retry) { NuovoTurno(); } //se veien schiacciato il tasto riprova si riinizia il turno
        }
        private void ControlloFinePartita()
        {
            if (TotaleGiocatore > TotaleDealer || TotaleDealer > 21) {
                primosaldo.AggiungiSaldo(puntata*2);
                finepartita = MessageBox.Show($"Hai Vinto!\n+{puntata*2} nel tuo saldo!", "Fine partita!", 
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);}

            else if (TotaleDealer > TotaleGiocatore){ finepartita = MessageBox.Show("Il dealer ha un punteggio superiore!!!", "Fine partita!", 
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);}

            else if(TotaleDealer == TotaleGiocatore){
                primosaldo.AggiungiSaldo(puntata);
                finepartita = MessageBox.Show("Pareggio!!!", "Fine partita!", 
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);}

            Ricomincia(finepartita);
        }
        private void Puntabtn_Click(object sender, EventArgs e)
        {
            puntata = (int)PuntataCorrente.Value;
            if ((puntata <= primosaldo.getSaldoCorrente()) && (puntata > 0))
            {
                Saldo_corrente.Text = "Saldo Corrente: " + primosaldo.Punta(puntata);
                groupBox1.Enabled = false;
                panel1.Visible = false;
                AssegnaPrimeCarte();
                Aspetta();
            }
            else
            {
                MessageBox.Show("Puntata non valida!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
