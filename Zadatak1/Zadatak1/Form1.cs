using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        List<string> redosljedSkokova = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        public void AnimacijaTure()
        {
            for (int i = 0; i <= redosljedSkokova.Count-1; i++)
            {
                switch (redosljedSkokova[i])
                {
                    case "(0, 0)":
                        {
                            A1.BackColor = Color.LightGreen;
                            A1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 1)":
                        {
                            B1.BackColor = Color.LightGreen;
                            B1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 2)":
                        {
                            C1.BackColor = Color.LightGreen;
                            C1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 3)":
                        {
                            D1.BackColor = Color.LightGreen;
                            D1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 4)":
                        {
                            E1.BackColor = Color.LightGreen;
                            E1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 5)":
                        {
                            F1.BackColor = Color.LightGreen;
                            F1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 6)":
                        {
                            G1.BackColor = Color.LightGreen;
                            G1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(0, 7)":
                        {
                            H1.BackColor = Color.LightGreen;
                            H1.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 0)":
                        {
                            A2.BackColor = Color.LightGreen;
                            A2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 1)":
                        {
                            B2.BackColor = Color.LightGreen;
                            B2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 2)":
                        {
                            C2.BackColor = Color.LightGreen;
                            C2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 3)":
                        {
                            D2.BackColor = Color.LightGreen;
                            D2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 4)":
                        {
                            E2.BackColor = Color.LightGreen;
                            E2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 5)":
                        {
                            F2.BackColor = Color.LightGreen;
                            F2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 6)":
                        {
                            G2.BackColor = Color.LightGreen;
                            G2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(1, 7)":
                        {
                            H2.BackColor = Color.LightGreen;
                            H2.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 0)":
                        {
                            A3.BackColor = Color.LightGreen;
                            A3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 1)":
                        {
                            B3.BackColor = Color.LightGreen;
                            B3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 2)":
                        {
                            C3.BackColor = Color.LightGreen;
                            C3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 3)":
                        {
                            D3.BackColor = Color.LightGreen;
                            D3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 4)":
                        {
                            E3.BackColor = Color.LightGreen;
                            E3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 5)":
                        {
                            F3.BackColor = Color.LightGreen;
                            F3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 6)":
                        {
                            G3.BackColor = Color.LightGreen;
                            G3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(2, 7)":
                        {
                            H3.BackColor = Color.LightGreen;
                            H3.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 0)":
                        {
                            A4.BackColor = Color.LightGreen;
                            A4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 1)":
                        {
                            B4.BackColor = Color.LightGreen;
                            B4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 2)":
                        {
                            C4.BackColor = Color.LightGreen;
                            C4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 3)":
                        {
                            D4.BackColor = Color.LightGreen;
                            D4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 4)":
                        {
                            E4.BackColor = Color.LightGreen;
                            E4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 5)":
                        {
                            F4.BackColor = Color.LightGreen;
                            F4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 6)":
                        {
                            G4.BackColor = Color.LightGreen;
                            G4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(3, 7)":
                        {
                            H4.BackColor = Color.LightGreen;
                            H4.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 0)":
                        {
                            A5.BackColor = Color.LightGreen;
                            A5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 1)":
                        {
                            B5.BackColor = Color.LightGreen;
                            B5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 2)":
                        {
                            C5.BackColor = Color.LightGreen;
                            C5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 3)":
                        {
                            D5.BackColor = Color.LightGreen;
                            D5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 4)":
                        {
                            E5.BackColor = Color.LightGreen;
                            E5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 5)":
                        {
                            F5.BackColor = Color.LightGreen;
                            F5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 6)":
                        {
                            G5.BackColor = Color.LightGreen;
                            G5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(4, 7)":
                        {
                            H5.BackColor = Color.LightGreen;
                            H5.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 0)":
                        {
                            A6.BackColor = Color.LightGreen;
                            A6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 1)":
                        {
                            B6.BackColor = Color.LightGreen;
                            B6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 2)":
                        {
                            C6.BackColor = Color.LightGreen;
                            C6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 3)":
                        {
                            D6.BackColor = Color.LightGreen;
                            D6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 4)":
                        {
                            E6.BackColor = Color.LightGreen;
                            E6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 5)":
                        {
                            F6.BackColor = Color.LightGreen;
                            F6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 6)":
                        {
                            G6.BackColor = Color.LightGreen;
                            G6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(5, 7)":
                        {
                            H6.BackColor = Color.LightGreen;
                            H6.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 0)":
                        {
                            A7.BackColor = Color.LightGreen;
                            A7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 1)":
                        {
                            B7.BackColor = Color.LightGreen;
                            B7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 2)":
                        {
                            C7.BackColor = Color.LightGreen;
                            C7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 3)":
                        {
                            D7.BackColor = Color.LightGreen;
                            D7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 4)":
                        {
                            E7.BackColor = Color.LightGreen;
                            E7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 5)":
                        {
                            F7.BackColor = Color.LightGreen;
                            F7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 6)":
                        {
                            G7.BackColor = Color.LightGreen;
                            G7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(6, 7)":
                        {
                            H7.BackColor = Color.LightGreen;
                            H7.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 0)":
                        {
                            A8.BackColor = Color.LightGreen;
                            A8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 1)":
                        {
                            B8.BackColor = Color.LightGreen;
                            B8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 2)":
                        {
                            C8.BackColor = Color.LightGreen;
                            C8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 3)":
                        {
                            D8.BackColor = Color.LightGreen;
                            D8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 4)":
                        {
                            E8.BackColor = Color.LightGreen;
                            E8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 5)":
                        {
                            F8.BackColor = Color.LightGreen;
                            F8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 6)":
                        {
                            G8.BackColor = Color.LightGreen;
                            G8.Text = (i + 1).ToString();
                        }
                        break;
                    case "(7, 7)":
                        {
                            H8.BackColor = Color.LightGreen;
                            H8.Text = (i + 1).ToString();
                        }
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(600);
            }
        }

        private void btnPokreniAlgoritam_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;            
            btnPokreniAlgoritam.Enabled = false;
            redosljedSkokova.Clear();
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            
            OpenFileDialog pythonDatoteka = new OpenFileDialog();
            pythonDatoteka.Filter = "Python files (*.py)|*.py";
            pythonDatoteka.FilterIndex = 0;
            pythonDatoteka.RestoreDirectory = true;
            if (pythonDatoteka.ShowDialog() == DialogResult.OK)
            {
                string putanjaPlusImeDatoteke = pythonDatoteka.FileName;
                string putanja = putanjaPlusImeDatoteke.Replace(putanjaPlusImeDatoteke.Substring(putanjaPlusImeDatoteke.Length - 15), "");
                startInfo.WorkingDirectory = putanja;

                startInfo.Arguments = "/C python KnightsTour.py > output.txt";
                process.StartInfo = startInfo;
                process.Start();
                process.Dispose();

                Thread.Sleep(1000);

                string outputFilePath = putanjaPlusImeDatoteke.Replace("KnightsTour.py", "output.txt");
                string koordinata;

                if (File.Exists(outputFilePath))
                {
                    StreamReader file = new StreamReader(outputFilePath);
                    while ((koordinata = file.ReadLine()) != null)
                    {
                        redosljedSkokova.Add(koordinata);
                    }
                    file.Close();

                    AnimacijaTure();
                    btnReset.Enabled = true;
                }
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnPokreniAlgoritam.Enabled = true;

            A1.BackColor = Color.Black;
            A1.Text = "";

            A2.BackColor = Color.White;
            A2.Text = "";

            A3.BackColor = Color.Black;
            A3.Text = "";

            A4.BackColor = Color.White;
            A4.Text = "";

            A5.BackColor = Color.Black;
            A5.Text = "";

            A6.BackColor = Color.White;
            A6.Text = "";

            A7.BackColor = Color.Black;
            A7.Text = "";

            A8.BackColor = Color.White;
            A8.Text = "";

            B1.BackColor = Color.White;
            B1.Text = "";

            B2.BackColor = Color.Black;
            B2.Text = "";

            B3.BackColor = Color.White;
            B3.Text = "";

            B4.BackColor = Color.Black;
            B4.Text = "";
            
            B5.BackColor = Color.White;
            B5.Text = "";

            B6.BackColor = Color.Black;
            B6.Text = "";

            B7.BackColor = Color.White;
            B7.Text = "";

            B8.BackColor = Color.Black;
            B8.Text = "";

            C1.BackColor = Color.Black;
            C1.Text = "";

            C2.BackColor = Color.White;
            C2.Text = "";

            C3.BackColor = Color.Black;
            C3.Text = "";

            C4.BackColor = Color.White;
            C4.Text = "";

            C5.BackColor = Color.Black;
            C5.Text = "";

            C6.BackColor = Color.White;
            C6.Text = "";

            C7.BackColor = Color.Black;
            C7.Text = "";

            C8.BackColor = Color.White;
            C8.Text = "";

            D1.BackColor = Color.White;
            D1.Text = "";

            D2.BackColor = Color.Black;
            D2.Text = "";

            D3.BackColor = Color.White;
            D3.Text = "";

            D4.BackColor = Color.Black;
            D4.Text = "";

            D5.BackColor = Color.White;
            D5.Text = "";

            D6.BackColor = Color.Black;
            D6.Text = "";

            D7.BackColor = Color.White;
            D7.Text = "";

            D8.BackColor = Color.Black;
            D8.Text = "";

            E1.BackColor = Color.Black;
            E1.Text = "";

            E2.BackColor = Color.White;
            E2.Text = "";

            E3.BackColor = Color.Black;
            E3.Text = "";

            E4.BackColor = Color.White;
            E4.Text = "";

            E5.BackColor = Color.Black;
            E5.Text = "";

            E6.BackColor = Color.White;
            E6.Text = "";

            E7.BackColor = Color.Black;
            E7.Text = "";

            E8.BackColor = Color.White;
            E8.Text = "";

            F1.BackColor = Color.White;
            F1.Text = "";

            F2.BackColor = Color.Black;
            F2.Text = "";

            F3.BackColor = Color.White;
            F3.Text = "";

            F4.BackColor = Color.Black;
            F4.Text = "";

            F5.BackColor = Color.White;
            F5.Text = "";

            F6.BackColor = Color.Black;
            F6.Text = "";

            F7.BackColor = Color.White;
            F7.Text = "";

            F8.BackColor = Color.Black;
            F8.Text = "";

            G1.BackColor = Color.Black;
            G1.Text = "";

            G2.BackColor = Color.White;
            G2.Text = "";

            G3.BackColor = Color.Black;
            G3.Text = "";

            G4.BackColor = Color.White;
            G4.Text = "";

            G5.BackColor = Color.Black;
            G5.Text = "";

            G6.BackColor = Color.White;
            G6.Text = "";

            G7.BackColor = Color.Black;
            G7.Text = "";

            G8.BackColor = Color.White;
            G8.Text = "";

            H1.BackColor = Color.White;
            H1.Text = "";

            H2.BackColor = Color.Black;
            H2.Text = "";

            H3.BackColor = Color.White;
            H3.Text = "";

            H4.BackColor = Color.Black;
            H4.Text = "";

            H5.BackColor = Color.White;
            H5.Text = "";

            H6.BackColor = Color.Black;
            H6.Text = "";

            H7.BackColor = Color.White;
            H7.Text = "";

            H8.BackColor = Color.Black;
            H8.Text = "";
        }
    }
}
