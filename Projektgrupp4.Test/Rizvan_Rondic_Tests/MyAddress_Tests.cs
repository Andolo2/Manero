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

namespace Projektgrupp4.Test.Rizvan_Rondic_Tests;

public class MyAddress_Tests
{
    [Fact]
    public void MyAddressControllerFileExists()
    {
        // Arrange
        var filePath = "I:\\WIN22\\Projekt\\Projekt\\Manero\\Projektgrupp4\\Controllers\\MyAddressController.cs"; // Hårdkodat path.

        // Act
        bool fileExists = File.Exists(filePath);

        // Assert
        Assert.True(fileExists, $"The file at '{filePath}' does not exist.");

        //// Arrange
        //var filePath = "Controllers/MyAddressController.cs";

        //// Act
        //bool fileExists = File.Exists(filePath);

        //// Assert
        //Assert.True(fileExists, $"The file at '{filePath}' does not exist.");

    }

}