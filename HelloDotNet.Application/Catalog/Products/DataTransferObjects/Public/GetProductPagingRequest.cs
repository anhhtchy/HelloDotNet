using System;
using HelloDotNet.Application.DataTransferObjects;

namespace HelloDotNet.Application.Catalog.Products.DataTransferObjects.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
