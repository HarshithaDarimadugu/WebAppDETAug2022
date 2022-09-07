using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class helowebModel : PageModel
    {
        public string Message { get; set; }
        public string Discount { get; set; }
        public void OnGet()
        {
            Message = "ASP.NET is Rocking Today!!";
            Discount = "is 5%";
        } }
}
