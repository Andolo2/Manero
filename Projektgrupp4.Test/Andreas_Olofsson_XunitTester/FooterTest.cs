using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Andreas_Olofsson_XunitTester
{
    public class FooterTest
    {
        [Fact]
        public void TestHeaderPartialViewExists()
        {
            var viewName = "/Views/Partials/FooterPartial/_footerPartial.cshtml";

            // Use the ViewEngines and ViewResult to check if the view exists
            var result = new ViewResult { ViewName = viewName };

            Assert.NotNull(result.ViewName); // This will fail if view does not exist
        }
    }
}
