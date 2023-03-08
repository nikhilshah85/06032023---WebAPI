using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoppingAPP_inMemoryCollectionAPI.Models;
namespace shoppingAPP_inMemoryCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Products pObj = new Products(); //this is a bad code, we should use DI instead


        #region Get Methods
        [HttpGet]
        [Route("productlist")]
        public IActionResult GetAllProducts()
        {
            var result = pObj.GetAllProducts();
            return Ok(result);
        }

        [HttpGet]
        [Route("productlist/{productId}")]
        public IActionResult GetProductById(int productId)
        {
            try
            {
                var result = pObj.GetProductById(productId);
                return Ok(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        #endregion


        [HttpPost]
        [Route("productlist/add")]
        public IActionResult AddProduct([FromBody]Products newProduct)
        {
            var result = pObj.AddNewProduct(newProduct);

            return Created("", result);
        }

        [HttpDelete]
        [Route("productlist/delete/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                var result = pObj.DeleteProduct(productId);
                return Accepted(result);
            }
            catch (Exception es)
            {
                return Ok(es.Message);
                
            }            
        }

        [HttpPut]
        [Route("productId/edit")]
        public IActionResult EditProduct([FromBody]Products changes)
        {
            try
            {
                var result = pObj.EditProduct(changes);
                return Accepted(result);
            }
            catch (Exception es)
            {

                return Ok(es.Message);
            }
        }

    }
}
