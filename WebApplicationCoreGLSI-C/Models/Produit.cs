﻿namespace WebApplicationCoreGLSI_C.Models
{
    public class Produit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<SousCategorie> sousCat { get; set; }
    }
}
