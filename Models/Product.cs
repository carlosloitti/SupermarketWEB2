using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal price { get; set; }
        public int stock { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int PayModeId { get; set; }
        public int ProviderId { get; set; }



        public PayMode PayMode { get; set; }

        public Provider Provider { get; set; }

    }
}
