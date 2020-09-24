using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class OrderLineBsn
    {
        public IOrderLineData orderLineData;
        public OrderLineBsn()
        {
            orderLineData = new OrderLineEFData();
        }
        public async Task<List<OrderLineModel>> Read()
        {
            return orderLineData.ReadOrderLines();
        }
        public bool Insert(OrderLineModel orderLineModel)
        {
            try
            {
                orderLineData.InsertOrderLine(orderLineModel);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(OrderLineModel orderLineModel)
        {
            orderLineData.UpdateOrderLine(orderLineModel);
        }

        public void Delete(int id)
        {
            orderLineData.DeleteOrderLine(id);
        }
        public CheckoutModel ProductToCard(string sessionKey,List<ProductModel> productFromSessionCard)
        {
            ProductEFData productData = new ProductEFData();
            CheckoutModel checkoutModel = orderLineData.ProductToCard(sessionKey,productFromSessionCard);
            var products = productData.ReadProducts().ToArray();
;           foreach(var item in checkoutModel.orderLines)
            {
                item.Product = products.Where(products => products.ProductId == item.ProductId).FirstOrDefault();
            }
            return checkoutModel;
        }
    }
}
