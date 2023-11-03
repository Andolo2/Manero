using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Dtos;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services
{
    public class ColorService
    {
        private readonly DataContext _dataContext;

        public ColorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ColorEntity> CreateColorAsync(string colorName)
        {
            var entity = new ColorEntity { ColorName = colorName };
            _dataContext.Colors.Add(entity);

            await _dataContext.SaveChangesAsync();

            return entity;
        }


        //Används för att populera CreateProduct vy-modellen med färger
        public async Task<List<SelectListItem>> GetColorsAsync(string[] selectedColors)
        {
            var colors = new List<SelectListItem>();

            foreach (var color in await GetAllColorsAsync())
            {
                colors.Add(new SelectListItem
                {
                    Value = color.ColorId.ToString(),
                    Text = color.ColorName,
                    Selected = selectedColors.Contains(color.ColorId.ToString())
                });
            }
            return colors;
        }



        public async Task<IEnumerable<ColorEntity>> GetAllColorsAsync()
        {
            return await _dataContext.Set<ColorEntity>().ToListAsync();
        }
    }
}
