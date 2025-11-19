namespace GoodPup.DTO
{
    public class FeedingLog
    {
        public int Id { get; set; }
        public int PupId { get; set; }
        public DateOnly Date { get; set; }
        public FeedingType FeedingType { get; set; } // AM or PM
        public DateTime LoggedAt { get; set; }
    }

    public enum FeedingType
    {
        AM,
        PM
    }
}
