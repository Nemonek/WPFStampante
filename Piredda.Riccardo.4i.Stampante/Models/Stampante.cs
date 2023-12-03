using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piredda.Riccardo._4i.Stampante.Models
{
    public class Stampante
    {

        // - un metodo bool Stampa(Pagina p) (che torna false, se l'inchiostro non è sufficiente per stampare)
        // - un metodo int StatoInchiostro(Colore c) che torna la quantità di inchiostro presente nei 4 serbatoi.
        // - un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
        // - un metodo void SostituisciColore(Colore c) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
        // - un metodo void AggiungiCarta(int qta) che aggiunge fogli fino ad un max di 200

        public int C { get; set; }
        public int M { get; set; }
        public int G { get; set; }
        public int N { get; set; }
        public int Fogli { get; set; }

        public Stampante()
        {
            C = M = N = G = 100;
            Fogli = 100;
        }

        public bool Stampa(Pagina p)
        {
            if( Fogli > 0 && this.C >= p.C && this.M >= p.M && this.G >= p.G && this.N >= p.N )
            {
                this.C -= p.C;
                this.M -= p.M;
                this.G -= p.G;
                this.N -= p.N;
                Fogli--;
                return true;
            }

            return false;
        }

        public int StatoCarta()
        {
            return Fogli;
        }

        public int StatoInchiostro(Colori c)
        {
            switch (c)
            {
                case Colori.Ciano:
                    return this.C;
                case Colori.Magenta:
                    return this.M;
                case Colori.Giallo:
                    return this.G;
                case Colori.Nero: 
                    return this.N;
            }
            throw new();    // non dovrebbe mai accadere
        }
        public void AggiungiCarta(int qta)
        {
            if (qta <= 0)
                throw new();
            this.Fogli += qta;
        }
        public void SostituisciColore(Colori c)
        {
            switch (c)
            {
                case Colori.Ciano:
                    this.C = 100;
                    break;
                case Colori.Magenta:
                    this.M = 100;
                    break;
                case Colori.Giallo:
                    this.G = 100;
                    break;
                case Colori.Nero:
                    this.N = 100;
                    break;
            }
        }
    }
}
