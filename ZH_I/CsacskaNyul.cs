using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_I
{
    public class CsacskaNyul : TreMedve
    {
        private float Sebesseg;

        private int Sorszam = 5;

        private int Tavolsag;

        public void MedveReag()
        {
            if (Orditas == true)
                Sebesseg = Sebesseg * 1.5f;
        }
    }
}
