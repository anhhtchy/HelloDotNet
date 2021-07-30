using System;
using System.Threading.Tasks;
using HelloDotNet.ViewModels.Catalog.Products;
using HelloDotNet.ViewModels.Catalog.Products.Public;
using HelloDotNet.ViewModels.Common;

namespace HelloDotNet.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(
            GetProductPagingRequest request);
    }
}
