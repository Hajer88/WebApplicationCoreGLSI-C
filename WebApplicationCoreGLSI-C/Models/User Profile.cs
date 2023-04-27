using AutoMapper;
using WebApplicationCoreGLSI_C.Models.DTO;

namespace WebApplicationCoreGLSI_C.Models
{
    public class User_Profile : Profile
    {
        public User_Profile()
        {
            CreateMap<CategorieDTO, Categorie>()
                ;
               
            CreateMap<Categorie, CategorieDTO>();
        }
    }
}
