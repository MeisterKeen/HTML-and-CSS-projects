#pragma checksum "C:\Users\KeenMeister\Documents\GitHub\HTML-and-CSS-projects\Visual Studio\VSChallenge\VSChallenge\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7610e150b3a1ce996fa3a96ea3b9dd5368a6daa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VSChallenge.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace VSChallenge.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\KeenMeister\Documents\GitHub\HTML-and-CSS-projects\Visual Studio\VSChallenge\VSChallenge\Pages\_ViewImports.cshtml"
using VSChallenge;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7610e150b3a1ce996fa3a96ea3b9dd5368a6daa9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35339fb1386ebaf11320adece328cad8425d59a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\KeenMeister\Documents\GitHub\HTML-and-CSS-projects\Visual Studio\VSChallenge\VSChallenge\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h1 {
        color: green;
    }

    canvas {
        background-color: #F08080;
        width: 600px;
        height: 400px;
        position: absolute;
        top: 20%;
        left: 20%;
    }
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Heyo!</h1>
    <h2>I spun up an entire local web server just to display this page!</h2>
    <p>That's like using a Mazerati to cook hot dogs</p>
</div>

<br><br>

<div class=""jsanim"">
    <canvas>
    </canvas>
</div>

<script>
    var canvas = document.querySelector(""canvas"");

    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;

    var l = canvas.getContext('2d');

    // x and y are the coordinates of the circle
    // vx and vy are the respective speeds
    var x = Math.floor(Math.random() * innerWidth);
    var y = Math.floor(Math.random() * innerHeight);
    var vx = Math.floor(Math.random() * 2);
    var vy = Math.floor(Math.random() * 4);
    var radius = 20;

  ");
            WriteLiteral(@"  move();

    // This function will do the animation
    function move() {
        requestAnimationFrame(move);

        // It clears the specified pixels within
        // the given rectangle
        l.clearRect(0, 0, innerWidth, innerHeight);

        // Creating a circle
        l.beginPath();
        l.strokeStyle = ""black"";
        l.arc(x, y, radius, 0, Math.PI * 2, false);
        l.stroke();

        // Conditions so that the ball bounces
        // from the edges
        if (radius + x > innerWidth)
            vx = 0 - vx;

        if (x - radius < 0)
            vx = 0 - vx;

        if (y + radius > innerHeight)
            vy = 0 - vy;

        if (y - radius < 0)
            vy = 0 - vy;

        x = x + vx;
        y = y + vy;

    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
