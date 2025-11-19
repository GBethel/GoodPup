using System.Collections.Generic;

namespace GoodPup.DTO
{
    public class DashboardStatus
    {
        public int PupId { get; set; }
        public DateOnly Date { get; set; }
        public bool FeedingAMCompleted { get; set; }
        public bool FeedingPMCompleted { get; set; }
        public int WalksCompleted { get; set; }
        public List<MedicationTask>? MedicationsDue { get; set; }
    }
}
