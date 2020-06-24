using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabliczka_mnozenia
{
    class KlasaTabliczka
    {
        private Random rnd = new Random();
        public int maksymalna_cyfra = 3;
        public int pierwsza_cyfra;
        public int druga_cyfra;

        public void LosowanieCyfr()
        {
          int pierwsza_cyfra = rnd.Next(2, maksymalna_cyfra);
          int druga_cyfra = rnd.Next(2, maksymalna_cyfra);
        }
    }
}

    