#pragma checksum "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411b24c67ee705817b46bc794ca7d473fdb11f0e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorapp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityList.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ActivityList")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ActivityList/{Id:int}")]
    public partial class ActivityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityList.razor"
        private Activity[] activityList;
            private ActivityValue[] activityValues;
            [Parameter] public int Id { get; set; }
            private int option = 0;

            protected override async Task OnInitializedAsync()

            {
                activityList = await http.GetFromJsonAsync<Activity[]>("api/Activities");
                activityValues = await http.GetFromJsonAsync<ActivityValue[]>("api/ActivityValues");
            }



            async Task Delete(int activityId)
            {
                await http.DeleteAsync($"api/Activities/{activityId}");
                await OnInitializedAsync();

            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
