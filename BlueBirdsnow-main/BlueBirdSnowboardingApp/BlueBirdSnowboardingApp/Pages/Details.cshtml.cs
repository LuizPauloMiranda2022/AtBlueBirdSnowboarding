using BlueBirdSnowboardingApp.models;
using BlueBirdSnowboardingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlueBirdSnowboardingApp.Pages
{
	public class DetailsModel : PageModel
    {
        private ISnowboardService _service;

        public string DescriptionBrand { get; set; }

        public DetailsModel(ISnowboardService service)
        {
            _service = service;
        }

        public Snowboard Snowboard { get; private set; }

        public IActionResult OnGet(int id)
        {
            //var service = new SnowboardService();
            Snowboard = _service.Obter(id);
            if(Snowboard.MarcaId is not null)
            {
                DescriptionBrand = _service.ObterMarca(Snowboard.MarcaId.Value).Descricao;
            }
          

            if(Snowboard == null)
            {
                return NotFound();
            }

            return Page();

        }
    }
}
