using System;
using System.Collections.Generic;
using System.Text;

namespace WPFClasses
{
    public class EntryForm
    {
        public string Name      {get; set;}
        public string Address   {get; set;}
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {

        }

        public override string ToString()
        {
            return $"{Name}, {Address} {ZipCode}";
        }
    }
}
