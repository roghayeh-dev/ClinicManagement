using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmDoctor : Form
    {
        DoctorManager _doctorManager = new DoctorManager();
        Doctor _doctor = null;


        public FrmDoctor(Doctor doctor) : this()
        {
            _doctor = doctor;
        }
        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] errors = _doctorManager.Validation(
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

            Doctor doctor = new Doctor(txtMedicalCouncilNumber.Text,"","");
            doctor.FirstName = txtName.Text;
            doctor.LastName = txtLastName.Text;
            //int[] numbers = { 3, 4, 7, 9 };

            // string sss = string.Join(",", numbers);

            //foreach (var n in numbers)
            //{
            //    sss += n + ",";
            //}


            doctor.Specialties = Regex.Split(richTextBox1.Text, Environment.NewLine);

            if (this._doctor == null)
                _doctorManager.AddDoctor(doctor);
            else
                _doctorManager.EditDoctor(this._doctor, doctor);
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            if (_doctor != null)
            {
                txtName.Text = _doctor.FirstName;
                txtLastName.Text = _doctor.LastName;
                txtMedicalCouncilNumber.Text = _doctor.medicalCouncilNumber;
                richTextBox1.Text = string.Join(Environment.NewLine, _doctor.Specialties);
            }
        }
    }
}