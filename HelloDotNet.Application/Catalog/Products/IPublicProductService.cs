using System;
using System.Threading.Tasks;
using HelloDotNet.ViewModels.Catalog.Products;
using HelloDotNet.ViewModels.Common;

namespace HelloDotNet.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(
            GetPublicProductPagingRequest request);
    }
}
