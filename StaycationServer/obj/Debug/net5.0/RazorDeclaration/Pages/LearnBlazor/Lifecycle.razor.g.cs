// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StaycationServer.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using StaycationServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using StaycationServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\_Imports.razor"
using StaycationServer.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class Lifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\dszemenk\source\repos\Staycation\StaycationServer\Pages\LearnBlazor\Lifecycle.razor"
       
    private int currentCount = 0;
    List<string> EventType = new List<string>();

    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        EventType.Add("On initialized is called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("On initialized is called");
        await Task.Delay(1000);
    }
    protected override void OnParametersSet()
    {
        EventType.Add("On parameter is called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("On parameter async is called");
        await Task.Delay(1000);
    }
    protected override void OnAfterRender(bool firstrender)
    {
        EventType.Add("On render is called");
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("On render async is called");
        await Task.Delay(1000);
    }
    /*
    protected override bool ShouldRender()
    {
        EventType.Add("Should render is called");
    }*/

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
