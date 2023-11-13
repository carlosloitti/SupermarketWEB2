namespace SupermarketWEB2.Models
{
    public class PayMode
    {
        public int Pay_Mode_Id { get; set; }
        public string Pay_Mode_Name { get; set; }
        public string? Pay_Mode_Observation { get; set; }

        public ICollection<Product>? Products { get; set; } = default!;
    }
}