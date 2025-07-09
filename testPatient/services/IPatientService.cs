using testPatient.Models;

namespace testPatient.services
{
    public interface IPatientService
    {
        int AddPatient(PatientDTO patientDTO);
        PatientDTO GetPatient(int Id);
    }
}
