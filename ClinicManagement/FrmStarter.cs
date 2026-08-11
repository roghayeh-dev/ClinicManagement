using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmStarter : Form
    {
        public FrmStarter()
        {
            InitializeComponent();
        }
        private void FrmStarter_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmPatients();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmDoctors();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = textBox1.Text.ToInt();


            var today = DateTime.Now.ToShamsiDate();

            MessageBox.Show(today);
        }
    }
}
