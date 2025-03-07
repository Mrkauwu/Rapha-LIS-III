using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS_III.Views
{
    public interface IPatientView
    {
        string PatientFirstName { get; set; }
        string patientLastName { get; set; }
        string patientMiddleName { get; set; }
        int patientAge { get; set; }
        string patientSex { get; set; }
        string patientAddress { get; set; }
        string patientCivilStatus { get; set; }
        string patientReligion { get; set; }
        string patientContact { get; set; }
        string patientTest { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        
        void SetPatienttListBindingSource(BindingSource patientList);
        void Show();
    }
}
