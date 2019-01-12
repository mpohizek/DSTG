using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        public void animacijaTure()
        {

        }

        private void btnPokreniAlgoritam_Click(object sender, EventArgs e)
        {
            redosljedSkokova.Clear();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
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

                string koordinata;

                string outputFilePath = putanjaPlusImeDatoteke.Replace("KnightsTour.py", "output.txt");
                System.IO.StreamReader file =
                    new System.IO.StreamReader(outputFilePath);
                while ((koordinata = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(koordinata);
                    redosljedSkokova.Add(koordinata);
                }
                file.Close();
            }
        }
    }
}
