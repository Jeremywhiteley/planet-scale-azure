﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Online.Store.Core.DTOs
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public double GrandTotal { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductModel { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
