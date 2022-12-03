using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrnekUygulama.Extensions
{
    public static class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value = "",string placeHolder = "")
        =>
            htmlHelper.TextBox(name, value, new
            {
                style = "background-color:green;color:white;font-size:50px;",
                @class = "form-input",
                a = "a",
                b = "b",
                placeHolder = placeHolder
            });

    }
}
