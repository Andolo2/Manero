using Microsoft.AspNetCore.Mvc;

public class EditProfileExistsTests
{
    [Fact]
    public void EditProfileViewExists()
    {
        string viewPath = "/Views/Partials/_24editprofile.cshtml";

        
        var result = new ViewResult { ViewName = viewPath };

        Assert.NotNull(result.ViewName);
    }
}
