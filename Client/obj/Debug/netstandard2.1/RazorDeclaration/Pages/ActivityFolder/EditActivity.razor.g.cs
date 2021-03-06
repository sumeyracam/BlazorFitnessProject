// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorapp.Client.Pages.ActivityFolder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\ActivityFolder\EditActivity.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditActivity/{Id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditActivity")]
    public partial class EditActivity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\ActivityFolder\EditActivity.razor"
        [Parameter] public string Id { get; set; }

    Activity act = new Activity();

    protected async override Task OnParametersSetAsync()
    {
        act = await http.GetFromJsonAsync<Activity>($"api/Activities/{Id}");
        act.TotalCalorie = CalculateCalorie(act.ActivityFeatureNavigation.Point, act.Hour);
    }

    async Task Edit()
    {
        await http.PutAsJsonAsync($"api/Activities/{Id}", act);
        await js.InvokeVoidAsync("alert", $"Updated Successfully!");
        nm.NavigateTo("ActivityList");
    }
    double CalculateCalorie(double point, double hours)
    {
        double level = 0;
        level += (point * hours);

        if (hours > 24)
        {
            Console.Write("time is more than 24 hours");
        }
        level += (24 - hours) * 1.2;
        level /= 24;
        return (level - 1) * 1020;

    }

 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
