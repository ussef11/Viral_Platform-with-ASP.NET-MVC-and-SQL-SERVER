#pragma checksum "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0150bb1a625bb63d9d57429ec380dd18eb099dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
#line 1 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\_ViewImports.cshtml"
using MyProjet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\_ViewImports.cshtml"
using MyProjet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0150bb1a625bb63d9d57429ec380dd18eb099dcf", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProjet.Models.Articles>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0150bb1a625bb63d9d57429ec380dd18eb099dcf3860", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
");
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
            WriteLiteral(@"

<div class=""container"">
    <div class=""text-right my-3"">
        <button class=""btn btn-info"" id=""getHTML"" get-data=""editor-1"">Get HTML</button>
    </div>
    <div class=""row align-items-center justify-content-center"">
        <div class=""col-md-12 col-lg-8"">
            <div class=""editor"" id=""editor-1"">
                <div class=""toolbar"">
                    <a href=""#"" data-command='undo' data-toggle=""tooltip"" data-placement=""top"" title=""Undo""><i class='fa fa-undo'></i></a>
                    <a href=""#"" data-command='redo' data-toggle=""tooltip"" data-placement=""top"" title=""Redo""><i class='fa fa-redo '></i></a>
                    <a href=""#"" data-command='removeFormat' data-toggle=""tooltip"" data-placement=""top"" title=""Clear format""><i class='fa fa-times '></i></a>
                    <div class=""fore-wrapper"">
                        <i class='fa fa-font' data-toggle=""tooltip"" data-placement=""top"" title=""text color"" style='color:#C96;'></i>
                        <div class=""fore-pal");
            WriteLiteral(@"ette"">
                        </div>
                    </div>
                    <div class=""back-wrapper"">
                        <i class='fa fa-font' data-toggle=""tooltip"" data-placement=""top"" title=""Background color"" style='background:#C96;'></i>
                        <div class=""back-palette"">
                        </div>
                    </div>
                    <a href=""#"" data-command='bold' data-toggle=""tooltip"" data-placement=""top"" title=""Bold""><i class='fa fa-bold'></i></a>
                    <a href=""#"" data-command='italic' data-toggle=""tooltip"" data-placement=""top"" title=""Italic""><i class='fa fa-italic'></i></a>
                    <a href=""#"" data-command='underline' data-toggle=""tooltip"" data-placement=""top"" title=""Underline""><i class='fa fa-underline'></i></a>
                    <a href=""#"" data-command='strikeThrough' data-toggle=""tooltip"" data-placement=""top"" title=""Stike through""><i class='fa fa-strikethrough'></i></a>
                    <a href=""#"" data-comman");
            WriteLiteral(@"d='justifyLeft' data-toggle=""tooltip"" data-placement=""top"" title=""Left align""><i class='fa fa-align-left'></i></a>
                    <a href=""#"" data-command='justifyCenter'><i class='fa fa-align-center' data-toggle=""tooltip"" data-placement=""top"" title=""Center align""></i></a>
                    <a href=""#"" data-command='justifyRight' data-toggle=""tooltip"" data-placement=""top"" title=""Right align""><i class='fa fa-align-right'></i></a>
                    <a href=""#"" data-command='justifyFull' data-toggle=""tooltip"" data-placement=""top"" title=""Justify""><i class='fa fa-align-justify'></i></a>
                    <a href=""#"" data-command='indent' data-toggle=""tooltip"" data-placement=""top"" title=""Indent""><i class='fa fa-indent'></i></a>
                    <a href=""#"" data-command='outdent' data-toggle=""tooltip"" data-placement=""top"" title=""Outdent""><i class='fa fa-outdent'></i></a>
                    <a href=""#"" data-command='insertUnorderedList' data-toggle=""tooltip"" data-placement=""top"" title=""Unordered ");
            WriteLiteral(@"list""><i class='fa fa-list-ul'></i></a>
                    <a href=""#"" data-command='insertOrderedList' data-toggle=""tooltip"" data-placement=""top"" title=""Ordered list""><i class='fa fa-list-ol'></i></a>
                    <a href=""#"" data-command='h1' data-toggle=""tooltip"" data-placement=""top"" title=""H1"">H1</a>
                    <a href=""#"" data-command='h2' data-toggle=""tooltip"" data-placement=""top"" title=""H2"">H2</a>
                    <a href=""#"" data-command='createlink' data-toggle=""tooltip"" data-placement=""top"" title=""Inser link""><i class='fa fa-link'></i></a>
                    <a href=""#"" data-command='unlink' data-toggle=""tooltip"" data-placement=""top"" title=""Unlink""><i class='fa fa-unlink'></i></a>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0150bb1a625bb63d9d57429ec380dd18eb099dcf9193", async() => {
                WriteLiteral("\r\n\r\n                      \r\n");
                WriteLiteral("                 \r\n\r\n                        <input  type=\"file\"\r\n                                   data-toggle=\"tooltip\" data-placement=\"top\" \r\n                                 title=\"Insert image\" name=\"img\"  />\r\n               \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <a href=""#"" data-command='insertimage' data-toggle=""tooltip"" data-placement=""top"" title=""Insert image""><i class='fa fa-image'></i></a>
                    <a href=""#"" data-command='p' data-toggle=""tooltip"" data-placement=""top"" title=""Paragraph"">P</a>
                    <a href=""#"" data-command='subscript' data-toggle=""tooltip"" data-placement=""top"" title=""Subscript""><i class='fa fa-subscript'></i></a>
                    <a href=""#"" data-command='superscript' data-toggle=""tooltip"" data-placement=""top"" title=""Superscript""><i class='fa fa-superscript'></i></a>
                </div>
                <div id='editor' class=""editorAria"" contenteditable>
                   
               
            </div>
        </div>
    </div>
</div>

</div>

<script>
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip()
    });

    $(document).ready(function () {
        var colorPalette = ['000000', 'FF9966', '6699FF', '99FF66', 'CC0000', '00CC00', '0000CC', '33333");
            WriteLiteral(@"3', '0066FF', 'FFFFFF'],
            forePalette = $('.fore-palette'),
            backPalette = $('.back-palette'),
            editor = $('.editor');

        for (var i = 0; i < colorPalette.length; i++) {
            forePalette.append('<a href=""#"" data-command=""foreColor"" data-value=""' + '#' + colorPalette[i] + '"" style=""background-color:' + '#' + colorPalette[i] + ';"" class=""palette-item""></a>');
            backPalette.append('<a href=""#"" data-command=""backColor"" data-value=""' + '#' + colorPalette[i] + '"" style=""background-color:' + '#' + colorPalette[i] + ';"" class=""palette-item""></a>');
        }
        $('.toolbar a').click(function (e) {
            e.preventDefault();
            var command = $(this).data('command');
            if (command == 'h1' || command == 'h2' || command == 'p') {
                document.execCommand('formatBlock', false, command);
            }
            url = 'Enter the link here: ';
            if (command == 'foreColor' || command == 'backColor') {
");
            WriteLiteral(@"                var color = $(this).data('value');
                document.execCommand($(this).data('command'), false, color);
                alert(color);
            }
            if (command == 'removeFormat') {
                document.execCommand('removeFormat', false, command);
            }
            if (command == 'createlink' || command == 'insertimage') {

                var file = document.forms['image']['img'].files[0];
                console.log(file)
                

                
              

                var link = ""https:\//localhost:44395/images/"" + file.name;
           
                console.log(link);
         

           /*     document.getElementById(""editor"").append(""<img src="" + link + "">"")*/
                document.execCommand($(this).data('command'), false,link);

            } else document.execCommand($(this).data('command'), false, url);
        });
        $('.editorAria img').click(function () {
            document.execCommand('en");
            WriteLiteral(@"ableObjectResizing', false);
        });
        $(""#getHTML"").click(function () {
            var editorId = $(this).attr('get-data');
            var html = $(""#"" + editorId).find('.editorAria').html();
            console.log(html);
        });
    });
</script>



<style>



    .file-input__input {
        width: 0.1px;
        height: 0.1px;
        opacity: 0;
        overflow: hidden;
        position: absolute;
        z-index: -1;
    }

    .file-input__label {
        cursor: pointer;
        display: inline-flex;
        align-items: center;
        border-radius: 4px;
        font-size: 14px;
        font-weight: 600;
        color: #fff;
        font-size: 14px;
        padding: 10px 12px;
        background-color: #4245a8;
        box-shadow: 0px 0px 2px rgba(0, 0, 0, 0.25);
    }

        .file-input__label svg {
            height: 16px;
            margin-right: 4px;
        }

    body {
        font-family: 'Open Sans';
    }

    a {
     ");
            WriteLiteral(@"   cursor: pointer;
    }

    .editor {
        position: relative;
    }

    .editorAria {
        height: 100%;
        min-height: 400px;
        border: 1px solid #ddd;
        overflow-y: auto;
        padding: 1em;
        margin-top: -2px;
        outline: none;
    }

    .toolbar {
        position: sticky;
        top: 0;
        left: 0;
        right: 0;
        background-color: #fff;
        border: 1px solid #ddd;
        padding: 10px;
    }

        .toolbar a,
        .fore-wrapper,
        .back-wrapper {
            border: 1px solid #ddd;
            background: #FFF;
            font-family: 'Candal';
            color: #000;
            padding: 5px;
            margin: 2px 0px;
            width: 35px;
            height: 35px;
            display: inline-block;
            text-align: center;
            text-decoration: none;
        }

            .toolbar a:hover,
            .fore-wrapper:hover,
            .back-wrapper:hover {
    ");
            WriteLiteral(@"            background: #0eacc6;
                color: #fff;
                border-color: #0eacc6;
            }

    a.palette-item {
        display: inline-block;
        height: 1.3em;
        width: 1.3em;
        margin: 0px 1px 1px;
        cursor: pointer;
    }

        a.palette-item[data-value=""#FFFFFF""] {
            border: 1px solid #ddd !important;
        }

        a.palette-item:hover {
            transform: scale(1.1);
        }

    .fore-wrapper,
    .back-wrapper {
        position: relative;
        cursor: auto;
    }

    .fore-palette,
    .back-palette {
        display: none;
        cursor: auto;
    }

    .fore-wrapper:hover .fore-palette,
    .back-wrapper:hover .back-palette {
        display: block;
    }

    .fore-wrapper .fore-palette,
    .back-wrapper .back-palette {
        position: relative;
        display: inline-block;
        cursor: auto;
        display: block;
        left: 0;
        top: calc(100% + 5px);
     ");
            WriteLiteral(@"   position: absolute;
        padding: 10px 5px;
        width: 160px;
        background: #FFF;
        box-shadow: 0 0 5px #CCC;
        display: none;
        text-align: left;
    }

        .fore-wrapper .fore-palette:after,
        .back-wrapper .back-palette:before {
            content: '';
            display: inline-block;
            position: absolute;
            top: -10px;
            left: 10px;
            width: 0;
            height: 0;
            border-left: 10px solid transparent;
            border-right: 10px solid transparent;
            border-bottom: 10px solid #fff;
        }

    .fore-palette a,
    .back-palette a {
        background: #FFF;
        margin-bottom: 2px;
        border: none;
    }

    .editor img {
        max-width: 100%;
        object-fit: cover;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProjet.Models.Articles> Html { get; private set; }
    }
}
#pragma warning restore 1591
