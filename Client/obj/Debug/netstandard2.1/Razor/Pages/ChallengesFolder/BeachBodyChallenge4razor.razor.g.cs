#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\ChallengesFolder\BeachBodyChallenge4razor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "908a957c7fb54ab99465153f0253bc76f99a99bb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BeachBodyChallenge")]
    public partial class BeachBodyChallenge4razor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<font face=\"\'Comic Sans MS\'\" size=\"8\" color=\"white\"> 30 Day Beach Body Challenge </font>\n\n");
            __builder.AddMarkupContent(1, "<html>\n<head>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <style>\n        * {\n            box-sizing: border-box;\n        }\r\n\r\n        body {\r\n            font-family: \'Comic Sans MS\',Verdana;\r\n            background-image: url(\"https://image.freepik.com/free-photo/top-view-red-weights-with-sneakers-copy-space_23-2148523332.jpg\");\r\n            background-repeat: no-repeat;\r\n            background-size: 100% 100%;\r\n            background-position-x: right;\r\n        }\n\n        /* Float four columns side by side */\n        .column {\n            float: left;\n            width: 20%;\n            padding: 10px;\n        }\n\n        /* Remove extra left and right margins, due to padding */\n        .row {\n            margin: 0 -5px;\n        }\n\n            /* Clear floats after the columns */\n            .row:after {\n                content: \"\";\n                display: table;\n                clear: both;\n            }\n\n        /* Responsive columns */\n        @media screen and (max-width: 600px) {\n            .column {\n                width: 100%;\n                display: block;\n                margin-bottom: 20px;\n            }\n        }\n\n        /* Style the counter cards */\n        .card {\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);\n            padding: 25px;\n            text-align: center;\n            background-color: #f3f4f1;\n        }\n    </style>\n</head>\n<body>\n\n    <div class=\"row\">\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 1 </h3>\n                <p>20 JUMPING JACKS</p>\n                <p>10 SIT UPS</p>\n                <p>10 SQUATS</p>\n                <p>5 PUSH UPS</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 2 </h3>\n                <p>20 HIGH KNEES</p>\n                <p>10 SECOND PLANK</p>\n                <p>10 LUNGES</p>\n                <p>5 PUSH UPS</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 3 </h3>\n                <p>20 JUMPING JACKS</p>\n                <p>10 SIT UPS</p>\n                <p>10 SQUATS</p>\n                <p>6 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 4 </h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 5</h3>\n                <p>20 HIGH KNEES</p>\n                <p>10 SECOND PLANK</p>\n                <p>10 LUNGES</p>\n                <p>6 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 6</h3>\n                <p>25 JUMPING JACKS</p>\n                <p>12 SIT UPS</p>\n                <p>12 SQUATS</p>\n                <p>7 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 7</h3>\n                <p>25 HIGH KNEES</p>\n                <p>12 SECOND PLANK</p>\n                <p>12 LUNGES</p>\n                <p>8 PUSH UPS</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 8</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 9</h3>\n                <p>25 JUMPING JACKS</p>\n                <p>14 SIT UPS</p>\n                <p>14 SQUATS</p>\n                <p>8 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 10</h3>\n                <p>25 HIGH KNEES</p>\n                <p>14 SECOND PLANK</p>\n                <p>14 LUNGES</p>\n                <p>9 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 11</h3>\n                <p>30 JUMPING JACKS</p>\n                <p>16 SIT UPS</p>\n                <p>16 SQUATS</p>\n                <p>10 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 12</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 13</h3>\n                <p>30 HIGH KNEES</p>\n                <p>16 SECOND PLANK</p>\n                <p>16 LUNGES</p>\n                <p>10 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 14</h3>\n                <p>30 JUMPING JACKS</p>\n                <p>18 SIT UPS</p>\n                <p>18 SQUATS</p>\n                <p>11 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 15</h3>\n                <p>30 HIGH KNEES</p>\n                <p>18 SECOND PLANK</p>\n                <p>18 LUNGES</p>\n                <p>12 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 16</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 17</h3>\n                <p>35 JUMPING JACKS</p>\n                <p>20 SIT UPS</p>\n                <p>20 SQUATS</p>\n                <p>12 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 18</h3>\n                <p>35 HIGH KNEES</p>\n                <p>20 SECOND PLANK</p>\n                <p>20 LUNGES</p>\n                <p>13 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 19</h3>\n                <p>35 JUMPING JACKS</p>\n                <p>22 SIT UPS</p>\n                <p>22 SQUATS</p>\n                <p>14 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 20</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                \">\n                <h3>DAY 21</h3>\n                <p>35 HIGH KNEES</p>\n                <p>22 SECOND PLANK</p>\n                <p>22 LUNGES</p>\n                <p>14 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 22</h3>\n                <p>40 JUMPING JACKS</p>\n                <p>24 SIT UPS</p>\n                <p>24 SQUATS</p>\n                <p>15 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 23</h3>\n                <p>40 HIGH KNEES</p>\n                <p>24 SECOND PLANK</p>\n                <p>24 LUNGES</p>\n                <p>16 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 24</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 25</h3>\n                <p>40 JUMPING JACKS</p>\n                <p>26 SIT UPS</p>\n                <p>26 SQUATS</p>\n                <p>16 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 26</h3>\n                <p>40 HIGH KNEES</p>\n                <p>26 SECOND PLANK</p>\n                <p>26 LUNGES</p>\n                <p>17 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 27</h3>\n                <p>45 JUMPING JACKS</p>\n                <p>28 SIT UPS</p>\n                <p>28 SQUATS</p>\n                <p>18 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 28</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFDAB9;\">\n                <h3>DAY 29</h3>\n                <p>45 HIGH KNEES</p>\n                <p>28 SECOND PLANK</p>\n                <p>28 LUNGES</p>\n                <p>18 PUSH UPS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #FFEFD5;\">\n                <h3>DAY 30</h3>\n                <p>50 JUMPING JACKS</p>\n                <p>30 SIT UPS</p>\n                <p>30 SQUATS</p>\n                <p>19 PUSH UPS</p>\n            </div>\n        </div>\n    </div>\n</body>\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
