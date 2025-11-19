using System.Collections.Generic;
using GoodPup.DTO;

namespace GoodPup.Repository.Interface
{
    public interface IGoodPupRepository
    {
        IEnumerable<Pup> GetAllPups();
    }
}
