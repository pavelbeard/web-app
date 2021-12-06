using web_app.Model;

namespace web_app.Interfaces
{
    public interface ITestCarsCategory
    {
        IEnumerable<TestCategory> AllCategories { get; }
    }
}
