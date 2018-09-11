using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create()
    {
      Car newCar = new Car(Request.Form["make-model"], int.Parse(Request.Form["car-price"]), int.Parse(Request.Form["car-mileage"]));

      newCar.Save();
      List<Car> carList = Car.GetAll();
      return View("Index", carList);
    }
  }
}
