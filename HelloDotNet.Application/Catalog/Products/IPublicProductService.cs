using System;
using System.Threading.Tasks;
using HelloDotNet.Application.Catalog.Products.DataTransferObjects;
using HelloDotNet.Application.Catalog.Products.DataTransferObjects.Public;
using HelloDotNet.Application.DataTransferObjects;

namespace HelloDotNet.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(
            GetProductPagingRequest request);
    }
}
