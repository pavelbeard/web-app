using web_app.Interfaces;
using web_app.Model;

namespace web_app.Mocks
{
    public class TMockCategory : ITestCarsCategory
    {
        public IEnumerable<TestCategory> AllCategories
        {
            get => new List<TestCategory>
            {
                new TestCategory {CategoryName = "E-Mobile", Description = "Современный вид транспорта" },
                new TestCategory {CategoryName = "Автомобили ВС", Description = "Машины с ДВС" }
            };
        }
    }
}
