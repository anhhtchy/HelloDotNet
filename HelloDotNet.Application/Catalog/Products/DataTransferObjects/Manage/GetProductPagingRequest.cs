using System;
using System.Collections.Generic;
using HelloDotNet.Application.DataTransferObjects;

namespace HelloDotNet.Application.Catalog.Products.DataTransferObjects.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
