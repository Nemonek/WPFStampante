using System;

namespace Piredda.Riccardo._4i.Stampante.Models
{
    public class Pagina
    {
        public int C { get; set; }
        public int M { get; set; }
        public int G { get; set; }
        public int N { get; set; }

        public Pagina(int C, int M, int G, int N)
        {
            if(C > 3 || C < 0 || M > 3 || M < 0 || G > 3 || G < 0 || N > 3 || N < 0)
                throw new ArgumentException();
            this.C = C;
            this.M = M;
            this.G = G;
            this.N = N;
        }
        public Pagina()
        {
            Random r = new();

            C = r.Next(0, 4);
            M = r.Next(0, 4);
            G = r.Next(0, 4);
            N = r.Next(0, 4);
        }
    }
}
