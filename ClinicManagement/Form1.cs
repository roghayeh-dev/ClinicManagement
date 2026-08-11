using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        void ChangeLablesColorToRed(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is Label)
                {
                    ((Label)control).BackColor = Color.Red;
                }
                else if ((control as Control).HasChildren)
                {
                    ChangeLablesColorToRed((control as Control).Controls);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLablesColorToRed(this.Controls);
        }

    }
}
