#pragma checksum "/Users/nurlanmammadli/Projects/FlowerFrontToBack/FlowerFrontToBack/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4bec1196466678debd65ebcbc6316100d549ff0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bec1196466678debd65ebcbc6316100d549ff0", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/homepage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section id=""introduce"" class=""col-lg-12 col-sm-12 col-12"">
    <div class=""images"">

        <i class=""fas fa-chevron-right clickright""></i>
        <i class=""fas fa-chevron-left clickleft""></i>
        <img id=""interval"" src=""./assets/images/h3-slider-background.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 272, "\"", 278, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""flowersInfo"">
        <div class=""title"">
            <div class=""st"">
                <span>Send</span><span>flowers</span><span>like</span>
            </div>
            <div class=""nd"">
                <span>you mean it.</span>
            </div>
        </div>
        <div class=""desc"">
            <p>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Mollitia rerum beatae totam sunt
                excepturi voluptatum maiores non ex et officia?
            </p>
        </div>
        <div class=""sign"">
            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h2-sign-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 949, "\"", 955, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
</section>
<section id=""products"">
    <div class=""container"">
        <div class=""row"">
            <div class=""filters-filterbtn d-flex justify-content-between"">
                <div class=""mdfilters"">
                    <span id=""mdcategory"" style=""cursor: pointer;
                            font-size: 12px;
                            letter-spacing: 2px;
                            transition: 0.2s;"">CATEGORY</span><i style=""font-size: 12px;""
                                                                 class=""fas fa-chevron-down""></i>
                    <div class=""mdcategories"" style=""max-width:min-content;"">
                        <span id=""firstfilter"" data-id=""all"">ALL</span>
                        <span data-id=""popular"">POPULAR</span>
                        <span data-id=""winter"">WINTER</span>
                        <span data-id=""various"">VARIOUS</span>
                        <span data-id=""exotic"">EXOTIC</span>
                        <span data-id=""greens""");
            WriteLiteral(@">GREENS</span>
                        <span data-id=""cactuses"">CACTUSES</span>

                    </div>
                </div>
                <div class=""filters col-lg-10  "">
                    <span id=""firstfilter"" data-id=""all"">ALL</span>
                    <span data-id=""popular"" style=""margin-left: 20px;"">POPULAR</span>
                    <span data-id=""winter"" style=""margin-left: 20px;"">WINTER</span>
                    <span data-id=""various"" style=""margin-left: 20px;"">VARIOUS</span>
                    <span data-id=""exotic"" style=""margin-left: 20px;"">EXOTIC</span>
                    <span data-id=""greens"" style=""margin-left: 20px;"">GREENS</span>
                    <span data-id=""cactuses"" style=""margin-left: 20px;"">CACTUSES</span>

                </div>
                <div class=""filterbtn col-lg-2 d-flex justify-content-end"">
                    <span id=""mdfilterbtn"">FILTER</span><span><i class=""fas fa-chevron-down""></i></span>
                    <div class=""mdfilterLists"" style=""max-");
            WriteLiteral("width:max-content;max-height: max-content;\">\n                        <div class=\"sortby\">\n                            <h4>Sort By</h4>\n                            <ul>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3210, "\"", 3217, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3274, "\"", 3281, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3341, "\"", 3348, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3405, "\"", 3412, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3483, "\"", 3490, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                            </ul>
                        </div>
                        <div class=""pricerange"">
                            <h4>Price range</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3757, "\"", 3764, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3817, "\"", 3824, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3882, "\"", 3889, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3948, "\"", 3955, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4014, "\"", 4021, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4080, "\"", 4087, 0);
            EndWriteAttribute();
            WriteLiteral(@">$40+</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""filterLists"">
                        <div class=""sortby"">
                            <h4>Sort By</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4402, "\"", 4409, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4466, "\"", 4473, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4533, "\"", 4540, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4597, "\"", 4604, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4675, "\"", 4682, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                            </ul>
                        </div>
                        <div class=""pricerange"">
                            <h4>Price range</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4949, "\"", 4956, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5009, "\"", 5016, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5074, "\"", 5081, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5140, "\"", 5147, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5206, "\"", 5213, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5272, "\"", 5279, 0);
            EndWriteAttribute();
            WriteLiteral(@">$40+</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div data-aos-offset=""100""
                 class=""product col-lg-3 col-md-6 popular winter all"">
                <div class=""productImage"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-14-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 5692, "\"", 5723, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                </div>
                <div class=""productTitle"">
                    <p>MAJESTY PALM</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""1"">Add to cart</span><span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>

            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular winter various all"">
                <div class=""productImage"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-13-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 6369, "\"", 6400, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""productTitle"">
                    <p>FOXGLOW FLOWER</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""2"">Add to cart</span> <span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular winter all"">
                <div class=""productImage"">
                    <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-10-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 7040, "\"", 7071, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge badge-dark bg-dark position-absolute""
                          style="" top:3%;left: 8%;transform: scale(1.3);"">SOLD</span>
                </div>
                <div class=""productTitle"">
                    <p>SWEET ALYYSUM</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""3"">Add to cart</span> <span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular all"">
                <div class=""productImage"">
                    <img src=""   https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-11-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 7868, "\"", 7899, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""productTitle"">
                    <p>SPRING SNOWFLAKE</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""4"">Add to cart</span> <span>$</span><span>170</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular various all"">
                <div class=""productImage"">
                    <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-12-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 8542, "\"", 8573, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge text-dark bg-light position-absolute""
                          style=""top:3%;left: 8%; transform: scale(1.3);"">SALE</span>
                </div>
                <div class=""productTitle"">
                    <p>SCARLET SAGE</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""5"">Add to cart</span> <span style=""text-decoration: line-through;"">$259</span>
                    <span>$</span><span>170</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 various cactuses all"">
                <div class=""productImage"">
                    <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-9-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 9452, "\"", 9483, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""productTitle"">
                    <p>ROCK SOAPWORT</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""6"">Add to cart</span> <span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 greens all"">
                <div class=""productImage"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-8-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 10112, "\"", 10143, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""productTitle"">
                    <p>SUMMER SAVORY</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""7"">Add to cart</span> <span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>

            <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 exotic all"">
                <div class=""productImage"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-7-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 10772, "\"", 10803, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""productTitle"">
                    <p>WILD ROSES</p>
                </div>
                <div class=""productPrice"">
                    <span class=""addToCardBtn"" data-id=""8"">Add to cart</span> <span>$</span><span>259</span>
                </div>
                <div class=""addToCart"">

                </div>
            </div>
        </div>
    </div>
</section>

<section id=""valentine"">
    <div class=""container"">
        <div class=""row"">
            <div data-aos=""zoom-in-up"" data-aos-duration=""1000"" class=""valentineVideo col-lg-6"">
                <div class=""videoImage "">
                    <img style=""width: 100%;""
                         src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 11604, "\"", 11635, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-play""></i>
                </div>
            </div>
            <div class=""valentineTexts col-lg-6"">
                <div class=""title"">
                    <h1>Surprise Your <span style=""color: red;"">Valentine!</span></h1>
                    <h1>Let us arrange a smile.</h1>
                </div>
                <div class=""desc"">
                    <p>
                        Where flowers are our inspiration to create lasting memories. Whatever the occasion...

                    </p>
                </div>
                <div class=""icondescs"">
                    <div class=""first"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 12372, "\"", 12407, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>
                            Hand picked just for you.
                        </span>
                    </div>
                    <div class=""sec"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 12684, "\"", 12719, 0);
            EndWriteAttribute();
            WriteLiteral("><span>Unique flower arrangements</span>\n                    </div>\n                    <div class=\"third\">\n\n                        <img src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png\"");
            BeginWriteAttribute("alt", "\n                             alt=\"", 12946, "\"", 12981, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>Best way to say you care.</span>
                    </div>


                </div>
            </div>
        </div>
    </div>

</section>

<section id=""flowerexperts"">
    <div class=""container"">
        <div class=""info col-lg-12"">
            <div class=""title"">
                <h1>Flower Experts</h1>
            </div>
            <div class=""desc"">
                <p>
                    Flower Experts
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                    smile for you.
                </p>
            </div>
        </div>
        <div class=""row"">
            <div class=""experts"">
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-1.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 13882, "\"", 13917, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>CRYSTAL BROOKS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-team-img-2.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 14404, "\"", 14439, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>SHIRLEY HARRIS</p>
                    </div>
                    <div class=""job"">
                        <p>Manager</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 14926, "\"", 14961, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>
                            BEVERLY CLARK
                        </p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 15501, "\"", 15536, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>AMANDA WATKINS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""subscribe"">

    <div class=""parallax-window"" data-parallax=""scroll""
         data-image-src=""  https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-background-img.jpg"">

        <div class=""container"">
            <div class=""title col-lg-12 col-12 col-md-12"">
                <h1>Join The Colorful Bunch!</h1>
            </div>
            <div class=""subs col-lg-12 col-12 col-md-12"">
                <input type=""email"">
                <button>SUBSCRIBE</button>
            </div>

        </div>
    </div>



</section>

<section id=""blogs"">
    <div class=""container"">
        <div class=""info col-lg-12"">
            <div class=""title"">
                <h1>Form");
            WriteLiteral(@" our blog</h1>
            </div>
            <div class=""desc"">
                <p>
                    Flower Experts
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                    smile for you.
                </p>
            </div>
        </div>
        <div class=""row"">
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/blog-feature-img-1.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 17101, "\"", 17132, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Flower Power</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-3.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 17705, "\"", 17736, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Local florists</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-4.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 18311, "\"", 18342, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Flower beauty</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
        </div>
    </div>


</section>

<section id=""slideimages"">
    <div class=""container"">
        <div class=""owl-carousel owl-theme"">
            <div class=""item"">
                <div class=""expert col-md-6 col-12 col-lg-7"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 19112, "\"", 19147, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""title"">
                        <h3>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos magnam deleniti neque?
                        </h3>
                    </div>
                    <div class=""name"">
                        <p>AMANDA WATKINS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""expert col-md-6 col-12 col-lg-7"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\n                             alt=\"", 19923, "\"", 19958, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""title"">
                        <h3>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima dolorum obcaecati
                            ratione.
                        </h3>
                    </div>
                    <div class=""name"">
                        <p>
                            BEVERLY CLARK
                        </p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4bec1196466678debd65ebcbc6316100d549ff030027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
