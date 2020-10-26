using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projekt_2_nowy
{
    public partial class Form1 : Form
    {
        private List<Osoba> m_lPersons;
        private int currIndex;
        public Form1()
        {
            InitializeComponent();
            m_lPersons = new List<Osoba>();
            String[] lines = System.IO.File.ReadAllLines("../../baza.txt");
            for(int i=0;i<lines.Length/5;++i)
            {
                Osoba o = new Osoba();
                o.name = lines[i * 5];
                o.surname = lines[i * 5 + 1];
                o.stanowisko = (Osoba.Stanowisko)Int32.Parse(lines[i * 5 + 2]);
                o.sex = lines[i * 5 + 3];
                o.birthYear = Int32.Parse(lines[i * 5 + 4]);
                m_lPersons.Add(o);
            }
            currIndex = 0;
            showPerson(currIndex);

        }

        private void showPerson(int index)
        {
            Osoba tmp = m_lPersons[index];
            lblName.Text = tmp.name;
            lblSurname.Text = tmp.surname;
            cbStanowisko.SelectedItem = Osoba.getStringFromEnum(tmp.stanowisko);
            cbSex.SelectedItem = tmp.sex;
            spinYear.Value = tmp.birthYear;
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
            Osoba tmp = m_lPersons[currIndex];
            tmp.name = lblName.Text;
            tmp.surname = lblSurname.Text;
            tmp.sex = cbSex.Text;
            tmp.stanowisko = Osoba.intFromEnumString(cbStanowisko.Text);
            tmp.birthYear = (int)spinYear.Value;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }

        private void dataText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(currIndex+1 < m_lPersons.Count()) currIndex++;
            showPerson(currIndex);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currIndex - 1 > -1) currIndex--;
            showPerson(currIndex);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            m_lPersons.Add(new Osoba());
            currIndex = m_lPersons.Count() - 1;
            showPerson(currIndex);
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.Delete("../../baza.txt");
            //File.Create("../../baza.txt");
            for (int i = 0; i < m_lPersons.Count(); ++i)
            {
                String[] arr = m_lPersons[i].toStringArray();
                File.AppendAllLines("../../baza.txt", arr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            m_lPersons.Remove(m_lPersons[currIndex]);
            currIndex = 0;
            showPerson(currIndex);
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }
    }
    /*public class WriteTextLine : Osoba
    { 
        static void Zapis()
        {
            Osoba os = new Osoba();

            string[] lines = {os.ImieOs, os.NazwiskoOs, os.StanowiskoOs, os.PlecOs, os.PlecOs };
            System.IO.File.WriteAllLines(@"C:\Users\justy\Desktop\lizak.txt", lines);

        }
    }

    public class Inout
    {


    }
*/

}
