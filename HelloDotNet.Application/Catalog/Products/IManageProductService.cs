using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloDotNet.ViewModels.Catalog.Products;
using HelloDotNet.ViewModels.Common;
using Microsoft.AspNetCore.Http;

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
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(
            GetManageProductPagingRequest request);
    }
}
