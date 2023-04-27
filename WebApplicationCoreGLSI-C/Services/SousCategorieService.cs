using Microsoft.EntityFrameworkCore;
using WebApplicationCoreGLSI_C.Models;
using WebApplicationCoreGLSI_C.ServicesContracts;

namespace WebApplicationCoreGLSI_C.Services
{
    public class SousCategorieService : ISousCategorieService
    {
        private readonly AppDbContext _context;
        public SousCategorieService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SousCategorie> GetAllSSCat()
        {
           //Query Syntax
            //var test = (from t in _context.sscategories
            //           select t)
            //           .ToList();
            //var x = test.Count();
            return _context.sscategories
                // .Include(c => c.categorie)
                //.OrderByDescending(c=>c.categorie.Name)
                .ToList();
            
        }
    }
}
