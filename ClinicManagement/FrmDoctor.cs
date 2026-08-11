using ClinicManagement.ClinicManagement;
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
        public FrmDoctor()
        {
            _doctor = doctor;
        }
        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            string[] errors = _doctorManager.Validation(
                firstName: txtName.Text,
                lastName: txtLastName.Text,
                medicalCouncilNumber: txtMedicalCouncilNumber.Text
            );

        }

        private void btnSave_Click(object sender, EventArgs e)
            {
            Doctor doctor = new Doctor(txtMedicalCouncilNumber.Text.Trim());
            doctor.FirstName = txtName.Text.Trim();
            doctor.LastName = txtLastName.Text.Trim();
            doctor.Specialty = txtSpecialty.Text.Trim();

            
            DoctorManager doctorManager = new DoctorManager();
            Result result = doctorManager.AddDoctor(doctor);
           // var result = DoctorManager.AddDoctor(doctor);

            if (result.Success) {
                MessageBox.Show("اطلاعات با موفیقت ثبت شد");
                this.Close();
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
                DoctorManager.EditDoctor(this.doctor, Doctor);
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            if (_doctor != null)
            {
                txtName.Text = _doctor.FirstName;
                txtLastName.Text = _doctor.LastName;
                txtMedicalCouncilNumber.Text = _doctor.NezamPezeshki;
                richTextBox1.Text = string.Join(Environment.NewLine, _doctor.Specialties);
            }
        }
    }
}
