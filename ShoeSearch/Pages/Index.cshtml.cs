using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ShoeSearch.Api;
using ShoeSearch.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSearch.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public SearchModel Search { get; set; }
        public FinnProcessor Finn { get; set; } = new FinnProcessor();
        public List<Item> items { get; set; } = new List<Item>();

        public int pageNr { get; set; }

        public async void OnGetAsync()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {
                pageNr = 1;
                FinnModel itemModel = await Finn.SearchProducts(Search.name, pageNr);
                items = itemModel.items;
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}
