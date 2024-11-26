using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Model
{
    internal class UserMessage : ObservableObject
    {

        private string _text = string.Empty;
        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(); }
        }
    }

}
