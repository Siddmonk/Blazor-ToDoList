#pragma checksum "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925bcca43252bde96f4ae61f600dc36958734c77"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Calculator</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""calculator-grid"">
    <div class=""output"">
        <div data-previous-operand class=""previous-operand"">123</div>
        <div data-current-operand class=""current-operand"">123</div>
    </div>
    <button data-all-clear class=""span-two"">AC</button>
    <button data-delete>DEL</button>
    <button data-operation>/</button>
    <button data-number>1</button>
    <button data-number>2</button>
    <button data-number>3</button>
    <button data-operation>*</button>
    <button data-number>4</button>
    <button data-number>5</button>
    <button data-number>6</button>
    <button data-operation>+</button>
    <button data-number>7</button>
    <button data-number>8</button>
    <button data-number>9</button>
    <button data-operation>-</button>
    <button data-number>.</button>
    <button data-number>0</button>
    <button data-equals class=""span-two"">=</button>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
