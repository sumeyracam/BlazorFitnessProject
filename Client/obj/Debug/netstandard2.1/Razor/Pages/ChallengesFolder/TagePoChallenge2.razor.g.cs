#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\ChallengesFolder\TagePoChallenge2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "545dee27db5fbe5f575f50d47cbbc917b137587c"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorapp.Client.Pages.ChallengesFolder
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
#line 11 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TagePoChallenge")]
    public partial class TagePoChallenge2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<font face=\"Times New Roman\" size=\"7\" color=\"black\"> 30 DAY Tage Po Challenge </font>\n\n");
            __builder.AddMarkupContent(1, "<html>\n<head>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <style>\n        * {\n            box-sizing: border-box;\n        }\r\n\r\n        body {\r\n            font-family: \'Comic Sans MS\',Verdana;\r\n            background-image: url(\"https://image.freepik.com/free-photo/weight-loss-composition-with-space-left_23-2147692074.jpg\");\r\n            background-repeat: no-repeat;\r\n            background-size: 100% 100%;\r\n            background-position-x: right;\r\n        }\n        /* Float four columns side by side */\n        .column {\n            float: left;\n            width: 20%;\n            padding: 10px;\n        }\n\n        /* Remove extra left and right margins, due to padding */\n        .row {\n            margin: 0 -5px;\n        }\n\n            /* Clear floats after the columns */\n            .row:after {\n                content: \"\";\n                display: table;\n                clear: both;\n            }\n\n        /* Responsive columns */\n        @media screen and (max-width: 600px) {\n            .column {\n                width: 100%;\n                display: block;\n                margin-bottom: 20px;\n            }\n        }\n\n        /* Style the counter cards */\n        .card {\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);\n            padding: 25px;\n            text-align: center;\n            background-color: #f3f4f1;\n        }\n    </style>\n</head>\n<body>\n\n    <div class=\"row\">\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 1 </h3>\n                <p>15 SQUATS</p>\n                <p>10 LEG-LIFTS</p>\n                <p>5 BRIDGES</p>\n                <p>10 LUNGES</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 2 </h3>\n                <p>20 SQUATS</p>\n                <p>12 LEG-LIFTS</p>\n                <p>5 BRIDGES</p>\n                <p>12 LUNGES</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 3 </h3>\n                <p>20 SQUATS</p>\n                <p>12 LEG-LIFTS</p>\n                <p>10 BRIDGES</p>\n                <p>12 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 4 </h3>\n                <p>25 SQUATS</p>\n                <p>15 LEG-LIFTS</p>\n                <p>10 BRIDGES</p>\n                <p>15 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 5</h3>\n                <p>30 SQUATS</p>\n                <p>20 LEG-LIFTS</p>\n                <p>10 BRIDGES</p>\n                <p>20 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 6</h3>\n                <p>30 SQUATS</p>\n                <p>20 LEG-LIFTS</p>\n                <p>15 BRIDGES</p>\n                <p>20 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 7</h3>\n                <p>35 SQUATS</p>\n                <p>20 LEG-LIFTS</p>\n                <p>15 BRIDGES</p>\n                <p>20 LUNGES</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 8</h3>\n                <p>35 SQUATS</p>\n                <p>25 LEG-LIFTS</p>\n                <p>20 BRIDGES</p>\n                <p>25 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 9</h3>\n                <p>35 SQUATS</p>\n                <p>25 LEG-LIFTS</p>\n                <p>20 BRIDGES</p>\n                <p>25 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 10</h3>\n                <p>40 SQUATS</p>\n                <p>25 LEG-LIFTS</p>\n                <p>25 BRIDGES</p>\n                <p>30 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 11</h3>\n                <p>40 SQUATS</p>\n                <p>30 LEG-LIFTS</p>\n                <p>25 BRIDGES</p>\n                <p>30 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 12</h3>\n                <p>45 SQUATS</p>\n                <p>30 LEG-LIFTS</p>\n                <p>30 BRIDGES</p>\n                <p>30 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 13</h3>\n                <p>45 SQUATS</p>\n                <p>30 LEG-LIFTS</p>\n                <p>30 BRIDGES</p>\n                <p>35 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 14</h3>\n                <p>50 SQUATS</p>\n                <p>35 LEG-LIFTS</p>\n                <p>30 BRIDGES</p>\n                <p>35 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 15</h3>\n                <p>50 SQUATS</p>\n                <p>35 LEG-LIFTS</p>\n                <p>35 BRIDGES</p>\n                <p>40 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 16</h3>\n                <p>55 SQUATS</p>\n                <p>40 LEG-LIFTS</p>\n                <p>35 BRIDGES</p>\n                <p>40 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 17</h3>\n                <p>55 SQUATS</p>\n                <p>40 LEG-LIFTS</p>\n                <p>40 BRIDGES</p>\n                <p>40 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 18</h3>\n                <p>55 SQUATS</p>\n                <p>40 LEG-LIFTS</p>\n                <p>40 BRIDGES</p>\n                <p>45 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 19</h3>\n                <p>60 SQUATS</p>\n                <p>45 LEG-LIFTS</p>\n                <p>45 BRIDGES</p>\n                <p>45 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 20</h3>\n                <p>60 SQUATS</p>\n                <p>45 LEG-LIFTS</p>\n                <p>45 BRIDGES</p>\n                <p>50 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 21</h3>\n                <p>65 SQUATS</p>\n                <p>50 LEG-LIFTS</p>\n                <p>50 BRIDGES</p>\n                <p>50 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 22</h3>\n                <p>65 SQUATS</p>\n                <p>50 LEG-LIFTS</p>\n                <p>50 BRIDGES</p>\n                <p>55 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 23</h3>\n                <p>65 SQUATS</p>\n                <p>50 LEG-LIFTS</p>\n                <p>55 BRIDGES</p>\n                <p>55 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 24</h3>\n                <p>70 SQUATS</p>\n                <p>50 LEG-LIFTS</p>\n                <p>60 BRIDGES</p>\n                <p>55 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 25</h3>\n                <p>70 SQUATS</p>\n                <p>50 LEG-LIFTS</p>\n                <p>60 BRIDGES</p>\n                <p>60 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 26</h3>\n                <p>70 SQUATS</p>\n                <p>55 LEG-LIFTS</p>\n                <p>65 BRIDGES</p>\n                <p>60 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 27</h3>\n                <p>75 SQUATS</p>\n                <p>55 LEG-LIFTS</p>\n                <p>65 BRIDGES</p>\n                <p>65 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 28</h3>\n                <p>75 SQUATS</p>\n                <p>55 LEG-LIFTS</p>\n                <p>70 BRIDGES</p>\n                <p>65 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8CEF6;\">\n                <h3>DAY 29</h3>\n                <p>80 SQUATS</p>\n                <p>60 LEG-LIFTS</p>\n                <p>70 BRIDGES</p>\n                <p>65 LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #E0F8E0;\">\n                <h3>DAY 30</h3>\n                <p>80 SQUATS</p>\n                <p>60 LEG-LIFTS</p>\n                <p>75 BRIDGES</p>\n                <p>70 LUNGES</p>\n            </div>\n        </div>\n    </div>\n</body>\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
