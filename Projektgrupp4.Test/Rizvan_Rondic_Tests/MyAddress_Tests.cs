using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Controllers;
using Projektgrupp4.Contexts;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.IdentityModel.Tokens;
using Projektgrupp4.ViewModels;
using System.Net;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Test.Rizvan_Rondic_Tests;

public class MyAddress_Tests
{
    [Fact]
    public void TestIfThereAreAddressesInDatabase()
    {

        // Arrange
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new DataContext(options))
        {
            context.Adresses.Add(new AddressEntity { Title = "Address1", StreetName = "Street1", CountryName = "Sweden", CityName = "Örebro" });
            context.Adresses.Add(new AddressEntity { Title = "Address2", StreetName = "Street2", CountryName = "Sweden", CityName = "Örebro" });
            context.SaveChanges();
        }

        using (var context = new DataContext(options))
        {
            var controller = new MyAddressController(context);

            // Act
            var result = controller.GetAddresses();

            // Assert
            Assert.IsType<ViewResult>(result);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<List<MyAddressViewModel>>(viewResult.Model);
            
            Assert.NotEmpty(model);

        }

    }
}