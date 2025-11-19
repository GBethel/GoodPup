namespace GoodPup.DTO
{
    public class Pup
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string PhotoUrl { get; set; } = string.Empty;
    }
}
