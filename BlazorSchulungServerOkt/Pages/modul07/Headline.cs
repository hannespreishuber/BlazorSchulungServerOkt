using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungServerOkt.Pages.modul07
{
    public class Headline : ComponentBase
    {
        [Parameter]
        public string MyProperty { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "H1");
            builder.AddContent(2, MyProperty);
            builder.CloseElement();
        }
    }
}
