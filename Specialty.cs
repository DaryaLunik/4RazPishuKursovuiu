using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4popitka
{
    internal class Specialty
    {
        private string code;
        private string name;
        private string specName;
        private string form;

        public Specialty() { }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string SpecName { get => specName; set => specName = value; }
        public string Form { get => form; set => form = value; }

        public Specialty(string code, string name, string specName, string form)
        {
            this.Code = code;
            this.Name = name;
            this.SpecName = specName;
            this.Form = form;
        }
        public Specialty ToFileString(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            string[] parts = line.Split(';');
            if (parts.Length != 4)
                return null;

            Specialty s = new Specialty();
            s.Code = parts[0];
            s.Name = parts[1];
            s.SpecName = parts[2];
            s.Form = parts[3];

            return s;
        }

    }
}
