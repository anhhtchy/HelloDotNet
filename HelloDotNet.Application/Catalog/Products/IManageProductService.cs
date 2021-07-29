using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloDotNet.Application.Catalog.Products.DataTransferObjects;
using HelloDotNet.Application.Catalog.Products.DataTransferObjects.Manage;
using HelloDotNet.Application.DataTransferObjects;

namespace HelloDotNet.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(
            GetProductPagingRequest request);
    }
}
