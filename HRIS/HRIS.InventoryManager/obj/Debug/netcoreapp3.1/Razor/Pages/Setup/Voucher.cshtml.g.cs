#pragma checksum "C:\Users\saheed.alabi\Desktop\HRIS\HRIS\HRIS.InventoryManager\Pages\Setup\Voucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6f9092f504e4ac0f15a094148f545973e07445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRIS.InventoryManager.Pages.Setup.Pages_Setup_Voucher), @"mvc.1.0.razor-page", @"/Pages/Setup/Voucher.cshtml")]
namespace HRIS.InventoryManager.Pages.Setup
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
#line 1 "C:\Users\saheed.alabi\Desktop\HRIS\HRIS\HRIS.InventoryManager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saheed.alabi\Desktop\HRIS\HRIS\HRIS.InventoryManager\Pages\_ViewImports.cshtml"
using HRIS.InventoryManager;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6f9092f504e4ac0f15a094148f545973e07445", @"/Pages/Setup/Voucher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b165b6c75c1454d86b13ae1999c8125338d527", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Setup_Voucher : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Voucher Management</h5>
                </div>
                <div class=""ibox-content"">
                    <button class=""btn btn-primary btn-sm"" type=""button"" data-toggle=""modal"" data-target=""#VoucherModal""><i class=""fa fa-plus""></i>&nbsp;Add New</button>
                    <br /><br />
                    <div class=""table-responsive"">

                        <div id=""VoucherContainer""></div>

                        <div id=""VoucherModal"" class=""modal fade"" aria-hidden=""true"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    <div class=""modal-header""><h3 class=""m-t-none m-b"">Add Voucher</h3></div>
                                    <div class=""modal-body"">
  ");
            WriteLiteral("                                      <div class=\"row\">\r\n                                            <div class=\"col-sm-12 \">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6f9092f504e4ac0f15a094148f545973e074454932", async() => {
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <label>Voucher Name</label>
                                                        <input placeholder=""Enter your Voucher Name"" class=""form-control"" id=""VoucherAdd"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Voucher Amount</label>
                                                        <input placeholder=""Enter your Voucher Amount"" class=""form-control"" id=""VoucherAmount"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Expire Date</label>
                                                        <input type=""date"" class=""form-control"" id=""VoucherExpireDate"">
      ");
                WriteLiteral("                                              </div>\r\n                                                ");
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
                                            </div>

                                        </div>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button class=""btn btn-sm btn-primary pull-right m-t-n-xs"" type=""submit"" id=""btn-AddVoucher""><strong>Submit</strong></button>
                                    </div>
                                </div>

                            </div>
                        </div>

                        <div id=""EditVoucherModal"" class=""modal fade"" aria-hidden=""true"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    <div class=""modal-header""><h3 class=""m-t-none m-b"">Edit Voucher</h3></div>
                                    <div class=""modal-body"">
                                        <div class=""row"">

                                            <d");
            WriteLiteral("iv class=\"col-sm-12 \">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6f9092f504e4ac0f15a094148f545973e074458584", async() => {
                WriteLiteral(@"
                                                    <input type=""hidden"" id=""VoucherId"" />
                                                    <div class=""form-group"">
                                                        <label>Voucher Name</label>
                                                        <input placeholder=""Enter your Voucher Name"" class=""form-control"" id=""VoucherEdit"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Voucher Amount</label>
                                                        <input placeholder=""Enter your Voucher Amount"" class=""form-control"" id=""VoucherAmountEdit"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Expire Date</label>
                              ");
                WriteLiteral("                          <input type=\"date\" class=\"form-control\" id=\"VoucherExpireEdit\">\r\n                                                    </div>\r\n                                                ");
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
                                            </div>

                                        </div>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button class=""btn btn-sm btn-primary pull-right m-t-n-xs"" type=""submit"" id=""btn-EditVoucher""><strong>Submit</strong></button>
                                    </div>
                                </div>

                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
    <div id=""cover-spin""></div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public HRIS.InventoryManager.Services.MenuSetup Menus { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRIS.InventoryManager.Pages.Setup.VoucherModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRIS.InventoryManager.Pages.Setup.VoucherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRIS.InventoryManager.Pages.Setup.VoucherModel>)PageContext?.ViewData;
        public HRIS.InventoryManager.Pages.Setup.VoucherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591