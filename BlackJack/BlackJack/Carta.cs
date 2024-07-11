using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Carta
    {
        int Seme;
        int Numero;
        Bitmap Immagine;
        int valore;
        
        public Carta(Random random)
        {
           
            CreaCarta(random);
            //string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = $"C:\\Users\\mirco\\Desktop\\C#\\BlackJack\\BlackJack\\CarteDaGioco\\BlackJack_{Seme}_{Numero}.PNG";
            Immagine = new Bitmap(imagePath);
        }

        public Bitmap getImage()
        {
            return Immagine;
        }

        public int getValore() 
        { 
            return valore;
        }

        public void CreaCarta(Random random)
        {
            this.Seme = random.Next(1,5);
            this.Numero = random.Next(1,14);
            if (this.Numero == 11 || this.Numero == 12 || this.Numero == 13) { 
                this.valore = 10; //assegnare alle carte J,Q,K il valore 10.
            }
            else
            {
                this.valore = Numero;
            }
        }
    }
}
