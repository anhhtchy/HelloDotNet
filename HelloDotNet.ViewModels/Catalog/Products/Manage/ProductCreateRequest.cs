using System;
using Microsoft.AspNetCore.Http;

namespace HelloDotNet.ViewModels.Catalog.Products.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
