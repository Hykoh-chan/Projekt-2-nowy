using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2_nowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Osoba os = new Osoba();

            os.ImieOs = ImieText.Text.ToString();
            os.NazwiskoOs = NazText.Text.ToString();
            os.StanowiskoOs = stancombo.SelectedItem.ToString();
            os.PlecOs = pleccombo.SelectedItem.ToString();
            os.DataOs = float.Parse(dataText.Text);

            string xxx = os.DataOs.ToString();

            string[] lines = { os.ImieOs, os.NazwiskoOs, os.StanowiskoOs, os.PlecOs, xxx };
            System.IO.File.WriteAllLines(@"C:\Users\justy\Desktop\lizak.txt", lines); 


        }
    }

    public class Osoba : Form1
    {
        public string ImieOs;
        public string NazwiskoOs;
        public string StanowiskoOs;
        public string PlecOs;
        public float DataOs;

    }

    public class WriteTextLine : Osoba
    { 
        static void Zapis()
        {
            Osoba os = new Osoba();

            string[] lines = {os.ImieOs, os.NazwiskoOs, os.StanowiskoOs, os.PlecOs, os.PlecOs };
            System.IO.File.WriteAllLines(@"C:\Users\justy\Desktop\lizak.txt", lines);

        }
    }

    public class Reader
    {
        int counter = 0;

        static void wczytywania()
        {
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\justy\Desktop\lizak.txt", lines);

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\justy\Desktop\lizak.txt");

            while ((lines = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
        }

    }

    public class Inout
    {


    }


}
