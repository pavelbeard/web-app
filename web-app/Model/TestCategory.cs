namespace web_app.Model
{
    public class TestCategory
    {
        public int ID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public List<TestCar> Cars { get; set; }
    }
}
