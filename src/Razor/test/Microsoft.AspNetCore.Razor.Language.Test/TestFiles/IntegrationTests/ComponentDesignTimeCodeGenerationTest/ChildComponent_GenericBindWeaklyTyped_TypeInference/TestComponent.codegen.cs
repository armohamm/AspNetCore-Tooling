// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(builder, -1, -1, 
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                     18

#line default
#line hidden
            , -1, Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                       Value

#line default
#line hidden
            ), -1, Microsoft.AspNetCore.Components.BindMethods.SetValueHandler(__value => Value = __value, Value));
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    string Value;

#line default
#line hidden
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Value", __arg0);
        builder.AddAttribute(__seq1, "Item", __arg1);
        builder.AddAttribute(__seq2, "ItemChanged", __arg2);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
