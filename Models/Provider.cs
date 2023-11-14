﻿namespace SupermarketWEB2.Models
{
    public class Provider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}