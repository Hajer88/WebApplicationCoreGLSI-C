using WebApplicationCoreGLSI_C.Models;

namespace WebApplicationCoreGLSI_C.ServicesContracts
{
    public interface ISousCategorieService
    {
        IEnumerable<SousCategorie> GetAllSSCat();
    }
}
