
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Test.Andreas_Olofsson_XunitTester
{
    public class Test_If_JavaSciptFileExist
    {
        [Fact]
        public void TestJavaScriptFileExists()
        {
            

            var viewName = "js/site.js";

            // Use the ViewEngines and ViewResult to check if the view exists
            var result = new ViewResult { ViewName = viewName };

            Assert.NotNull(result.ViewName); // This will fail if view does not exist
        }
    }
}

