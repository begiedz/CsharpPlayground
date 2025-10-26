using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        public IList<Pizza> PizzaList { get; set; } = default!;
        private readonly PizzaService _service;

        public PizzaListModel(PizzaService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            PizzaList = _service.GetPizzas();
        }
    }
}
