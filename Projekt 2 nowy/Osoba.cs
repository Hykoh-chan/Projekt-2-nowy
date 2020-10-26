using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2_nowy
{
    class Osoba
    {
        public enum Stanowisko
        {
            student,
            profesor,
            doktor,
            inny
        };

        public string name;
        public string surname;
        public Stanowisko stanowisko;
        public string sex;
        public int birthYear;

        public Osoba()
        {
            birthYear = 2000;
        }

        public String[] toStringArray()
        {
            String[] arr = new string[5];
            arr[0] = name;
            arr[1] = surname;
            arr[3] = sex;
            arr[2] = ((int)stanowisko).ToString();
            arr[4] = birthYear.ToString();
            return arr;
        }


        public static String getStringFromEnum(Stanowisko s)
        {
            if (s == Stanowisko.student) return "Student";
            else if (s == Stanowisko.profesor) return "Profesor";
            else if (s == Stanowisko.doktor) return "Doktor";
            return "Inny";
        }
        public static Stanowisko intFromEnumString(String s)
        {
            if (s == "Student") return Stanowisko.student;
            else if (s == "Profesor") return Stanowisko.profesor;
            else if (s == "Doktor") return Stanowisko.doktor;
            return Stanowisko.inny;
        }
    }
}
