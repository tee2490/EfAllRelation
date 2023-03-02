﻿using Microsoft.EntityFrameworkCore;

namespace EfAllRelation.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        
    }
}
