using GoodPup.Service.Interface;
using GoodPup.Repository.Interface;
using GoodPup.DTO;
using System.Collections.Generic;

namespace GoodPup.Service
{
    public class GoodPupService : IGoodPupService
    {
        private readonly IGoodPupRepository _repository;

        public GoodPupService(IGoodPupRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Pup> GetAllPups()
        {
            return _repository.GetAllPups();
        }
    }
}
