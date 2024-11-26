using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Model
{
    internal class Onderdeel
    {
        public int Id { get; set; }
        private string _naam = string.Empty;
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}
