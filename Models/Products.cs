namespace mudblazor_augcenter.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductSku { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ProductCartDesc { get; set; } = string.Empty;
        public string ProductShortDesc { get; set; } = string.Empty;
        public string ProductLongDesc { get; set; } = string.Empty;
        public string ProductThumb { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public float? ProductStock { get; set; } = 50;
        public bool ProductLive { get; set; } = true;
        public bool ProductUnlimited { get; set; } = true;
        public string ProductLocation { get; set; }  = string.Empty;
        public int CategoryId { get; set; }
        public int TimestampId { get; set; }
    }
} 