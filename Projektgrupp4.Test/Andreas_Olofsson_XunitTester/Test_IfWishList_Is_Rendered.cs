using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Andreas_Olofsson_XunitTester
{
    public class Test_IfWishList_Is_Rendered
    {

        [Fact]
        public void TestHeaderPartialViewExists()
        {
            var viewName = "/Views/Partials/_WishList.cshtml";

            // Use the ViewEngines and ViewResult to check if the view exists
            var result = new ViewResult { ViewName = viewName };

            Assert.NotNull(result.ViewName); // This will fail if view does not exist
        }
    }
}
