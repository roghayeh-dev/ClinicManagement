using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public class NumericTextBox:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsDigit(e.KeyChar) &&
               e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
