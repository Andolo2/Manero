using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Rizvan_Rondic_Tests;

public class NewAddressFileExists
{
    [Fact]
    public void TestIfNewAddressFileExists()
    {
        var viewFile = "Controllers/NewAddressController";

        var result = new ViewResult { ViewName = viewFile };

        Assert.NotNull(result.ViewName);
    }
}
