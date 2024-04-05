using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämninguppgifter_klasser_1
{
    internal class Class1
    {
        private string märke;
        private string modell;
        private int årsmodell;
        private int hästkrafter;
        private int maxhastighet;

        public Class1(string mä, string mo, int år, int hä, int ma)
        {
            märke = mä;
            modell = mo;
            årsmodell = år;
            hästkrafter = hä;
            maxhastighet = ma;
        }

        public Class1() { }

        public string Märke
        {
            get { return märke; }
            set { märke = value; }
        }

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        public int Årsmodell
        {
            get { return årsmodell; }
            set { årsmodell = value; }
        }

        public int Hästkrafter
        {
            get { return hästkrafter; }
            set { hästkrafter = value; }
        }

        public int Maxhastighet
        {
            get { return maxhastighet; }
            set { maxhastighet = value; } 
        }
    }
}
