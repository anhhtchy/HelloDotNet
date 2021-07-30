using System;
using HelloDotNet.ViewModels.Common;

namespace HelloDotNet.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
