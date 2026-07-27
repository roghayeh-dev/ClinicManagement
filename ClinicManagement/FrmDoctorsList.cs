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
    public partial class FrmDoctorsList : Form
    {
        public FrmDoctorsList()
        {
            InitializeComponent();
        }
        private DoctorManager doctorManager = new DoctorManager();  

              private void RefreshGrid()
        {
            dvgDoctor.AutoGenerateColumns = true;
            dvgDoctor.DataSource = null;
            dvgDoctor.DataSource = doctorManager.GetDoctors().ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FrmDoctor frm = new FrmDoctor();
            frm.ShowDialog();

            RefreshGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string medicalCouncilNumber = textBoxDelete.Text.Trim();

            var result = doctorManager.DeleteDoctor(medicalCouncilNumber);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("پزشک با موفقیت حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxDelete.Text = "";
            RefreshGrid();
        }

        private void dvgDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgDoctor.SelectedRows.Count == 0)
                return;

            Doctor selectedDoctor = (Doctor)dvgDoctor.SelectedRows[0].DataBoundItem;

            if (selectedDoctor == null)
                return;

            //اطلاعات ردیفی که کاربر روی اون کلیک کرده رو میریزه توی تکس باکس ها
            txtUpdateFirstName.Text = selectedDoctor.FirstName;
            txtUpdateLastName.Text = selectedDoctor.LastName;
            txtUpdateMedicalCouncilNumber.Text = selectedDoctor.medicalCouncilNumber;
            txtUpdateSpecialty.Text = selectedDoctor.FullSpecialties;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string medicalCouncilNumber = txtUpdateMedicalCouncilNumber.Text.Trim();
            string firstName = txtUpdateFirstName.Text.Trim();
            string lastName = txtUpdateLastName.Text.Trim();
            string specialty = txtUpdateSpecialty.Text.Trim();

            Doctor oldDoctor = doctorManager
                .GetDoctors()
                .FirstOrDefault(d => d.medicalCouncilNumber == medicalCouncilNumber);

            if (oldDoctor == null)
            {
                MessageBox.Show("پزشک یافت نشد.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor newDoctor = new Doctor(
                medicalCouncilNumber,
                firstName,
                lastName);

            newDoctor.Specialties = specialty.Split(',');

            var result = doctorManager.EditDoctor(oldDoctor, newDoctor);

            if (!result.Success)
            {
                MessageBox.Show(result.Message,
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "اطلاعات پزشک با موفقیت ویرایش شد.",
                "موفقیت",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RefreshGrid();
        }

        private void dvgDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
