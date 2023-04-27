using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreGLSI_C.Models;
using WebApplicationCoreGLSI_C.Models.DTO;
using WebApplicationCoreGLSI_C.ServicesContracts;

namespace WebApplicationCoreGLSI_C.Controllers.APIControllers
{
   
    public class CategorieController : CustomController
    {
        private readonly ICategorieService categorieService;
        public CategorieController(ICategorieService categorieService)
        {
            this.categorieService = categorieService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCat()
        {
            var c = await categorieService.GetAll();
            return Ok(c);
        }
        [HttpPost]
        public IActionResult CreateCat(CategorieDTO c)
        {
            var categorie = categorieService.Create(c);
            return Ok(categorie);
        }
        [HttpPut]
        public IActionResult UpdateCattest(Guid id, Categorie c)
        {
            var test=categorieService.Updatecat(id,c);
            return Ok(test);
        }
        [HttpDelete]
        public IActionResult DeleteCat(Guid id)
        {
            categorieService.RemoveCat(id);
            return Ok();
        }
    }
}
