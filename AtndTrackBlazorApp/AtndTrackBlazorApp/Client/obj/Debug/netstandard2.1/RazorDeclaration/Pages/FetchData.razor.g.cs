#pragma checksum "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ca889bc028f8951d9d4fd222105ece284a8112"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AtndTrackBlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using AtndTrackBlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\_Imports.razor"
using AtndTrackBlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\FetchData.razor"
using AtndTrackBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591