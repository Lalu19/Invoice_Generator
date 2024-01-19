#pragma checksum "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e2b18e1512c22f4c9b1761b9b9dc99899747f68109cfc4fb2d075710e8200e14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_InvoiceCreate), @"mvc.1.0.view", @"/Views/Invoice/InvoiceCreate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e2b18e1512c22f4c9b1761b9b9dc99899747f68109cfc4fb2d075710e8200e14", @"/Views/Invoice/InvoiceCreate.cshtml")]
    #nullable restore
    public class Views_Invoice_InvoiceCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
  
    ViewBag.Title = "Invoice";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    /* Style for the cancel button */
    #cancelButton {
        position: absolute;
        top: 10px;
        right: 10px;
        background-color: red;
        color: white;
        border: none;
        cursor: pointer;
        display: none;
        width: 25px; /* Adjust the width to your preferred size */
        height: 25px; /* Adjust the height to your preferred size */
        font-size: 14px; /* Adjust the font size to your preferred size */
        line-height: 20px; /* Adjust the line height to vertically center the icon */
        text-align: center; /* Center the X icon horizontally */
        border-radius: 50%;
    }
</style>


<div class=""row"" id=""InvoicePage"">
    <div class=""col-md"">
        <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
            <div class=""card overflow-hidden"">

                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-lg-3"">

                     ");
            WriteLiteral("       <div class=\"card shadow\">\r\n\r\n                                <div style=\"position: relative;\">\r\n                                    <img id=\"selectedImage\"");
            BeginWriteAttribute("src", " src=\"", 1417, "\"", 1423, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""Select Image"" style=""max-width: 100%; max-height:100px;"">
                                    <!-- Add a cancel button -->
                                    <button id=""cancelButton"" onclick=""deleteImage()"">&#10006;</button>
                                </div>
                                <div class=""card-body"">
                                    <div class=""custom-file mt-0"">
                                        <input type=""file"" class=""custom-file-input"" tabindex=""11"" id=""companylogo"" name=""pp"" required onchange=""displayImage()"">
                                        <label class=""custom-file-label"" for=""proPic"">Choose file&nbsp;</label>
                                    </div>
                                </div>

                            </div>
                        </div>

                        <div class=""col-lg-3 ""></div>
                        <div class=""col-lg-4 ""></div>


                        <div class=""col-lg-2 "">

                          ");
            WriteLiteral("  <div class=\"form-group\">\r\n                                <h3><label class=\"form-label\">INVOICE</label></h3>\r\n");
            WriteLiteral(@"                            </div>

                        </div>


                    </div>


                    <div class=""row"">

                        <div class=""col-md-4"">

                            <div class=""form-group"">
                                <label class=""form-label"">Bill From</label>
                                <textarea class=""form-control"" id=""BillFrom"" placeholder=""Who is this invoice from? (required)"" tabindex=""15""");
            BeginWriteAttribute("required", " required=\"", 3190, "\"", 3201, 0);
            EndWriteAttribute();
            BeginWriteAttribute("expanding-textarea", " expanding-textarea=\"", 3202, "\"", 3223, 0);
            EndWriteAttribute();
            WriteLiteral(@" resize:none;""></textarea>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Bill To</label>
                                <textarea class=""form-control"" id=""BillTo"" placeholder=""Who is this invoice to? (required)"" tabindex=""15""");
            BeginWriteAttribute("required", " required=\"", 3554, "\"", 3565, 0);
            EndWriteAttribute();
            BeginWriteAttribute("expanding-textarea", " expanding-textarea=\"", 3566, "\"", 3587, 0);
            EndWriteAttribute();
            WriteLiteral(@" resize:none;""></textarea>
                            </div>

                        </div>

                        <div class=""col-md-3"">
                        </div>

                        <div class=""col-md-2"">

                            <div class=""form-group"">
                                <label class=""form-label"">Date</label>
                                <input type=""date"" class=""form-control"" name=""example-text-input""");
            BeginWriteAttribute("tabindex", " tabindex=\"", 4043, "\"", 4054, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""InvoiceDate"">
                            </div>

                            <div class=""form-group"">
                                <label class=""form-label"">Payment Terms</label>
                                <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Payment Terms""");
            BeginWriteAttribute("tabindex", " tabindex=\"", 4373, "\"", 4384, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""PaymentTerm"">
                            </div>

                        </div>

                        <div class=""col-md-2"">

                            <div class=""form-group"">
                                <label class=""form-label"">Due Date</label>
                                <input type=""date"" class=""form-control"" name=""example-text-input""");
            BeginWriteAttribute("tabindex", " tabindex=\"", 4754, "\"", 4765, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""Duedate"">
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">PO Number</label>
                                <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""PO Number""");
            BeginWriteAttribute("tabindex", " tabindex=\"", 5070, "\"", 5081, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""PoNumber"">
                            </div>

                        </div>

                    </div>

                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""table-responsive"">
                                <table id=""InvoiceItemtable"" class="" display nowrap table table-striped table-bordered"" width=""100%"">
                                    <thead>
                                        <tr>
                                            <th>Items Details</th>
                                            <th>Quantity</th>
                                            <th>Rate</th>
                                            <th>Total Amount</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody id=""inputtext"">
                                    </tbody>
              ");
            WriteLiteral(@"                  </table>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">

                        <div class=""col-lg-3"">
                            <button type=""button"" id=""ADDButton"" class=""btn btn-radius btn-secondary addinput""");
            BeginWriteAttribute("style", " style=\"", 6431, "\"", 6439, 0);
            EndWriteAttribute();
            WriteLiteral(@">+ Add</button>
                        </div>

                    </div>



                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7"">
                        </div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Subtotal"">Subtotal :</label>
                        </div>
                        <div class=""col-lg-2"">
                            <input class=""form-control"" id=""Subtotal"" type=""text"" placeholder=""₹0"" />
                        </div>
                    </div>

                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7""></div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Discounts"">Discounts % :</label>
                        </div>
                        <div class=""col-lg-2 mt-1"">
                            <input class=""form-control"" id=""Discounts"" type=""text"" placeholder=""%"" />
");
            WriteLiteral(@"                        </div>
                    </div>

                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7""></div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Vat"">VAT % :</label>
                        </div>
                        <div class=""col-lg-2 mt-1"">
                            <input class=""form-control"" id=""VAT"" type=""text"" placeholder=""%"" />
                        </div>
                    </div>


                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7""></div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Grand"">Grand Total :</label>
                        </div>
                        <div class=""col-lg-2 mt-1"">
                            <input class=""form-control"" id=""GrandTotal"" type=""text"" placeholder=""₹0"" />
                        </div>
                    </div>");
            WriteLiteral(@"

                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7""></div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Grand"">Amount Paid :</label>
                        </div>
                        <div class=""col-lg-2 mt-1"">
                            <input class=""form-control"" id=""AmountPaid"" type=""text"" placeholder=""₹0"" />
                        </div>
                    </div>

                    <div class=""row subtotalprice"">
                        <div class=""col-lg-7""></div>
                        <div class=""col-lg-3"">
                            <label class=""form-label Grand"">Balance Due :</label>
                        </div>
                        <div class=""col-lg-2 mt-1"">
                            <input class=""form-control"" id=""DueBalance"" type=""text"" placeholder=""₹0"" />
                        </div>
                    </div>


                    <div class=""row"">");
            WriteLiteral(@"
                        <div class=""col-lg-5"">
                            <label class=""form-label"">Note :</label>
                            <textarea class=""form-control"" id=""Note"" placeholder=""Notes - any relevant information not already covered""></textarea>
                        </div>
                        <div class=""col-lg-5"">
                            <label class=""form-label"">Terms :</label>
                            <textarea class=""form-control"" id=""Terms"" placeholder=""Terms and conditions - late fees, payment methods, delivery schedule""></textarea>
                        </div>
                        <div class=""col-lg-2 mt-5"">
                            <button type=""button"" id=""DownloadInvoice"" class=""btn btn-primary"">Download Invoice</button>
                        </div>
                    </div>

                </div>
            </div>
        </form>
    </div>

</div>


<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"


    <script>
        function displayImage() {
            const fileInput = document.getElementById('companylogo');
            const selectedImage = document.getElementById('selectedImage');
            const cancelButton = document.getElementById('cancelButton');

            if (fileInput.files && fileInput.files[0]) {
                const reader = new FileReader();

                reader.onload = function (e) {
                    selectedImage.src = e.target.result;
                    cancelButton.style.display = 'block'; // Show the cancel button
                };

                reader.readAsDataURL(fileInput.files[0]);
            }
        }

        function deleteImage() {
            const selectedImage = document.getElementById('selectedImage');
            const cancelButton = document.getElementById('cancelButton');
            const fileInput = document.getElementById('companylogo');

            selectedImage.src = ''; // Clear the image
            cancelB");
                WriteLiteral(@"utton.style.display = 'none'; // Hide the cancel button
            fileInput.value = ''; // Clear the file input
        }
    </script>

    <script>
        $(function () {
            function calculateResult() {
                var totalSum = 0;
                var discountPercentage = parseFloat($(""#Discounts"").val()) || 0;
                var vatPercentage = parseFloat($(""#VAT"").val()) || 0;

                $("".totalamount"").each(function () {
                    var row = $(this).closest(""tr"");
                    var quantity = parseFloat(row.find("".quantity"").val()) || 0;
                    var amount = parseFloat(row.find("".amount-input"").val()) || 0;
                    var totalAmount = quantity * amount;
                    row.find("".totalamount"").val(totalAmount.toFixed(2));
                    totalSum += totalAmount;
                });

                var subtotal = totalSum;
                $(""#Subtotal"").val(subtotal.toFixed(2));

                var discount = ");
                WriteLiteral(@"(subtotal * discountPercentage) / 100;
                var subtotalAfterDiscount = subtotal - discount;
                $(""#GrandTotal"").val(subtotalAfterDiscount.toFixed(2));

                var vatAmount = (subtotalAfterDiscount * vatPercentage) / 100;
                var grandTotal = subtotalAfterDiscount + vatAmount;
                $(""#GrandTotal"").val(grandTotal.toFixed(2));

                var amountPaid = parseFloat($(""#AmountPaid"").val()) || 0;
                var dueBalance = grandTotal - amountPaid;
                $(""#DueBalance"").val(dueBalance.toFixed(2));
            }

            $(""#ADDButton"").click(function (e) {
                var newRow = $(""<tr><td><input class='form-control item-name' type='text' placeholder='Item Name'/></td><td><input class='form-control quantity' type='text' placeholder='Quantity'/></td><td><input class='form-control amount-input' placeholder='₹0.00' type='text'/></td><td><input class='form-control totalamount' type='text' placeholder='₹0.00' readon");
                WriteLiteral(@"ly/></td><td><button type='button' class='btn btn-pill btn-danger delRowBtn'><i class='fe fe-trash'></i>Delete</button></td></tr>"");

                $('#inputtext').append(newRow);
                calculateResult();
            });

            $(document).on(""click"", "".delRowBtn"", function () {
                $(this).closest(""tr"").remove();
                calculateResult();
            });

            $(document).on(""input"", "".amount-input, .quantity"", function () {
                calculateResult();
            });

            $(document).on(""input"", ""#Discounts, #VAT, #AmountPaid"", function () {
                calculateResult();
            });


            calculateResult(); //Calculate on page load
        });
    </script>

    <script>
        $(function () {


            $(""#DownloadInvoice"").click(function (e) {

                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                }
               ");
                WriteLiteral(@" else {
                    imgPath = '';
                    var totalFiles = document.getElementById('companylogo').files.length;
                    if (totalFiles > 0) {
                        uploadFile();
                    }

                    var itemDeatils = [];
                    $.each($(""#InvoiceItemtable tbody tr""), function () {
                        var $irow = $(this),
                            rowObj = {};
                        var k = 0

                        var ItemDetails;
                        var Quantity;
                        var Rate;
                        var TotalAmount;


                        $.each($(""td"", $irow), function () {
                            var $col = $(this);

                            if (k == 0) {
                                ItemDetails = $col.find(""input"").val();
                            }
                            if (k == 1) {
                                Quantity = $col.find(""input"").val();
    ");
                WriteLiteral(@"                        }
                            if (k == 2) {
                                Rate = $col.find(""input"").val();
                            }
                            if (k == 3) {
                                TotalAmount = $col.find(""input"").val();
                            }


                            k = k + 1
                        });

                        var a = {
                            ""itemDetails"": ItemDetails,
                            ""quantity"": Quantity,
                            ""rate"": Rate,
                            ""totalAmount"": TotalAmount,

                        }
                        itemDeatils.push(a)
                    });

                    var model = {
                        invoiceLogo: imgPath,
                        billFrom: $.trim($(""#BillFrom"").val()),
                        billTo: $.trim($(""#BillTo"").val()),
                        invoiceDate: $.trim($(""#InvoiceDate"").val()) == '' ? null : ");
                WriteLiteral(@"$.trim($(""#InvoiceDate"").val().replace(/\//g, '-')),
                        dueDate: $.trim($(""#Duedate"").val()) == '' ? null : $.trim($(""#Duedate"").val().replace(/\//g, '-')),
                        paymentTerm: $.trim($(""#PaymentTerm"").val()),
                        poNumber: $.trim($(""#PoNumber"").val()),
                        subTotal: parseFloat($(""#Subtotal"").val()),
                        discounts: parseFloat($(""#Discounts"").val()),
                        vat: parseFloat($(""#VAT"").val()),
                        grandTotal: parseFloat($(""#GrandTotal"").val()),
                        amountPaid: parseFloat($(""#AmountPaid"").val()),
                        balanceDue: parseFloat($(""#DueBalance"").val()),
                        note: $.trim($(""#Note"").val()),
                        terms: $.trim($(""#Terms"").val()),
                        subInvoices: itemDeatils,
                        createdBy: ");
#nullable restore
#line 404 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                   \r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 409 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Invoice/InvoiceCreate\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 413 "D:\New Proj\EOrderBook\AdminClient\Views\Invoice\InvoiceCreate.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            console.log(data);
                            if (xhr.status === 200) {
                                Swal.fire({
                                    html: true,
                                    icon: ""success"",
                                    title: ""Invioce Sent"",
                                    text: ""Successfully Sended!"",
                                    type: ""success""
                                }).then(function () {
                                    location.reload();
                                });
                            } else if (data.status === ""duplicate"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else if (data.status === ""error"") {
                                sweetAlert(""Validation Alert!"", data.");
                WriteLiteral(@"responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert...!"", ""Something unexpected...!"", ""warning"");
                            }
                        },
                        error: function (data) {
                            if (data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            } else if (data.status == 400) {
                                sweetAlert(""Validation Alert!"", ""Please check input data...!"", ""warning"");
                            }
                        }
                    });
                }
            });


            function uploadFile() {
                var totalFiles = document.getElementById('companylogo').files.length;
                if (totalFiles > 0) {
      ");
                WriteLiteral(@"              var formData = new FormData();
                    var files = document.getElementById('companylogo').files;
                    formData.append(""file"", files[0]);
                    $.ajax(
                        {
                            url: ""/Upload/ImgUpload"",
                            data: formData,
                            processData: false,
                            contentType: false,
                            async: false,
                            type: ""POST"",
                            success: function (data) {
                                imgPath = data;

                            },
                            error: function (data) {
                                window.location.replace('/Message/SessionExpire');
                            }
                        }
                    );
                }

            }
        });
    </script>


");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
