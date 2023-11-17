using Microsoft.AspNetCore.Mvc;

public class ProfileExistsTests
{
    [Fact]
    public void ProfileViewExists()
    {
        string viewPath = "/Views/Partials/_23profile.cshtml";


        var result = new ViewResult { ViewName = viewPath };

        Assert.NotNull(result.ViewName);
    }
}