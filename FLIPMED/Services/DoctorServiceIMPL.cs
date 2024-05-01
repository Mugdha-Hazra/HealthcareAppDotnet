using FLIPMED.Model;
using FLIPMED.Repository;

namespace FLIPMED.Services
{
    public class DoctorServiceIMPL : IDoctorService
    {
        private readonly IDoctorRepo _repo;
        public DoctorServiceIMPL(IDoctorRepo repo) {
        
            this._repo = repo;
        }
        public Doctor CreateDoctor(Doctor doctor)
        {
            return _repo.CreateDoctor(doctor);
        }

    }
}
