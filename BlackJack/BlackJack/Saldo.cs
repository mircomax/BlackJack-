using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Saldo
    {
        int SaldoCorrente;
        int puntata;

        public Saldo()
        {
            SaldoCorrente = new int();
            puntata = new int();
            this.SaldoCorrente = 100;
        }

        public int Punta(int Puntata)
        {
            this.puntata = Puntata;
            SaldoCorrente -= Puntata;
            return SaldoCorrente;
        }

        public void AggiungiSaldo(int puntata)
        {
            this.SaldoCorrente += puntata;
        }

        public int getSaldoCorrente()
        {
            return SaldoCorrente;
        }
    }
}
