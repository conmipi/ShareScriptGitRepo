#pragma checksum "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/_ViewImports.cshtml"
using ShareScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/_ViewImports.cshtml"
using ShareScript.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9158777317aec795847c93dec6312d433d85cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::ShareScript.TagHelpers.CalendarTagHelper __ShareScript_TagHelpers_CalendarTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c4050", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""
            integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
            crossorigin=""anonymous""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.css"" />

    <style>
        ");
                WriteLiteral(@"@media (max-width:575px) {
            .display-4 {
                font-size: 1.5rem;
            }

            .day h5 {
                background-color: #f8f9fa;
                padding: 3px 5px 5px;
                margin: -8px -8px 8px -8px;
            }

            .date {
                padding-left: 4px;
            }
        }

        ");
                WriteLiteral(@"@media (min-width: 576px) {
            .day {
                height: 8vw;
            }
        }

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
            -webkit-animation-name: fadeIn; /* Fade in the background */
            -webkit-animation-duration: 0.4s;
            animation-name: fadeIn;
            animation-duration: 0.4s
        }

        /* Modal Content */
        .modal-content {
            position: fixed;
            bottom: 50%;
            background-color: #fefefe;
            width: 100%;
            -webkit-animation-name: ");
                WriteLiteral(@"slideIn;
            -webkit-animation-duration: 0.4s;
            animation-name: slideIn;
            animation-duration: 0.4s
        }

        /* The Close Button */
        .close {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .modal-header {
            padding: 2px 16px;
            background-color: #5cb85c;
            color: white;
        }

        .modal-body {
            padding: 2px 16px;
        }


        /* Add Animation */
        ");
                WriteLiteral("@-webkit-keyframes slideIn {\n            from {\n                bottom: -300px;\n                opacity: 0\n            }\n\n            to {\n                bottom: 0;\n                opacity: 1\n            }\n        }\n\n        ");
                WriteLiteral("@keyframes slideIn {\n            from {\n                bottom: -300px;\n                opacity: 0\n            }\n\n            to {\n                bottom: 50%;\n                opacity: 1\n            }\n        }\n\n        ");
                WriteLiteral("@-webkit-keyframes fadeIn {\n            from {\n                opacity: 0\n            }\n\n            to {\n                opacity: 1\n            }\n        }\n\n        ");
                WriteLiteral("@keyframes fadeIn {\n            from {\n                opacity: 0\n            }\n\n            to {\n                opacity: 1\n            }\n        }\n    </style>\n    <!-- Bootstrap Date-Picker Plugin -->\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c8767", async() => {
                WriteLiteral(@"

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h2 id=""modal-header-name"">Modal Header</h2>
                <span class=""close"">&times;</span>
            </div>
            <div class=""modal-body"">
                <div class=""bootstrap-iso"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-md-6 col-sm-6 col-xs-12"">

                                <!-- Form code begins -->
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c9676", async() => {
                    WriteLiteral(@"
                                    <div class=""form-group"">
                                        <!-- Date input -->
                                        <label class=""control-label"" for=""date"">Date</label>
                                        <input class=""form-control"" id=""date"" name=""date"" placeholder=""MM/DD/YYY"" type=""text"" />
                                    </div>
                                    <div class=""form-group"">
                                        <!-- Submit button -->
                                        <button class=""btn btn-primary "" name=""submit"" type=""submit"">Submit</button>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <!-- Form code ends -->

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <button type=""button"" class=""btn btn-primary"" onclick=""PreviousMonth()"">Previous Month</button>
    <button type=""button"" class=""btn btn-primary"" onclick=""NextMonth()"">Next Month</button>
    <div id=""calendar-div"" class=""text-center"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("calendar", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb95df6e75f53d49db97e5d39ef8d0bf2c0dd83c12366", async() => {
                }
                );
                __ShareScript_TagHelpers_CalendarTagHelper = CreateTagHelper<global::ShareScript.TagHelpers.CalendarTagHelper>();
                __tagHelperExecutionContext.Add(__ShareScript_TagHelpers_CalendarTagHelper);
#nullable restore
#line 182 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/Home/Index.cshtml"
__ShareScript_TagHelpers_CalendarTagHelper.Month = ViewBag.Month;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("month", __ShareScript_TagHelpers_CalendarTagHelper.Month, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 182 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/Home/Index.cshtml"
__ShareScript_TagHelpers_CalendarTagHelper.Year = ViewBag.Year;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("year", __ShareScript_TagHelpers_CalendarTagHelper.Year, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 182 "/Users/dervinis/Desktop/SEAssignment/ShareScriptGitRepo/ShareScript/Views/Home/Index.cshtml"
__ShareScript_TagHelpers_CalendarTagHelper.Events = ViewBag.CalendarEvents;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("events", __ShareScript_TagHelpers_CalendarTagHelper.Events, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <script>

        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        //Get the modal header's name
        var modalHeaderName = document.getElementById(""modal-header-name"");

        //Div that contains the calendar
        var calendarDiv = document.getElementById(""calendar-div"");

        function DisplayModal(headerName) {
            modalHeaderName.innerHTML = ""Events on the "" + headerName;
            modal.style.display = ""block"";
        }

        //to be implemented
        //function PreviousMonth() {
        //    calendarDiv.remove();
        //}

        //function NextMonth() {
        //    calendarDiv.remove();
        //}

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of t");
                WriteLiteral(@"he modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }

        $(document).ready(function () {
            var date_input = $('input[name=""date""]'); //our date input has the name ""date""
            var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : ""body"";
            var options = {
                format: 'mm/dd/yyyy',
                container: container,
                todayHighlight: true,
                autoclose: true,
            };
            date_input.datepicker(options);
        })
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
