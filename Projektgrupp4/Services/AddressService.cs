using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Repositories;
using Projektgrupp4.ViewModels;
using System.Diagnostics;
using Uppgift.Helpers.Repositories;

namespace Projektgrupp4.Services;

public class AddressService
{
    //private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
    //private readonly SignInManager<UserEntity> _signInManager;
    private readonly AddressRepository _addressRepository;
    private readonly UserAddressRepository _userAddressRepository;

    public AddressService(/*Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager*/ /*SignInManager<UserEntity> signInManager*/ AddressRepository addressRepository, UserAddressRepository userAddressRepository)
    {
        _userAddressRepository = userAddressRepository;
        _addressRepository = addressRepository;
        //_signInManager = signInManager;
        //_userManager = userManager;
    }

    public async Task<bool> RegisterAddressAsync(NewAddressViewModel viewModel)
    {
        try
        {
            var address = await GetOrCreateAsync(viewModel);
            return await AddUserAddress(address!.Id, address.Id);

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        return false;
    }

    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity entity)
    {
        var _entity = await _addressRepository.GetAsync(x => x.StreetName == entity.StreetName && x.Title == entity.Title);
        _entity ??= await _addressRepository.AddAsync(entity);

        return entity;
    }

    public async Task<List<AddressEntity>> GetAllAddressesAsync()
    {
        try
        {
            var addresses = await _addressRepository.GetAllAsync();

            return addresses.ToList();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return new List<AddressEntity>();
        }
    }

    public async Task<bool> AddUserAddress(Guid userId, Guid addressId)
    {
        try
        {
            var entity = await _userAddressRepository.AddAsync(new UserAddressEntity
            {
                UserId = userId,
                AddressId = addressId
            });
            if (entity != null)
                return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public Task GetOrCreateAsync(string streetName)
    {
        throw new NotImplementedException();
    }
}



//var addressEntity = new AddressEntity
//{
//    StreetName = viewModel.StreetName,
//    Title = viewModel.Title
//};

//var resultAddress = await GetOrCreateAsync(addressEntity);

//var _user = await _userManager.FindByIdAsync(viewModel.UserId.ToString());

//if (_user != null)
//{
//    if (Guid.TryParse(_user.Id, out Guid userId))
//    {
//        var resultUserAddress = await AddUserAddress(userId, resultAddress.Id);

//        return resultAddress != null && resultUserAddress;
//    }
//    else
//    {
//        Debug.WriteLine("Invalid Guid format for user.Id");
//    }
//}