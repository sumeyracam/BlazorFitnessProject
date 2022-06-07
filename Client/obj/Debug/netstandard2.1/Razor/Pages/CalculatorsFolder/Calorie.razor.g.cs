#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71abf403df1626377c8d74f20c2491ae69fd389"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorapp.Client.Pages.CalculatorsFolder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
using Blazorapp.Client.Pages.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DailyCalorieCalculator")]
    public partial class Calorie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
body { background-image: url(""https://images.unsplash.com/photo-1466637574441-749b8f19452f?ixlib=rb-1.2.1&auto=format&fit=crop&w=1400&q=80 "");
       background-repeat: no-repeat; 
       background-size: 85% 100%; 
       background-position-x: right; }
</style>
");
            __builder.AddMarkupContent(1, "<h1>Estimated Calorie Requirements></h1>\r\n");
            __builder.AddMarkupContent(2, "<div id=\"calories-content\">\r\n</div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "maintenance-calculator");
            __builder.AddAttribute(5, "class", "calculator");
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "flex-container");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<label for=\"Height\">Height</label>\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "range");
            __builder.AddAttribute(13, "min", "30");
            __builder.AddAttribute(14, "max", "240");
            __builder.AddAttribute(15, "step", "0,5");
            __builder.AddAttribute(16, "class", "slider");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                                                                      caloricData.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caloricData.Height = __value, caloricData.Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
            caloricData.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "flex-container");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<label for=\"Weight\">Weight</label>\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "range");
            __builder.AddAttribute(30, "min", "20");
            __builder.AddAttribute(31, "max", "200");
            __builder.AddAttribute(32, "step", "0,5");
            __builder.AddAttribute(33, "class", "slider");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                                                                      caloricData.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caloricData.Weight = __value, caloricData.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, 
#nullable restore
#line 26 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
            caloricData.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "flex-container");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.AddMarkupContent(44, "<label for=\"Age\">Age</label>\r\n        ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "range");
            __builder.AddAttribute(47, "min", "18");
            __builder.AddAttribute(48, "max", "99");
            __builder.AddAttribute(49, "step", "1");
            __builder.AddAttribute(50, "class", "slider");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                                                                   caloricData.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caloricData.Age = __value, caloricData.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "p");
            __builder.AddContent(55, 
#nullable restore
#line 32 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
            caloricData.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "flex-container");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "for", 
#nullable restore
#line 36 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                     caloricData.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(63, "Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "select");
            __builder.AddAttribute(66, "id", "Gender");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                        caloricData.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caloricData.Gender = __value, caloricData.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "0");
            __builder.AddContent(72, " Bir secenek seciniz");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", 
#nullable restore
#line 39 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                             (int)Gender.Male

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", 
#nullable restore
#line 40 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                             (int)Gender.Female

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "id", "maintenance-message");
            __builder.AddAttribute(87, "style", "color:" + (
#nullable restore
#line 45 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                          maintenanceMessageColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, 
#nullable restore
#line 45 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                                                    maintenanceMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "flex-container");
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.AddMarkupContent(93, "<label for=\"Result\">Result</label>\r\n    ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "text");
            __builder.AddAttribute(96, "readonly", true);
            __builder.AddAttribute(97, "id", "Result");
            __builder.AddAttribute(98, "value", 
#nullable restore
#line 49 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                                                    caloricData.Maintenance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "flex-container");
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
                      () => OnCalculateMaintenanceClick()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(106, "Result");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(109, "<div id=\"pal-calculator\" class=\"calculator\">\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
       private const string green = "#1c7c00";
    private const string red = "#ff0000";
    private string palMessage = "";
    private string maintenanceMessage = "";

    private string maintenanceMessageColor = "";
    private string palMessageColor = "";

    private bool palButtonDisabled => caloricData.Maintenance == 0;
    private CaloricData caloricData = new CaloricData();





    private void OnCalculateMaintenanceClick()
    {
        if (caloricData.Weight > 0 && caloricData.Height > 0 && caloricData.Age > 0)
        {
            maintenanceMessageColor = green;
            maintenanceMessage = "";

            switch (caloricData.Gender)
            {
                case (int) Enums.Gender.Male:

                    var maleResult = Math.Round((9.99 * caloricData.Weight) + (6.25 * caloricData.Height) - (4.92 * caloricData.Age) + 5).ToString();
                    int.TryParse(maleResult, out int maleValue);
                    caloricData.Maintenance = maleValue;
                    break;

                case (int) Enums.Gender.Female:
                    var femaleResult = Math.Round((9.99 * caloricData.Weight) + (6.25 * caloricData.Height) - (4.92 * caloricData.Age) - 161).ToString();
                    int.TryParse(femaleResult, out int femaleValue);
                    caloricData.Maintenance = femaleValue;

                    break;

                default:
                    break;
            }
        }
        else
        {
            maintenanceMessageColor = red;
            maintenanceMessage = "Invalid Inputs detected";
            caloricData.Maintenance = 0;
        }
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
