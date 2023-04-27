using AutoMapper;
using Azure.Messaging;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Diagnostics.Metrics;
using WebApplicationCoreGLSI_C.Models;
using WebApplicationCoreGLSI_C.Models.DTO;
using WebApplicationCoreGLSI_C.ServicesContracts;

namespace WebApplicationCoreGLSI_C.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper mapper;
        public CategorieService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            this.mapper = mapper;
        }

        public async Task<List<CategorieDTO>> GetAll()
        {
           
            //var test = (from c in _appDbContext.categories
            //           select c)
            //           .ToList();
           
            var a= await _appDbContext.categories
                .OrderBy(c=>c.Name).ToListAsync();
            var test = from p in _appDbContext.categories
                       select new CategorieDTO()
                       {
                           Name = p.Name,
                           Id = p.Id,
                       };
            return mapper.Map<List<CategorieDTO>>(a);
        }
        public CategorieDTO Create(CategorieDTO c)
        {
            //c.Id=Guid.NewGuid();
            var test = mapper.Map<Categorie>(c);
            _appDbContext.categories.Add(test);
            _appDbContext.SaveChanges();
            return c;
        }

        public Categorie Updatecat(Guid id, Categorie c)
        {
            
            var x = _appDbContext.categories.Find(id);
            
            x.Name=c.Name;
            _appDbContext.SaveChanges();
            return c;
        }
        public void RemoveCat(Guid id)
        {
            var c = _appDbContext.categories.Find(id);
            _appDbContext.categories.Remove(c);
            _appDbContext.SaveChanges();
        }
    }
}
