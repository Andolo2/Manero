using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Contexts;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers;

public class MyAddressController : Controller
{
    private readonly DataContext _dataContext;

    public MyAddressController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public ActionResult GetAddresses()
    {
        var addresses = _dataContext.Adresses.ToList();
        var models = addresses.Select(x => new MyAddressViewModel
        {
            Title = x.Title,
            StreetName = x.StreetName
        }).ToList();
        return View(models);
    }

    public IActionResult Index()
    {
        return View();
    }
}
