using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmPatients : Form
    {
        public FrmPatients()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();
            frm.ShowDialog();

            PatientManager patientManager = new PatientManager();
            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = null;
            dgvPatient.DataSource = patientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = new Patient("", "");

            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                DialogResult result = MessageBox.Show(
                    "آیا از حذف این بیمار مطمئن هستید؟",
                    "تأیید حذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Patient patient = (Patient)dgvPatient.Rows[e.RowIndex].DataBoundItem;

                    PatientManager patientManager = new PatientManager();
                    Result resultD = patientManager.DeletePatient(patient);

                    if (resultD.Success)
                    {
                        dgvPatient.AutoGenerateColumns = false;
                        dgvPatient.DataSource = null;
                        dgvPatient.DataSource = patientManager.GetPatients().ToList();
                    }
                    else
                    {
                        MessageBox.Show(resultD.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

       

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();

            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = patientManager.SearchPatient(txtSearch.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();
            patientManager.GetPatients().Clear();
        }
    }
}