using System.ComponentModel.DataAnnotations.Schema;

namespace testPatient.data
{
    [Table("Patients")]
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public bool Isdisease { get; set; }
        public string? diseaseName { get; set; }


    }
}
