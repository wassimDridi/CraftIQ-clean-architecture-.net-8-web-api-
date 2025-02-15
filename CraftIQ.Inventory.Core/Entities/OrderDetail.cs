using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid _OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        //relation with orders
        public int OrderId { get; set; }
        public Order Order { get; set; } = new();

        //relation with products
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public OrderDetail(int quantity, decimal totalPrice)
        {
            _OrderDetailId = Guid.NewGuid();
            Quantity = quantity;
            TotalPrice = totalPrice;
            CreatedBy = new();
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedOn = DateTimeOffset.Now;
        }
        /*
        public void UpdateOrderDetail(OrderDetailsOperationsContract orderDetail)
        {
            ModifiedOn = DateTimeOffset.Now;
            Quantity = orderDetail.Quantity == 0 ? this.Quantity : orderDetail.Quantity;
            TotalPrice = orderDetail.TotalPrice == 0 ? this.TotalPrice : orderDetail.TotalPrice;
        }
        */
        public void SetProduct(Product product) =>
            Product = product;

        public void SetOrder(Order order) =>
            Order = order;
    }
}
