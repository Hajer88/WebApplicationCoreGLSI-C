using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreGLSI_C.ServicesContracts;

namespace WebApplicationCoreGLSI_C.Controllers.APIControllers
{
   
    public class SousCategorieController : CustomController
    {
        private readonly ISousCategorieService sousCategorieService;
        public SousCategorieController(ISousCategorieService sousCategorieService)
        {
            this.sousCategorieService = sousCategorieService;
        }
        [HttpGet]
        //[Route("{name}")]
        //[Route("/api/test")]
        public IActionResult GettSsCat()
        {
            var c = sousCategorieService.GetAllSSCat();
            return Ok(c);
        }
    }
}
