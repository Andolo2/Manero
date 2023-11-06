using Azure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services
{
    public class SizeService
    {

        private readonly DataContext _dataContext;

        public SizeService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<SizeEntity> CreateSizeAsync(string sizeName)
        {
            var entity = new SizeEntity { SizeName = sizeName };
            _dataContext.Sizes.Add(entity);

            await _dataContext.SaveChangesAsync();

            return entity;
        }
        //Används för att populera CreateProduct vy-modellen med storlekar
        public async Task<List<SelectListItem>> GetSizesAsync(string[] selectedSizes)
        {
            var sizes = new List<SelectListItem>();

            foreach (var size in await GetAllSizesAsync())
            {
                sizes.Add(new SelectListItem
                {
                    Value = size.SizeId.ToString(),
                    Text = size.SizeName,
                    Selected = selectedSizes.Contains(size.SizeId.ToString())
                });
            }
            return sizes;
        }

        public async Task<IEnumerable<SizeEntity>> GetAllSizesAsync()
        {
            return await _dataContext.Set<SizeEntity>().ToListAsync();
        }

  
    }
}