﻿using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class ProductsAboveAveragePrice : EntityBase
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
