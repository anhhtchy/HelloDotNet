using System;
using HelloDotNet.ViewModels.Common;

namespace HelloDotNet.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
        public string LanguageId { get; set; }
    }
}
