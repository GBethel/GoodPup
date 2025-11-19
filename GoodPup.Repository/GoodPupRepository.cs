using System.Collections.Generic;
using GoodPup.DTO;

namespace GoodPup.Repository
{
    public class GoodPupRepository : Interface.IGoodPupRepository
    {
        private static readonly List<Pup> _pups = new List<Pup>
        {
            new Pup { Id = 1, Name = "Buddy", PhotoUrl = string.Empty },
            new Pup { Id = 2, Name = "Bella", PhotoUrl = string.Empty }
        };

        public IEnumerable<Pup> GetAllPups()
        {
            return _pups;
        }
    }
}
