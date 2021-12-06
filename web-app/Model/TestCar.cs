namespace web_app.Model
{
    public class TestCar
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LongDescription { get; set; }
        public string? Image { get; set; }
        public int? Price { get; set; }
        public bool? IsFavorite { get; set; }
        public bool? Available { get; set; }
        public int CategoryID { get; set; } 
        public virtual TestCategory Category { get; set; }

    }
}
