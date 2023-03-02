﻿using Microsoft.EntityFrameworkCore;

namespace EfAllRelation.Models
{
    [Owned]
    public class ProductExtend
    {
        public string Color { get; set; }
        public double Weight { get; set; }
    }
}
