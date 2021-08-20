﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloDotNet.ViewModels.Catalog.ProductImages;
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
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(
            GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId,
            ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}
