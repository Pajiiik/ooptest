using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testoop
{
    class Vzhled
    {
        public string barva { get; set; }
        public int velikost { get; set; }
        public bool popsana = false;


        
        public Vzhled()
        { 
        
        }

        public Vzhled(bool cista)
        {
            popsana = cista;
        }
        public Vzhled(int Velikost, string Barva)
        {
            barva = Barva;
            velikost = Velikost;
        }


        public void smazat_tabuli(Label lejbl)
        {
            lejbl.Text = "";
            popsana = false;
        }

        public void psat_na_tabuli(Label lejbl)
        {
                lejbl.Text = "adsfda";

            popsana = true;
        }

        public override string ToString()
        {
            string pomocna;
            if (popsana = true)
            {
                pomocna = " a je popsaná";
            }
            else
            {
                pomocna = " a není popsaná";
            }

            return string.Format("tabule má barvu {0} a velikost {1} {2}", barva , velikost , popsana);
        }

    }
}
