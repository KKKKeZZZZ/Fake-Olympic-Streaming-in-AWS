#pragma checksum "C:\Users\kuheh\Desktop\group12\group12\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd435fafca161e181b355f7214f8b47f575d13c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kuheh\Desktop\group12\group12\Views\_ViewImports.cshtml"
using group12;

#line default
#line hidden
#line 2 "C:\Users\kuheh\Desktop\group12\group12\Views\_ViewImports.cshtml"
using group12.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd435fafca161e181b355f7214f8b47f575d13c7", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f1b59fc028b651cf53700250fdd1a7a5119f5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\kuheh\Desktop\group12\group12\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Video";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\kuheh\Desktop\group12\group12\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Users\kuheh\Desktop\group12\group12\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 2680, true);
            WriteLiteral(@"</h3>

<p>
    <video id='my-video' class='video-js' controls preload='auto' width=""1000"" height=""800""
           poster='https://stillmed.olympic.org/media/Images/OlympicOrg/News/2017/06/09/2017-06-09-tokyo2020-thumbnail.jpg?interpolation=lanczos-none&resize=*:*' data-setup='{}'>
        <source src='https://olympicsgroup12.s3-ap-southeast-2.amazonaws.com/UniSA.mp4'>
        <source src='MY_VIDEO.webm' type='video/webm'>
    </video>
</p>
<div class=""w3-content"" style=""max-width:1100px"">

    <div class=""w3-col m6 w3-padding-large"">
        <h1 class=""w3-center"">About Olympic Games</h1><br>
        <h5 class=""w3-center"">Tradition since 1896</h5>
        <p class=""w3-large"">
            The modern Olympic Games or Olympics are leading international
            sporting events featuring summer and winter sports competitions in which thousands of athletes from around the world participate in a variety of competitions.
            The Olympic Games are considered the world's foremost sports comp");
            WriteLiteral(@"etition with more than 200 nations participating. The Olympic Games are held every four years,
            with the Summer and Winter Games alternating by occurring every four years but two years apart.
        </p>

        <p class=""w3-large w3-text-grey w3-hide-medium"">
            The Ancient Olympic Games were religious and athletic festivals held every
            four years at the sanctuary of Zeus in Olympia,
            Greece. Competition was among representatives of several city-states and kingdoms of Ancient Greece.
            These Games featured mainly athletic but also combat sports such as wrestling and the pankration, horse and chariot racing events.
            It has been widely written that during the Games, all conflicts among the participating city-states were postponed until the Games were finished.
            This cessation of hostilities was known as the Olympic peace or truce. This idea is a modern myth because the Greeks never suspended their wars.
            The truce");
            WriteLiteral(@" did allow those religious pilgrims who were travelling to Olympia to pass through warring territories unmolested because they were protected by Zeus.
        </p>
    </div>
</div>
<div class=""w3-row w3-padding-64"" id=""menu"">
    <div class=""w3-col l6 w3-padding-large"">
        <h1 class=""w3-center"">When 2020 Olympic start?</h1><br>
        <p class=""w3-text-grey"">2020 Olympic Games will start on 24th July 2020.</p><br>

        <h4>When it will be finished?</h4>
        <p class=""w3-text-grey"">It will be finished on 9th Aug 2020</p><br>
    </div>
    <div class=""w3-col l6 w3-padding-large""></div>
</div>


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591