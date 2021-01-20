using AtndTrackBlazorApp.Client.Models.Account;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Client.Services
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task Login(Login model);
        Task Logout();
    }
    public class AccountService : IAccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";

        public User User { get; private set; }

        public AccountService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            //User = await _localStorageService.GetItem<User>(_userKey);
        }

        public async Task Login(Login model)
        {
            try
            {


                var result = await _httpService.Post<bool>("api/user/authenticate", model);
                Console.WriteLine("INitali called  sdsdsdsd:" + result);
                User = new User();
                await _localStorageService.SetItem(_userKey, User);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("account/login");
        }
    }
}
