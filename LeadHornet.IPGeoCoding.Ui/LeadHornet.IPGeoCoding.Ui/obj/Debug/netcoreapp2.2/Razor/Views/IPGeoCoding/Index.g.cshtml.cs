#pragma checksum "C:\Users\maureen\Desktop\Exam\LeadHornet.IPGeoCoding.Ui\LeadHornet.IPGeoCoding.Ui\Views\IPGeoCoding\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf59f492fcd2c0d67f3d000cc16de096d5fc5fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IPGeoCoding_Index), @"mvc.1.0.view", @"/Views/IPGeoCoding/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IPGeoCoding/Index.cshtml", typeof(AspNetCore.Views_IPGeoCoding_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf59f492fcd2c0d67f3d000cc16de096d5fc5fc4", @"/Views/IPGeoCoding/Index.cshtml")]
    public class Views_IPGeoCoding_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block mx-auto mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ezgif.com-webp-to-png.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ip-geo-coding-index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\maureen\Desktop\Exam\LeadHornet.IPGeoCoding.Ui\LeadHornet.IPGeoCoding.Ui\Views\IPGeoCoding\Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(56, 92, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"py-5 text-center\">\r\n        ");
            EndContext();
            BeginContext(148, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf59f492fcd2c0d67f3d000cc16de096d5fc5fc44326", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 2017, true);
            WriteLiteral(@"
        <h2>Programming Task</h2>
        <p class=""lead"">This is a simple demonstration for my programming task.</p>
        <p class=""lead"">Your IP is <span class=""ip-address-container""></span></p>
    </div>

    <div class=""row"">
        <div class=""col-md-12 order-md-1"">
            <h4 class=""mb-3"">Customer Information</h4>
            <form class=""needs-validation"" novalidate="""">
                <div class=""row"">
                    <div class=""col-md-6 mb-3"">
                        <label for=""firstName"">Country Name</label>
                        <input type=""text"" class=""form-control country-name-textbox"" id=""countryNameTextBox"" placeholder=""Please enter your location"" value="""" required="""">
                        <div class=""invalid-feedback"">
                            Valid first name is required.
                        </div>
                        <button class=""btn btn-primary btn-lg btn-block col-md-4 submit-weather-button"" type=""button"">Get Weather Updates</button>
  ");
            WriteLiteral(@"                  </div>
                    <div class=""col-md-6 mb-3 data-weather-container"">
                        
                    </div>
                </div>
                <hr class=""mb-4"">
                
            </form>
        </div>
    </div>
</div>


<div class=""tempate-card d-none"">
    <div class=""card border-dark mb-3"">
        <div class=""card-header""><img src=""{cloud_icon}"" width=""50"" height=""50"">{cloud_name}</div>
        <div class=""card-body text-dark"">
            <p class=""card-text"">Location : {city_name} {country} ({long},{lat})</p>
            <p class=""card-text"">Temperature : {temperature}</p>
            <p class=""card-text"">Humidity : {humidity}</p>
            <p class=""card-text"">Pressure : {pressure}</p>
            <p class=""card-text"">Last Update : {lastUpdate}</p>
        </div>
        <div class=""card-footer"">
            <small class=""text-muted"">{header}</small>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2259, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2265, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf59f492fcd2c0d67f3d000cc16de096d5fc5fc47878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2316, 1501, true);
                WriteLiteral(@"


    <script type=""text/javascript"">

        var currentIpInfo = null;

        let constants = {
            elements: {
                ipAddress: '.ip-address-container',
                submitWeatherButton: '.submit-weather-button',
                countryNameTextBox: '.country-name-textbox',
                templateCard: '.tempate-card',
                weatherContainer: '.data-weather-container'
            },
            url: {
                getClientWeather: '/IPGeoCoding/GetClientWeather'
            }
        }

        $(document).ready(function () {

            ipGeoCodingModule.getUserIpAddress((data) => {
                console.log(data)
                currentIpInfo = data;
                $(constants.elements.ipAddress).text(data.ip)

            })


            $(constants.elements.submitWeatherButton).click(function (e) {
                e.preventDefault();

                if ($(constants.elements.countryNameTextBox).val().length < 1) {
            ");
                WriteLiteral(@"        toastr.error('Please enter your location.', 'Error!')
                    return;
                }

                doGetCountryInfo();

            })
        })

        function getCardData(data, header) {
            var template = $(constants.elements.templateCard).html();

            template = template.replace('{header}', header)
            template = template.replace('{cloud_icon}', 'http://openweathermap.org/img/wn/' + data.weather.icon + '");
                EndContext();
                BeginContext(3818, 1785, true);
                WriteLiteral(@"@2x.png')
            template = template.replace('{cloud_name}', data.weather.value)
            template = template.replace('{temperature}', data.temperature.value + data.temperature.unit)
            template = template.replace('{humidity}', data.humidity.value + data.humidity.unit)
            template = template.replace('{pressure}', data.pressure.value + data.pressure.unit)
            template = template.replace('{lastUpdate}', data.lastUpdate.value)
            template = template.replace('{city_name}', data.city.name)
            template = template.replace('{country}', data.city.country)
            template = template.replace('{long}', data.city.coordinates.longitude)
            template = template.replace('{lat}', data.city.coordinates.latitude)

            return template
        }

        function doGetCountryInfo() {
            var jqxhr = $.post(constants.url.getClientWeather, { IPAddress: currentIpInfo.ip, CountryName: $(constants.elements.countryNameTextBox).val() }, funct");
                WriteLiteral(@"ion (data) {
                console.log(data)

                if (data) {

                    var htmlData = '';

                    if (data.currentWeather_CountryName) {
                        htmlData = (getCardData(data.currentWeather_CountryName, ""Location Base Information""))
                    }

                    if (data.currentWeather_IP) {
                        htmlData = htmlData + (getCardData(data.currentWeather_IP, ""IP Base Information""))
                    }

                    $(constants.elements.weatherContainer).html(htmlData)

                }


            }).done(function () {
            }).fail(function () {
            }).always(function () {
            });

        }


    </script>
");
                EndContext();
            }
            );
            BeginContext(5606, 2, true);
            WriteLiteral("\r\n");
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
