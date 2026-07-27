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
    public partial class FrmDoctors : Form
    {
        DoctorManager DoctorManager = new DoctorManager();

        Doctor doctor;

        public FrmDoctors()
        {
            InitializeComponent();
        }

        private void FrmDoctors_Load(object sender, EventArgs e)
        {
            //string firstName = doctor?.Bimar?.FirstName ?? "نام ثبت نشده";
            //if (doctor != null && doctor.FirstName != null )
            //{
            //    firstName = doctor.FirstName;
            //}
            MessageBox.Show("firstName");




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDoctor frm = new FrmDoctor();

            frm.ShowDialog();

            if (DoctorManager.GetDoctors() == null) return;
            dgvDoctor.DataSource = DoctorManager.GetDoctors().ToList();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDoctor.Columns["DeleteBtn"].Index)
            {
                DialogResult result = MessageBox.Show("آیا از حذف مطمئن هستید؟", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (DialogResult.Yes != result)
                    return;
                DoctorManager.RemoveDoctor(dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString());
                dgvDoctor.DataSource = DoctorManager.GetDoctors().ToList();
            }

            if (e.ColumnIndex == dgvDoctor.Columns["EditBtn"].Index)
            {
                Doctor doctor = null;

                foreach (var dc in DoctorManager.GetDoctors())
                {
                    if (dc.NezamPezeshki == dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString())
                    {
                        doctor = dc;
                        break;
                    }
                }

                FrmDoctor frm = new FrmDoctor(doctor);

                frm.ShowDialog();
                dgvDoctor.DataSource = DoctorManager.GetDoctors().ToList();
            }
        }
    }
}
