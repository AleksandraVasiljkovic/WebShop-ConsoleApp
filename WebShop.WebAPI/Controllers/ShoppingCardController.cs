using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class ShoppingCardController: Controller
    {
        [HttpGet]
        [Route("api/GetOrdersLine")]
        public async Task<List<OrderLineModel>> GetOrderLineApi()
        {
            OrderLineBsn ordersLine = new OrderLineBsn();
            List<OrderLineModel> data = await ordersLine.Read();
            return data;
        }
        [Route("api/ProductToCard/{sessionKey}")]
        [HttpPost]
        public CheckoutModel ProductToCard([FromRoute()] string sessionKey,[FromBody]List<ProductModel> productFromSessionCard)
        {
            OrderLineBsn orderLineBsn = new OrderLineBsn();
            CheckoutModel checkoutModel = orderLineBsn.ProductToCard(sessionKey,productFromSessionCard);
            return checkoutModel;
        }
        
    }
}
