namespace GoodPup.DTO
{
    public class MedicationTask
    {
        public int Id { get; set; }
        public int PupId { get; set; }
        public string Name { get; set; } = string.Empty;
        public MedicationFrequency Frequency { get; set; } // Daily, Monthly, etc.
        public DateOnly NextDueDate { get; set; }
        public bool IsActive { get; set; }
    }

    public enum MedicationFrequency
    {
        Daily,
        Weekly,
        Monthly
    }
}
