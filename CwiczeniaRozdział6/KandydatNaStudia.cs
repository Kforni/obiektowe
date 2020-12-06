using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    struct KandydatNaStudia
    {
        public string nazwisko;
        int puntyMatematyka;
        int punktyInformatyka;
        int punktyJezykObcy;

        public KandydatNaStudia(string naz, int mat, int inf, int jez)
        {
            nazwisko = naz;
            puntyMatematyka = mat;
            punktyInformatyka = inf;
            punktyJezykObcy = jez;
        }

        public double LiczPunkty()
        {
            return 0.6 * puntyMatematyka + 0.5 * punktyInformatyka + 0.2 * punktyJezykObcy;
        }
    }
}
