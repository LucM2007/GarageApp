﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Model
{
    internal class Personenauto
    {
        public int Id { get; set; }
        private string _merk = string.Empty;

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }
    }
}
