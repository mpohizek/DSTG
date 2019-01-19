using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak3
{
    public partial class Form1 : Form
    {
        List<UredenaTrojka> sviPosjeceni = new List<UredenaTrojka>();
        public Form1()
        {
            InitializeComponent();
        }

        public List<UredenaTrojka> ValjanaDjeca(UredenaTrojka roditelj)
        {
            List<UredenaTrojka> djeca = new List<UredenaTrojka>();
            if(roditelj.CamacLijevo == 1) // ako je čamac na lijevoj strani rijeke ide na desnu stranu rijeke
            {
                UredenaTrojka dijete = new UredenaTrojka(roditelj, roditelj.KanibaliLijevo, roditelj.MisionariLijevo, roditelj.CamacLijevo - 1);

                //1. slučaj - na desnu obalu ide jedan kanibal
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 1,dijete.MisionariLijevo,dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 1, dijete.MisionariLijevo, dijete.CamacLijevo));
                }
                //2. slučaj - na desnu obalu ide jedan misionar
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo - 1, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo - 1, dijete.CamacLijevo));
                }
                //3. slučaj - na desnu obalu idu dva kanibala
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 2, dijete.MisionariLijevo, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 2, dijete.MisionariLijevo, dijete.CamacLijevo));
                }
                //4. slučaj - na desnu obalu idu dva misionara 
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo - 2, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo - 2, dijete.CamacLijevo));
                }
                //5. slučaj - na desnu obalu ide jedan kanibal i jedan misionar
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 1, dijete.MisionariLijevo - 1, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo - 1, dijete.MisionariLijevo - 1, dijete.CamacLijevo));
                }
                
            }
            else //ako je čamac na desnoj strani rijeke ide na lijevu stranu rijeke
            {
                UredenaTrojka dijete = new UredenaTrojka(roditelj, roditelj.KanibaliLijevo, roditelj.MisionariLijevo, roditelj.CamacLijevo + 1);

                //1. slučaj - na lijevu obalu ide jedan kanibal
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 1, dijete.MisionariLijevo, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 1, dijete.MisionariLijevo, dijete.CamacLijevo));
                }
                //2. slučaj - na lijevu obalu ide jedan misionar
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo + 1, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo + 1, dijete.CamacLijevo));
                }
                //3. slučaj - na lijevu obalu idu dva kanibala
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 2, dijete.MisionariLijevo, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 2, dijete.MisionariLijevo, dijete.CamacLijevo));
                }
                //4. slučaj - na lijevu obalu idu dva misionara
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo + 2, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo, dijete.MisionariLijevo + 2, dijete.CamacLijevo));
                }
                //5. slučaj - na lijevu obalu ide jedan kanibal i jedan misionar
                if (UredenaTrojka.ProvjeritiValjanostPoteza(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 1, dijete.MisionariLijevo + 1, dijete.CamacLijevo)))
                {
                    djeca.Add(new UredenaTrojka(roditelj, dijete.KanibaliLijevo + 1, dijete.MisionariLijevo + 1, dijete.CamacLijevo));
                }

            }

            return djeca;
        }

        //BFS algoritam
        public UredenaTrojka Algoritam()
        {
            List<UredenaTrojka> red = new List<UredenaTrojka>();
            red.Add(new UredenaTrojka(null, 3, 3, 1));

            while(red.Count > 0)
            {
                UredenaTrojka cvor = red[0];
                red.RemoveAt(0);
                sviPosjeceni.Add(cvor);

                foreach (UredenaTrojka trojka in ValjanaDjeca(cvor))
                {
                    if (!sviPosjeceni.Contains(trojka))
                    {
                        if (trojka.ProvjeritiCilj())
                        {
                            return trojka;
                        }
                        red.Add(trojka);
                    }
                }
            }
            return null;
        }
        

        private void btnPokreniAlgoritam_Click(object sender, EventArgs e)
        {
            txtRjesenjeOutput.Text = "";
            UredenaTrojka rjesenje = Algoritam();
            while (rjesenje.Roditelj != null)
            {
                txtRjesenjeOutput.Text = rjesenje.ToString() + txtRjesenjeOutput.Text + Environment.NewLine;
                rjesenje = rjesenje.Roditelj;
            }
            txtRjesenjeOutput.Text = "(broj kanibala lijevo, broj misionara lijevo, čamac lijevo --> 1 | čamac desno --> 0)" + Environment.NewLine + "(3, 3, 1)" + Environment.NewLine + txtRjesenjeOutput.Text;
        }
    }
}
