#pragma checksum "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9e2a4f3abcb18623fa351b7e9f72ef9052357d"
// <auto-generated/>
#pragma warning disable 1591
namespace AtndTrackBlazorApp.Client.Pages.Organization
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
#line 4 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
using AtndTrackBlazorApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
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
            __builder.AddMarkupContent(0, "<h3>Department</h3>\r\n");
#nullable restore
#line 8 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
 if (departmentModels == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", " card");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(12);
            __builder.AddAttribute(13, "class", "nav-link");
            __builder.AddAttribute(14, "href", "department/0");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Add Departments\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "d-xl-table-cell");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<thead>\r\n                <tr><th>Id</th><th>Name</th><th>Actins</th></tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 27 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
                 foreach (var item in departmentModels)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 30 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 31 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-inline");
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", 
#nullable restore
#line 34 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
                                                                  $"department/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                                    <span class=\"oi oi-external-link\" aria-hidden=\"true\"></span>Edit\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            __builder.AddAttribute(47, "class", "nav-link");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "\r\n                                    <span class=\"oi oi-delete\" aria-hidden=\"true\"></span>Delete\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 43 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 47 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\Samples\BlazorSamples\AtndTrack\AtndTrackBlazorApp\AtndTrackBlazorApp\Client\Pages\Organization\Department.razor"
       

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