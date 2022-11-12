using System;

namespace Api.Orders.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get;set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } 
    }
}
