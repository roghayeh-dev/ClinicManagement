using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    internal class CustomTextBox : TextBox
    {
        public string PlaceHolderText { get; set; }
        public bool ShowPlaceHolder { get; set; }
    }
}
