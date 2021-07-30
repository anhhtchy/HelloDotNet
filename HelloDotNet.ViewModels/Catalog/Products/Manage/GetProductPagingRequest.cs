using System;
using System.Collections.Generic;
using HelloDotNet.ViewModels.Common;

namespace HelloDotNet.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
