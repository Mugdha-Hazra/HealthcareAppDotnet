using FLIPMED.Enum;
using System.ComponentModel.DataAnnotations;

namespace FLIPMED.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(5)]
        public required string Name { get; set; }
        public Speciality DocSpeciality { get; set; }
    }
}
