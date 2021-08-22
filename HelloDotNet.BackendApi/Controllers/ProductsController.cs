using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloDotNet.Application.Catalog.Products;
using HelloDotNet.ViewModels.Catalog.ProductImages;
using HelloDotNet.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloDotNet.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(
            IPublicProductService publicProductService,
            IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //http://localhost:port/products/
        //  vi-VN?pageIndex=1&pageSize=10&categoryId=1
        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(
            string languageId,
            [FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService
                .GetAllByCategoryId(languageId, request);
            return Ok(products);
        }

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(
            int productId, string languageId)
        {
            var product = await _manageProductService
                .GetById(productId, languageId);
            if(product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _manageProductService
                .Create(request);
            if(productId == 0)
            {
                return BadRequest();
            }
            var product = await _manageProductService.GetById(
                productId, request.LanguageId);

            return CreatedAtAction(
                nameof(GetById),
                new { id = productId, languageId = request.LanguageId },
                product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(
            [FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var updatedResult = await _manageProductService
                .Update(request);
            if (updatedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var deletedResult = await _manageProductService
                .Delete(productId);
            if (deletedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(
            int productId, decimal newPrice)
        {
            var isSuccessful = await _manageProductService
                .UpdatePrice(productId, newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(
            int productId, int imageId)
        {
            var image = await _manageProductService
                .GetImageById(imageId);
            if (image == null)
            {
                return BadRequest();
            }
            return Ok(image);
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(
            int productId,
            [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _manageProductService
                .AddImage(productId, request);
            if (imageId == 0)
            {
                return BadRequest();
            }
            var image = await _manageProductService.GetImageById(imageId);

            return CreatedAtAction(
                nameof(GetImageById),
                new { id = imageId },
                image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(
            int productId,
            [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService
                .UpdateImage(productId, request);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            var removedResult = await _manageProductService
                .RemoveImage(imageId);
            if (removedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}