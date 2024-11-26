using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Model
{
    internal class AutoOnderdeel
    {
        public int Id { get; set; }
        private int _personenAutoId = 0;

        public  int PersonenAutoId
        {
            get { return _personenAutoId; }
            set { _personenAutoId = value; }
        }
        private int _onderdeelId = 0;
        public int OnderdeelId
        {
            get { return _onderdeelId; }
            set { _onderdeelId = value; }
        }

    }
}
