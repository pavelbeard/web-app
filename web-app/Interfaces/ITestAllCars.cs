using web_app.Model;

namespace web_app.Interfaces
{
    public interface ITestAllCars
    {
        IEnumerable<TestCar> Cars { get; }
        IEnumerable<TestCar> GetFavCars { get; set; }
        TestCar GetObjectCar(int getIdCar);
    }
}
