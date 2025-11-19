namespace GoodPup.DTO
{
    public class WalkLog
    {
        public int Id { get; set; }
        public int PupId { get; set; }
        public DateOnly Date { get; set; }
        public int OutingNumber { get; set; } // 1, 2, or 3
        public DateTime LoggedAt { get; set; }
    }
}
