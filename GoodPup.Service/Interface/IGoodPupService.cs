using System.Collections.Generic;
using GoodPup.DTO;

namespace GoodPup.Service.Interface
{
    public interface IGoodPupService
    {
        IEnumerable<Pup> GetAllPups();
    }
}
