using web_app.Interfaces;
using web_app.Model;

namespace web_app.Mocks
{
    public class TMockCars : ITestAllCars
    {
        private readonly ITestCarsCategory _categoryCars = new TMockCategory();
        public IEnumerable<TestCar> Cars 
        {
            get => new List<TestCar>
            {
                new TestCar
                {
                    Name = "Tesla S",
                    Description = "Вжух",
                    LongDescription = "Вжух-вжух",
                    Image = "https://moscowteslaclub.ru/upload/resize_cache/iblock/cd8/570_321_2/0xpqkvlvedzzcco6j2zdz4okljezoevb.jpg.webp",
                    Price = 45000,
                    IsFavorite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.First(),
                },
                new TestCar
                {
                    Name = "Tesla M",
                    Description = "Вжух",
                    LongDescription = "Вжух-вжух",
                    Image = "https://moscowteslaclub.ru/upload/resize_cache/iblock/31b/570_321_2/lqnlfun9ppnwo6ab2rc6jrx1yv5m6znz.jpg.webp",
                    Price = 49000,
                    IsFavorite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.First(),
                },
                new TestCar
                {
                    Name = "Tesla L",
                    Description = "Вжух",
                    LongDescription = "Вжух-вжух",
                    Image = "https://moscowteslaclub.ru/upload/resize_cache/iblock/ebe/570_321_2/d6owd7n2lapjtbnfvyxbbwbv4r02yyfz.jpg.webp",
                    Price = 53000,
                    IsFavorite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.First(),
                },

            };
                
        }
        public IEnumerable<TestCar> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TestCar GetObjectCar(int getIdCar)
        {
            throw new NotImplementedException();
        }
    }
}
