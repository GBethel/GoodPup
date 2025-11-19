namespace GoodPup.DTO
{
    public class MedicationLog
    {
        public int Id { get; set; }
        public int MedicationTaskId { get; set; }
        public int PupId { get; set; }
        public DateOnly Date { get; set; }
        public DateTime LoggedAt { get; set; }
    }
}
