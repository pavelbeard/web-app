using Microsoft.AspNetCore.Mvc;
using web_app.Interfaces;

namespace web_app.Controllers
{
    public class TCarsController : Controller
    {
        private readonly ITestAllCars _allCars;
        private readonly ITestCarsCategory _allCarsCategory;

        public TCarsController(ITestAllCars allCars, ITestCarsCategory allCarsCategory)
        {
            _allCars = allCars;
            _allCarsCategory = allCarsCategory;
        }

        public ViewResult List() => View(_allCars.Cars);
    }
}
