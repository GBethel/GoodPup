using System.Collections.Generic;

namespace GoodPup.DTO
{
    public class HistoryEntry
    {
        public int PupId { get; set; }
        public DateOnly Date { get; set; }
        public List<FeedingLog>? Feedings { get; set; }
        public List<WalkLog>? Walks { get; set; }
        public List<MedicationLog>? Medications { get; set; }
    }
}
