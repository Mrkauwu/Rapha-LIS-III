using Rapha_LIS_III.Models;
using Rapha_LIS_III.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS_III.Presenters
{
    public class PatientPresenter
    {
        private IPatientView patientView;
        private IPatientRepository patientRepository;
        private BindingSource patientsBindingSource;
        private IEnumerable<PatientModel> patientList;
public PatientPresenter(IPatientView patientView, IPatientRepository patientRepository)
        {
            this.patientsBindingSource = new BindingSource();
            this.patientView = patientView;
            this.patientRepository = patientRepository;
            this.patientView.SearchEvent += SearchPatient;

            this.patientView.SetPatienttListBindingSource(patientsBindingSource);
            LoadAllPatientList();
            this.patientView.Show();
        }

        private void SearchPatient(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.patientView.SearchValue);
            if (emptyValue == false)
                patientList = patientRepository.GetByValue(this.patientView.SearchValue);
            else patientList = patientRepository.GetAll();
            patientsBindingSource.DataSource = patientList;
        }

        private void LoadAllPatientList()
        {
            patientList = patientRepository.GetAll();
            patientsBindingSource.DataSource = patientList;
        }

        

    }
}
