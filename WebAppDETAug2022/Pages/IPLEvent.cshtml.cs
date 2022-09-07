using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Tickets> Tickets { get; set; }
        public void OnGet()
        {
            Tickets = new List<Tickets>() {
            new Tickets { Category = "PlantinumPlus", Price = 5000, MaxLimit = 200000 },
            new Tickets { Category = "Plantinum", Price = 4000, MaxLimit = 300000 },
            new Tickets { Category = "Gold", Price = 3000, MaxLimit = 500000 },
            new Tickets { Category = "Silver", Price = 2000, MaxLimit = 500000 },
            new Tickets { Category = "General", Price = 800, MaxLimit = 100000 },
        };
        }
    }
}
