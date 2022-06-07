// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorapp.Client.Pages.CalculatorsFolder
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
#line 2 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\BasalMetabolism.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\BasalMetabolism.razor"
using Blazorapp.Client.Pages.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BasalMetabolismCalculator")]
    public partial class BasalMetabolism : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\BasalMetabolism.razor"
        private const string green = "#1c7c00";
    private const string red = "#ff0000";

    private string maintenanceMessage = "";

    private string maintenanceMessageColor = "";

    private CaloricData Basal = new CaloricData();

    private void Calculate()
    {
        if (Basal.Weight > 0 && Basal.Height > 0 && Basal.Age > 0)
        {
            maintenanceMessageColor = green;
            maintenanceMessage = "";

            switch (Basal.Gender)
            {
                case (int)Enums.Gender.Male:

                    var maleResult = Math.Round((9.6 * Basal.Weight) + (1.8 * Basal.Height) - (4.7 * Basal.Age) + 655).ToString();
                    int.TryParse(maleResult, out int maleValue);
                    Basal.Maintenance = maleValue;
                    break;

                case (int)Enums.Gender.Female:
                    var femaleResult = Math.Round((13.7 * Basal.Weight) + (5 * Basal.Height) - (6.7 * Basal.Age) + 66.5).ToString();
                    int.TryParse(femaleResult, out int femaleValue);
                    Basal.Maintenance = femaleValue;

                    break;

                default:
                    break;
            }
        }
        else
        {
            maintenanceMessageColor = red;
            maintenanceMessage = "Invalid Inputs detected";
            Basal.Maintenance = 0;
        }
    }
 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
