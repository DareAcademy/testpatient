using AutoMapper;
using testPatient.data;

namespace testPatient.Models
{
    [AutoMap(typeof(Patient), ReverseMap = true)]
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public bool Isdisease { get; set; }
        public string? diseaseName { get; set; }
    }
}
