#pragma checksum "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\Pages\Organization\Department.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9e2a4f3abcb18623fa351b7e9f72ef9052357d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AtndTrackBlazorApp.Client.blazorsamplewebapp.Pages.Organization
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using AtndTrackBlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\_Imports.razor"
using AtndTrackBlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\Pages\Organization\Department.razor"
using AtndTrackBlazorApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\Pages\Organization\Department.razor"
using AtndTrackBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/department")]
    public partial class Department : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\blazorsamplewebapp\Pages\Organization\Department.razor"
       

    private DepartmentModel[] departmentModels;
    protected override async Task OnInitializedAsync()
    {
        var response = await httpClient.GetJsonAsync<DepartmentModel[]>("api/Organization/departments").ConfigureAwait(false);
        Console.WriteLine("respnose ", response);
        departmentModels = response;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
