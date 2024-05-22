namespace JimmyAlbarracin_MAUIApp.Models
{
    public class Burger
    {
        public int id { get; set; }
        public string? name { get; set; }
        public bool withCheese { get; set; }
        public decimal precio { get; set; }
        public object[]? promos { get; set; }
    }
}

