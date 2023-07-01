using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVPRepository;

namespace SVPService
{
    public class MasterService<T> : IMasterService<T> where T : class
    {
        private IMasterRepository<T> _repository;

        public MasterService(IMasterRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetDatos()
        {
            return _repository.GetDatos();
        }

        public T GetDato(int id)
        {
            return _repository.GetDato(id);
        }

        public void AddDato(T dato)
        {
            _repository.AddDato(dato);
        }

        public void UpdateDato(T dato)
        {
            _repository.UpdateDato(dato);
        }

        public void DeleteDato(int dato)
        {
            _repository.DeleteDato(dato);
        }
    }
}
