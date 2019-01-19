using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    //(k, m, c)
    public class UredenaTrojka
    {
        public UredenaTrojka Roditelj { get; set; }
        public int KanibaliLijevo { get; set; }
        public int MisionariLijevo { get; set; }
        public int CamacLijevo { get; set; }

        public UredenaTrojka(UredenaTrojka r, int k, int m, int c)
        {
            Roditelj = r;
            KanibaliLijevo = k;
            MisionariLijevo = m;
            CamacLijevo = c;
        }

        //Cilj je postignut ako su svi kanibali i svi misionari prebačeni na desnu stranu rijeke.
        public bool ProvjeritiCilj()
        {
            if (KanibaliLijevo == 0 && MisionariLijevo == 0 && CamacLijevo == 0) return true;
            else return false;
        }

        //Na lijevoj i desnoj strani obale mora vrijediti da je broj kanibala manji ili jednak broju misionara.
        public static bool ProvjeritiValjanostPoteza(UredenaTrojka trojka)
        {
            if (trojka.KanibaliLijevo < 0 || trojka.KanibaliLijevo > 3 || 
                trojka.MisionariLijevo < 0 || trojka.MisionariLijevo > 3)
                return false;
            if (((trojka.KanibaliLijevo > trojka.MisionariLijevo) && trojka.MisionariLijevo != 0) || 
                ((3 - trojka.KanibaliLijevo > 3 - trojka.MisionariLijevo) && (3 - trojka.MisionariLijevo != 0)))
                return false;
            return true;
        }

        public override string ToString()
        {
            return "(" + KanibaliLijevo + ", " + MisionariLijevo + ", " + CamacLijevo + ")" + Environment.NewLine;
        }
    }
}
