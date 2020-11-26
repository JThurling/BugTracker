#pragma checksum "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40927e2f1253ae6273328c15328228b566bb877"
// <auto-generated/>
#pragma warning disable 1591
namespace BugTracker.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using BugTracker.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using BugTracker.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\Blazor\BugTracker\Client\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
using Core.Models.Output.Bug;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tasks")]
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
 if (_tasks == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 bg-white shadow-sm");
            __builder.OpenComponent<AntDesign.Skeleton>(2);
            __builder.AddAttribute(3, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"col-12 mb-3\"><h3>Tasks</h3></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
#nullable restore
#line 17 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
         foreach (var task in _tasks)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "shadow-sm mb-2 card border-0");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-2");
            __builder.OpenElement(15, "h6");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                          () => ShowModal(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 23 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                                  task.Bug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-2");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                         () => DisplaySubTasks(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<AntDesign.Tag>(23);
            __builder.AddAttribute(24, "Style", "cursor: pointer");
            __builder.AddAttribute(25, "Color", "blue");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Subtask: ");
                __builder2.AddContent(28, 
#nullable restore
#line 26 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                                                                                          task.SubTasks.Count

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-2");
            __builder.OpenComponent<AntDesign.Tooltip>(32);
            __builder.AddAttribute(33, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.PlacementType>(
#nullable restore
#line 29 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                 PlacementType.TopLeft

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>>(
#nullable restore
#line 29 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                                                task.Priority

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 30 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                 if (task.Priority == "High")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Icon>(36);
                __builder2.AddAttribute(37, "Type", "flag");
                __builder2.AddAttribute(38, "Style", "font-size: 1.7em");
                __builder2.AddAttribute(39, "Class", "text-danger");
                __builder2.AddAttribute(40, "Theme", "outline");
                __builder2.CloseComponent();
#nullable restore
#line 33 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                } else if (task.Priority == "Medium")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Icon>(41);
                __builder2.AddAttribute(42, "Type", "flag");
                __builder2.AddAttribute(43, "Style", "font-size: 1.7em");
                __builder2.AddAttribute(44, "Class", "text-warning");
                __builder2.AddAttribute(45, "Theme", "outline");
                __builder2.CloseComponent();
#nullable restore
#line 36 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Icon>(46);
                __builder2.AddAttribute(47, "Type", "flag");
                __builder2.AddAttribute(48, "Style", "font-size: 1.7em");
                __builder2.AddAttribute(49, "Class", "text-secondary");
                __builder2.AddAttribute(50, "Theme", "outline");
                __builder2.CloseComponent();
#nullable restore
#line 40 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-2");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenComponent<AntDesign.Icon>(56);
            __builder.AddAttribute(57, "Type", "comment");
            __builder.AddAttribute(58, "Style", "font-size: 1.7em");
            __builder.AddAttribute(59, "Theme", "outline");
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n                                ");
            __builder.OpenElement(61, "p");
            __builder.AddAttribute(62, "style", "font-weight: bold");
            __builder.AddContent(63, 
#nullable restore
#line 46 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                              task.Comments.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n                        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-2");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "style", "font-weight: bold");
            __builder.AddContent(69, "Deadline: ");
            __builder.AddContent(70, 
#nullable restore
#line 51 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                                    task.Deadline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                     if ((Display && task.SubTasks.Count > 0) && Array.IndexOf(_tasks, task) == Index)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<hr>\r\n                        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class");
            __builder.AddMarkupContent(74, "<h6>Subtasks</h6>\r\n                            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-12 pt-3 pl-3");
            __builder.OpenComponent<AntDesign.Timeline>(77);
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 61 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                     foreach (var subtask in task.SubTasks)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.TimelineItem>(79);
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, 
#nullable restore
#line 63 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                                       subtask.Task

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 64 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Modal>(82);
            __builder.AddAttribute(83, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>(
#nullable restore
#line 75 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                "Title"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "Centered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                 _visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
                  HideModal

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(87, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Double>>(
#nullable restore
#line 79 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
              1320

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(89, "p");
                __builder2.AddContent(90, 
#nullable restore
#line 80 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
        Bug.Priority

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Code\Blazor\BugTracker\Client\Pages\Tasks.razor"
       
    bool _visible = false;
    private BugOutput[] _tasks;
    private BugOutput Bug { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _tasks = await Http.GetFromJsonAsync<BugOutput[]>("api/bug");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool Display = true;
    public int Index;

    public void DisplaySubTasks(BugOutput bug)
    {
        Display = !Display;
        Index = Array.IndexOf(_tasks, bug);
    }

    private void ShowModal(BugOutput bug)
    {
        _visible = true;
        Bug = bug;
    }

    private void HideModal()
    {
        _visible = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
