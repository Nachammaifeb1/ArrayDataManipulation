using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Services;

namespace Array_Data_Manipulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IProductService _productService;
        public ArrayCalcController(IProductService productService)
        {
            _productService = productService;

        }
        // GET: api/ArrayCalc
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ArrayCalc/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ArrayCalc
        /// <summary>
        /// Reverse input data
        /// </summary>
        /// <param name="productIds"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("reverse")]
        public int[] Reverse([FromQuery] int[] productIds)
        {
            int[] ReversedArray = _productService.Reverse(productIds);


            return ReversedArray;
        }

        // PUT: api/ArrayCalc/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        /// <summary>
        /// Delete Part from given input data
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="productIds"></param>
        /// <returns></returns>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("deletepart")]
        public int[] DeletePart(int Position, int[] productIds)
        {
            int[] UpdatedArray = _productService.DeletePart(Position, productIds);


            return UpdatedArray;


        }
    }
}
