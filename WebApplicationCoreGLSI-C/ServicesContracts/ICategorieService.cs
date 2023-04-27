using WebApplicationCoreGLSI_C.Models;
using WebApplicationCoreGLSI_C.Models.DTO;

namespace WebApplicationCoreGLSI_C.ServicesContracts
{
    public interface ICategorieService
    {
        Task<List<CategorieDTO>> GetAll();
        CategorieDTO Create(CategorieDTO c);

        Categorie Updatecat(Guid id,Categorie c);
        void RemoveCat(Guid id);
    }
}
