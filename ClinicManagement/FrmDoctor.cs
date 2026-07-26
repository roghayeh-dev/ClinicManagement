using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmDoctor : Form
    {
        DoctorManager DoctorManager = new DoctorManager();
        Doctor doctor = null;


        public FrmDoctor(Doctor doctor = null)
        {
            this.doctor = doctor;
            InitializeComponent();
            _doctor = doctor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] errors = DoctorManager.Validation(
                firstName: txtName.Text,
                lastName: txtLastName.Text,
                medicalCouncilNumber: txtMedicalCouncilNumber.Text
            );

            if (errors.Length > 0)
            {
                MessageBox.Show(
                    errors[0],
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Doctor Doctor = new Doctor(txtMedicalCouncilNumber.Text);
            Doctor.FirstName = txtName.Text;
            Doctor.LastName = txtLastName.Text;
            Doctor.Specialties = richTextBox1.Text.Split('\n');

            if (this.doctor == null)
                DoctorManager.AddDoctor(Doctor);
            else
                DoctorManager.EditDoctor(this.doctor, Doctor);
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            if (doctor != null)
            {
                txtName.Text = doctor.FirstName;
                txtLastName.Text = doctor.LastName;
                txtMedicalCouncilNumber.Text = doctor.MedicalCouncilNumber;
                richTextBox1.Text = string.Join(Environment.NewLine, doctor.Specialties);
            }
        }
    }
}