using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private ICartService _cartService;
        private IPaymentService _paymentService;
        private IProductService _productService;
        public OrderFacade(ICartService cartService, IPaymentService paymentService, IProductService productService)
        {
            _cartService = cartService;
            _paymentService = paymentService;
            _productService = productService;
        }

        public void Order(int[] productIds, int cartId)
        {
            foreach (var id in productIds)
            {
                _cartService.AddProduct(id, _productService.GetPrice(id));
            }
            _paymentService.Pay(cartId, _cartService.GetPrice(cartId));
        }
    }
}
