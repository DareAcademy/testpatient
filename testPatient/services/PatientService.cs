using AutoMapper;
using testPatient.data;
using testPatient.Models;

namespace testPatient.services
{
    public class PatientService: IPatientService
    {
        private readonly ClinicContext context;
        private readonly IMapper mapper;

        public PatientService(ClinicContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public int AddPatient(PatientDTO patientDTO)
        {
            Patient newPatient = mapper.Map<Patient>(patientDTO);
            context.patients.Add(newPatient);
            context.SaveChanges();
            return newPatient.Id;
        }

        public PatientDTO GetPatient(int Id)
        {
            Patient patient = context.patients.Where(p => p.Id == Id).FirstOrDefault();
            if(patient != null)
            {
                PatientDTO patientDto = mapper.Map<PatientDTO>(patient);
                return patientDto;
            }
            return null;
        }
    }
}
