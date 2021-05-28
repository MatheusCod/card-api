namespace CardApi.Models
{
    public class CardItem
    {
        public long Id { get; set; }
        public string card { get; set; }
        public string email { get; set; }
        public bool IsComplete { get; set; }
    }
}