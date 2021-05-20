using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services.Communication
{
    public class ProductResponse: BaseResponse
    {
        public Product Product { get; private set; }

        public ProductResponse(bool success, string message, Product product): base(success, message)
        {
            Product = product;
        }

        /// <summary>
        /// Creates a success product response
        /// </summary>
        /// <param name="product"></param>
        public ProductResponse(Product product): this(true, string.Empty, product)
        { }

        /// <summary>
        /// Creates an error product response
        /// </summary>
        /// <param name="message"></param>
        public ProductResponse(string message): this(false, message, null)
        { }
    }
}
