using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS_III.Models
{
    public interface IPatientRepository
    {
        void Add(PatientModel patientModel);
        void Edit(PatientModel patientModel);
        void Delete(int id);
        IEnumerable<PatientModel> GetAll();
        IEnumerable<PatientModel> GetByValue(string value);

    }
}
