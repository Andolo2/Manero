using Projektgrupp4.Contexts;

namespace Projektgrupp4.Services;

public class ReviewsService
{
    private readonly DataContext _dataContext;

    public ReviewsService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


}
