using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4popitka
{
    internal class Discipline
    {
        private string name;
        private string semester;
        private string specialtyCode;
        private int[] hours; // [0] - лекции, [1] - семинары, [2] - лабораторные
        private string report;

        public Discipline() { }
        public string Name { get => name; set => name = value; }
        public string Semester { get => semester; set => semester = value; }
        public string SpecialtyCode { get => specialtyCode; set => specialtyCode = value; }
        public int[] Hours { get => hours; set => hours = value; }
        public string Report { get => report; set => report = value; }

        public Discipline(string name, string semester, string specialtyCode, int[] hours, string report)
        {
            this.Name = name;
            this.Semester = semester;
            this.SpecialtyCode = specialtyCode;
            this.Hours = hours;
            this.Report = report;
        }

        // Метод для чтения из строки файла
        public Discipline ToFileString(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            string[] parts = line.Split(';');
            if (parts.Length != 5)
                return null;

            Discipline d = new Discipline();
            d.Name = parts[0];
            d.Semester = parts[1];
            d.SpecialtyCode = parts[2];

            string[] hourParts = parts[3].Split(',');
            if (hourParts.Length != 3)
                return null;

            d.Hours = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int h;
                if (!int.TryParse(hourParts[i], out h))
                    return null;
                d.Hours[i] = h;
            }

            d.Report = parts[4];

            return d;
        }

    }
}
