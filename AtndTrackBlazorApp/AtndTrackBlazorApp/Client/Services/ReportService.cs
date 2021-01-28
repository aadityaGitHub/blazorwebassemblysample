using AtndTrackBlazorApp.Client.Models.Account;
using AtndTrackBlazorApp.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Client.Services
{
    public interface IReportService
    {
        EmployeeLeaveReportModel[] Models { get; }

        Task Initialize();
    }

    public class ReportService : IReportService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public EmployeeLeaveReportModel[] Models { get; private set; }
        private string _userKey = "user";
        public ReportService(
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
                var response = await _httpService.Get<IEnumerable<EmployeeLeaveReportModel>>("api/report").ConfigureAwait(false);
                Models = response.ToArray();
            }
            catch (Exception ex)
            {

                Console.WriteLine("INitali called", ex);
                throw;
            }
        }
    }
}
