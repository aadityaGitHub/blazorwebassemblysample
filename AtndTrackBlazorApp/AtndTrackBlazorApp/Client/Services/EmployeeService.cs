using AtndTrackBlazorApp.Client.Models.Account;
using AtndTrackBlazorApp.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Client.Services
{
    public interface IEmployeeService
    {
        EmployeeModel[] EmployeeModels { get; }

        Task Initialize();
    }

    public class EmployeeService : IEmployeeService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public EmployeeModel[] EmployeeModels { get; private set; }
        private string _userKey = "user";
        public EmployeeService(
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
            try
            {


                var response = await _httpService.Get<IEnumerable<EmployeeModel>>("api/Employee").ConfigureAwait(false);
                EmployeeModels = response.ToArray();
            }
            catch (Exception ex)
            {

                Console.WriteLine("INitali called", ex);
                throw;
            }
        }

    }
}
