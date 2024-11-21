﻿using System.ComponentModel.DataAnnotations;

namespace Supermarket2.api.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; }
    }

}

