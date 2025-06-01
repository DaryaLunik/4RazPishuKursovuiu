using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4popitka
{
    internal class Department
    {
        private string name;
        private string faculty;
        private string phone;
        private string specialty;

        public Department() { }
        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Specialty { get => specialty; set => specialty = value; }

        public Department(string name, string faculty, string phone, string specialty)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Phone = phone;
            this.Specialty = specialty;
        }
        public Department ToFileString(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            string[] parts = line.Split(';');
            if (parts.Length != 4)
                return null;

            Department d = new Department();
            d.Name = parts[0];
            d.Faculty = parts[1];
            d.Phone = parts[2];
            d.Specialty = parts[3];

            return d;
        }

    }
}
